using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin.User_Control
{
    public partial class LoginCube : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text == "abc" && TxtUser.Text == "123")
            {
                Session["Login"] = "ok";
                Response.Redirect("/AdminManger");
            }
            else
            {

            }
        }
    }
}