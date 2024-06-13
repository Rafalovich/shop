using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace shop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            var LstClinet = (List<Client>)Application["Clints"];
           
            for (int i = 0; i < LstClinet.Count; i++)
            {
                if(TextEmail.Text == LstClinet[i].Email && TextPassord.Text == LstClinet[i].Pass+"")
                {
                    Session["login"] = true;
                    Response.Redirect("Acount.aspx");
                }
            }

            Client tmp = new Client()
            {
                Email = TextEmail.Text,
                Pass = TextPassord.Text
            };
            if(tmp.ChekLogin())
            {
                Session["ClientLogin"] = tmp; // נשמור את אובייקט הלקוח בתוך משתנה מסוג סשן
                Response.Redirect("/ProductEdit.aspx");
            }





            //if (TextEmail.Text != "abc" || TextPassord.Text != "123")
            //{
            //    Msg = "שם וסיסמא שגויים";
            //}
            //if(Msg != "")
            //{
            //    LtMsg2.Text = Msg;
            //}
            //else
            //{
            //    LtMsg2.Text = "התחברת בהצלחה ";
                
            //}
        }
    }
}