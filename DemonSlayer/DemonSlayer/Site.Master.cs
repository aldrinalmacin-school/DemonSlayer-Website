using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemonSlayer
{
  public partial class SiteMaster : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current.User.IsInRole("Admin"))
      {
        NavigationMenu.Items[3].Enabled = true;
        NavigationMenu.Items[4].Enabled = true;
        NavigationMenu.Items[5].Enabled = true;
        NavigationMenu.Items[6].Enabled = true;
        NavigationMenu.Items[7].Enabled = true;
      }
      else if (HttpContext.Current.User.IsInRole("User"))
      {
        NavigationMenu.Items[3].Enabled = true;
        NavigationMenu.Items[4].Enabled = false;
        NavigationMenu.Items[5].Enabled = false;
        NavigationMenu.Items[6].Enabled = false;
        NavigationMenu.Items[7].Enabled = false;
      }
      else
      {
        //NavigationMenu.Items[3].Enabled = false;
        //NavigationMenu.Items[4].Enabled = false;
        //NavigationMenu.Items[5].Enabled = false;
        //NavigationMenu.Items[6].Enabled = false;
        //NavigationMenu.Items[7].Enabled = false;
      }
    }
  }
}
