using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer.Admin
{
  public partial class EditHome : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPost_Click(object sender, EventArgs e)
    {

      BusinessRules.CPost objPost = new BusinessRules.CPost();
      int userID = BusinessRules.CUser.getUserID(HttpContext.Current.User.Identity.Name);
      objPost.createPost(txtPost.Text, userID);
      Response.Redirect("/Default.aspx", true);
    }
  }
}