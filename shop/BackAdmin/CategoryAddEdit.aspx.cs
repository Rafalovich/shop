using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace shop.BackAdmin
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string CategId = Request["CategId"]+"";
                if(string.IsNullOrEmpty(CategId))
                {
                    CategId = "-1";
                }
                else
                {
                    FillData(CategId);
                }
            }
        }
        public void FillData(string CategId)
        {
            Category tmp = Category.GetById(int.Parse(CategId));
            if(tmp == null)
            {
                CategId="-1";
            }
            else
            {
                HidCategId.Value = CategId;
                TxtPnameC.Text = tmp.CategName;
                TxtDescC.Text = tmp.CategDesc;
                TxtPicC.Text = tmp.CategDesc;
                TxtPicC.Text = tmp.CategPicName;
                TxtCatFa.Text = tmp.CategFather + "";
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Category tmp = new Category()
            {
                CategId = int.Parse(HidCategId.Value),
                CategName =TxtPnameC.Text,
                CategDesc =TxtDescC.Text,
                CategPicName = TxtPicC.Text,
                CategFather = int.Parse(TxtCatFa.Text)

            };
            tmp.Save();
            Application["Category"] = Category.GetAll();
            Response.Redirect("CategoriesLists.aspx");
        }
    }
}