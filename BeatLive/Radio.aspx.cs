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
    public partial class Radio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void generate()
        {
            string songs = @"";
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            SqlCommand t = new SqlCommand("SELECT * FROM " + Request.QueryString["name"], c);
            c.Open();
            SqlDataReader r = t.ExecuteReader();
            while (r.Read())
            {

                songs += "/"+Request.QueryString["name"]+ "/Music/"+(string)r[2]+",";
            }
            r.Close();
            songs = songs.Substring(0,songs.Length-1);
            Response.Write(songs);


        }
        public void gcolor()
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            c.Open();
            SqlCommand t = new SqlCommand("SELECT * FROM Radios WHERE name=@n", c);
            t.Parameters.Add(new SqlParameter("@n", Request.QueryString["name"]));
            SqlDataReader r = t.ExecuteReader();
            while(r.Read())
            {
                if ((string)r[1] == "Dark")
                    Response.Write("Black");
                else
                    Response.Write("White");
            }
            r.Close();

            
        }
        public void gocolor()
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            c.Open();
            SqlCommand t = new SqlCommand("SELECT * FROM Radios WHERE name=@n", c);
            t.Parameters.Add(new SqlParameter("@n", Request.QueryString["name"]));
            SqlDataReader r = t.ExecuteReader();
            while (r.Read())
            {
                if ((string)r[1] == "Dark")
                    Response.Write("White");
                else
                    Response.Write("Black");
            }
            r.Close();


        }
        public void gabout()
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            c.Open();
            SqlCommand t = new SqlCommand("SELECT * FROM Radios WHERE name=@n", c);
            t.Parameters.Add(new SqlParameter("@n", Request.QueryString["name"]));
            SqlDataReader r = t.ExecuteReader();
            while (r.Read())
            {
                    Response.Write((string)r[4]);
            }
            r.Close();


        }
        public void gnews()
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            c.Open();
            SqlCommand t = new SqlCommand("SELECT * FROM Radios WHERE name=@n", c);
            t.Parameters.Add(new SqlParameter("@n", Request.QueryString["name"]));
            SqlDataReader r = t.ExecuteReader();
            while (r.Read())
            {
                Response.Write((string)r[5]);
            }
            r.Close();


        }
    }
}