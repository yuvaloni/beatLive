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
    public partial class Listen : System.Web.UI.Page
    {
        static Socket l;
        protected void Page_Load(object sender, EventArgs e)
        {
            l = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            l.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(Request.QueryString["p"])));
            listen();
        }
        public void listen()
        {
            byte[] buffer = new byte[1024];
            l.Receive(buffer);
            Response.Write(ASCIIEncoding.ASCII.GetString(buffer));
            
        }
    }
}