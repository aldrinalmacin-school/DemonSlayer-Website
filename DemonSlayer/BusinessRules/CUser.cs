using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BusinessRules
{
  public class CUser
  {
    SqlConnection objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);
    public string hashPassword(string password, string salt)
    {
      var combinedPassword = String.Concat(password, salt);
      var sha256 = new SHA256Managed();
      var bytes = UTF8Encoding.UTF8.GetBytes(combinedPassword);
      var hash = sha256.ComputeHash(bytes);
      return Convert.ToBase64String(hash);
    }

    public string getRandomSalt(Int32 size = 12)
    {
      var random = new RNGCryptoServiceProvider();
      var salt = new Byte[size];
      random.GetBytes(salt);
      return Convert.ToBase64String(salt);
    }

    public bool validatePassword(string enteredPassword, string storedHash, string storedSalt)
    {
      var hash = hashPassword(enteredPassword, storedSalt);
      return String.Equals(storedHash, hash);
    }

    public void register(string username, string password, string role)
    {
      string salt = getRandomSalt(12);
      string hashedPassword = hashPassword(password, salt);

      objConn.Open();

      SqlCommand objCmd = new SqlCommand("spRegister", objConn);
      objCmd.CommandType = System.Data.CommandType.StoredProcedure;
      objCmd.Parameters.AddWithValue("@Username", username);
      objCmd.Parameters.AddWithValue("@Password", hashedPassword);
      objCmd.Parameters.AddWithValue("@SaltString", salt);
      objCmd.Parameters.AddWithValue("@Role", role);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }

    public string login(string username, string password)
    {
      objConn.Open();
      string strSQL = "SELECT * FROM Users WHERE Username = '" + username + "'";
      SqlCommand objCmd = new SqlCommand(strSQL, objConn);

      SqlDataReader objRdr = objCmd.ExecuteReader();
      string role = "";

      while (objRdr.Read())
      {
        if (validatePassword(password, objRdr.GetString(2), objRdr.GetString(3)))
        {
          role = objRdr.GetString(4);
        }
      }

      //clean up
      objCmd.Dispose();
      objConn.Close();
      return role;
    }
  }
}
