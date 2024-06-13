using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace shop
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
            
            string ConnStr;
            string Sql = "select * from t_products";//הגדרת מחרוזת עם משפט שאילתה
            string Sql1 = "select * from t_category";
            string Sql2 = "select * from T_City";
            string Sql3 = "select * from T_Client";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            //ConfigurationManager שןלח אותנו לדף config
            //ConnectionStrings שולח להגדרות שנמצאות במשתנה זה
            //ConnStr ואז שולח אותנו למשתנה הזה
            SqlConnection Conn = new SqlConnection();//יצירת אובייקט מסוג SqlConnection = חיבור לSQL
            Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            Conn.Open();//פתיחת הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();//הגדרת אובייקט מסוג פקודה של שאילתות
            SqlCommand Cmd1 = new SqlCommand();
            Cmd.Connection = Conn;//הגדרת הצינור בו ישתמש אובייקט הפקודה
            Cmd1.Connection = Conn;
            Cmd.CommandText = Sql;//הגדרת השאילתה אותה ברצוננו לבצע
            Cmd1.CommandText = Sql1;
            Cmd1.CommandText = Sql2;
            Cmd1.CommandText = Sql3;
            SqlDataReader Dr;//הגדרת משתנה מסוג קורא נתונים שחזרו משאילתות סלקט
            Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו
                                     //נבצע לולאה שעוברת רשומה רשומה על התוצאות שחזרו 
            List<City> LsCity = new List<City>();
            Dr.Close();
            Application["Product"] = Product.GetAll();//
            Application["Category"] = Category.GetAll();
            Application["City"] = LsCity;
            
            City tmp2;
            
         
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql2;
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                tmp2 = new City()
                {
                    CityId = (int)Dr["CityId"],
                    CityName = Dr["CityName"] + ""
                };
                LsCity.Add(tmp2);
            }
            Dr.Close();
            
           
            List<Client> LstClinet = new List<Client>();
            Client tmp3;
            
          
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql3;
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                tmp3 = new Client()
                {
                    CId = (int)Dr["CId"],
                    Email = Dr["Email"] + "",
                    Pass = Dr["Pass"] + "",
                    FullName = Dr["FullName"] + ""
                };
                LstClinet.Add(tmp3);
            }
            Dr.Close();
            Application["Clints"] = LstClinet;
            Conn.Close();
            
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}