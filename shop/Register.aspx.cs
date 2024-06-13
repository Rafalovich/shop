using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace shop
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                var LsCity =(List<City>) Application["City"];
                for(int i=0; i< LsCity.Count;i++)
                {
                    DDLCity.Items.Add(new ListItem(LsCity[i].CityName, LsCity[i].CityId + ""));
                    DDLCity.Text = LsCity[i].CityName;
                    
                }
                DDLCity.Items.Insert(0, "בחר עיר");
            }
           
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if(chkTerm.Checked == false)
            {
                Msg += "עליך להסכים לתנאי האתר<br/>";
            }
            if(RDFemale.Checked == false)
            {
                Msg += "";
            }
            if (TxtFullName.Text.Length<3)
            {
                Msg += "עליך להזין שם מלא<br/>";
            }
            if(TextPassord.Text.Length<3)
            {
                Msg += "סיסמא לא תקינה<br/>";
            }
            if(Msg !="")
            {
                LtMsg.Text = Msg;
            }
            else
            {
                LtMsg.Text = "נרשמת בהצלחה ברוך הבא";
            }
        }
    }
}