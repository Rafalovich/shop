using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin
{
    public partial class UserAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string UserId = Request["UserId"];
                if(string.IsNullOrEmpty(UserId))
                {
                    UserId = "-1";
                }
                else
                {
                    FillData(UserId);
                }
            }
        }
        public void FillData(string UserId)
        {
            Users tmp = Users.GetById(int.Parse(UserId));
            if(tmp == null)
            {
                UserId = "-1";
            }
            else
            {
                HidUserId.Value = UserId;
                TxtFName.Text = tmp.FName;
                TextLName.Text = tmp.LName;
                TextCityId.Text = tmp.CityId + "";
                TextAddres.Text = tmp.Addres;
                TextMail.Text = tmp.Mail;
                TextPass.Text = tmp.Password;
                TextBirth.Text = tmp.BirthDate + "";
                TextPhone.Text = tmp.Phone;
                TextReg.Text = tmp.RegisDate + "";
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Users tmp = new Users()
            {
                UserId = int.Parse(HidUserId.Value),
                FName = TxtFName.Text,
                LName = TextLName.Text,
                CityId = int.Parse(TextCityId.Text),
                Addres = TextAddres.Text,
                Mail = TextMail.Text,
                Password = TextPass.Text,
                BirthDate =  DateTime.Parse( TextBirth.Text),
                Phone = TextPhone.Text,
                RegisDate = DateTime.Parse(TextReg.Text)
            };
            tmp.Save();
            Application["Users"] = Users.GatAll();
            Response.Redirect("UsersLists.aspx");

        }
    }
}