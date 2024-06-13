using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Btn2.Text = "שנה שם";
            for(int i = 0; i < 10; i++)
            {
                Response.Write($"<h1>{i+1}<h1>");
                string FullName = "";
                string Fname = "Yaron";
                string Lname = "Lapidot";
                FullName = $"My name is{Fname}{Lname} and I";
                Response.Write(FullName);
            }
        }
    }
}