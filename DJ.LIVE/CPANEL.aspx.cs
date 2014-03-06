using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace DJ.LIVE

{
    public partial class CPANEL : System.Web.UI.Page
    {
        int port;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["p"] == null)
            {
                Random rnd = new Random();
                port = rnd.Next(12345, 54322);
                Session["p"] = port;
            }
            port = (int)Session["p"];
            Response.Write(port);


        }
        public void Send()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            s.SendTo(ASCIIEncoding.ASCII.GetBytes("Imashca"),new IPEndPoint(IPAddress.Parse("127.0.0.1"),port));
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}