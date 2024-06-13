using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin
{
    public partial class ProductAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//במידה וזו טעינה חדשה של העמוד
            {
                string Pid = Request["pid"] + "";
                if (string.IsNullOrEmpty(Pid))
                {
                    Pid = "-1";
                }
                else
                {
                    FillData(Pid);
                }
            }
        }
        public void FillData(string Pid)
        {
            Product tmp =Product.GetById(int.Parse(Pid));
            if(tmp == null)
            {
                Pid = "-1";
            }
            else
            {
                HidPid.Value = Pid;
                TxtPname.Text = tmp.Pname;
                TxtPrice.Text = tmp.Price + "";
                TextProdDesc.Text = tmp.PDesc;
                TxtPic.Text = tmp.PicName;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string PicName;
            if (PicUpload.HasFile)
            {
                PicName = GlobFunc.GetRandStr(8);
                string Ext = Path.GetExtension(PicUpload.FileName);
                string ext = PicUpload.FileName.Substring( PicUpload.FileName.LastIndexOf('.'));
                string NewName = PicName + ext;
                string FullPath = Server.MapPath("/upload/products/") + NewName;
                PicUpload.SaveAs(FullPath);
                PicName = NewName;


            }
            else
            {
                PicName = TxtPic.Text;
            }
            Product tmp = new Product() 
            {
                Pid = int.Parse(HidPid.Value),
                Pname = TxtPname.Text,
                Price =int.Parse( TxtPrice.Text),
                PicName = PicName,
                PDesc = TextProdDesc.Text
            };
            tmp.Save();
            Application["Product"] = Product.GetAll();
            Response.Redirect("ProductsList.aspx");
        }
    }
}