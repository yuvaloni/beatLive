using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
namespace BeatLive
{
    public partial class success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["rid"] = null;
            Thread.Sleep(3000);
            Response.Redirect("login.aspx");
        }
    }
}