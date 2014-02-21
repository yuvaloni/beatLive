using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BeatLive
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(Server.MapPath("~"),"Music");
            Response.Write("SUCCESS");
        }
    }
}