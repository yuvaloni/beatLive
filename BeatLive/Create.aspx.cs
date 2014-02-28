using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace BeatLive
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("Dark");
                DropDownList1.Items.Add("Bright");

            }
            if(Session["rid"]!=null)
            {
                SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
                SqlCommand r = new SqlCommand("SELECT * FROM Radios Where name = "+(string)Session["rid"], c);
                SqlCommand d = new SqlCommand("DROP TABLE " + (string)Session["rid"], c);
                r.ExecuteNonQuery();
                d.ExecuteNonQuery();
                Directory.Delete(Path.Combine(Server.MapPath("~"), (string)Session["rid"]));
                c.Close();
                Session["rid"] = null; 
            }

            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            SqlCommand t = new SqlCommand("SELECT * FROM Radios", c);
            c.Open();
            SqlDataReader r = t.ExecuteReader();
            bool valid = true;
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                Response.Write("you have some empty fields!");
                valid = false;
            }

            while(r.Read())
            {

                if ((string)r[0] == TextBox1.Text)
                {
                    Response.Write("name already taken!");
                    valid = false;
                }

                if ((string)r[2] == TextBox1.Text)
                {
                    Response.Write("username already taken!");
                    valid = false;
                }
                
                

            }
            r.Close();
            if(valid)
            {
                SqlCommand u = new SqlCommand("INSERT INTO Radios([name],style,[user],[password]) values (@n,@s,@u,@p);CREATE TABLE "+TextBox1.Text+" ([name] varchar(255), artist varchar(255), [file] varchar(255))", c);
                u.Parameters.Add(new SqlParameter("@n", TextBox1.Text));
                u.Parameters.Add(new SqlParameter("@s", DropDownList1.SelectedItem.Value));
                u.Parameters.Add(new SqlParameter("@u", TextBox2.Text));
                u.Parameters.Add(new SqlParameter("@p", TextBox3.Text));
                u.ExecuteNonQuery();
                Session["rid"] = TextBox1.Text;

                Directory.CreateDirectory(Path.Combine(Server.MapPath("~"), TextBox1.Text));
                Directory.CreateDirectory(Path.Combine(Server.MapPath("~"), TextBox1.Text, "Music"));
                File.WriteAllBytes(Path.Combine(Server.MapPath("~"), TextBox1.Text, "Logo.jpg"), FileUpload1.FileBytes);

                
            }
        }
    }
}