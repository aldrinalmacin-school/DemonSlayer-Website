using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BusinessRules
{
  public class CPost
  {
    SqlConnection objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString);

    public void createPost(string post, int userID)
    {
      objConn.Open();
      string strSQL = "INSERT INTO Posts (Post, UserID) VALUES ('" + post + "', " + userID + ");";
      SqlCommand objCmd = new SqlCommand(strSQL, objConn);
      objCmd.ExecuteNonQuery();

      objCmd.Dispose();
      objConn.Close();
    }
  }
}
