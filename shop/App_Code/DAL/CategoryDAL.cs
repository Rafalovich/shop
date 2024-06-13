using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Design;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CategoryDAL
    {
        public static void Save(Category Tmp)
        {
            int RetVal = 0;
            string ConnStr;
            string Sql = "";
            if (Tmp.CategId == -1)
            {
                Sql += $"insert into T_Category(CategName,CategDesc,CategPicName,CategFather) ";
                Sql += $" values(N'{Tmp.CategName}',N'{Tmp.CategDesc}',N'{Tmp.CategPicName}',{Tmp.CategFather} )";
            }
            else
            {
                Sql += "update T_Category set ";
                Sql += $" CategName =N'{Tmp.CategName}' ,";
                Sql += $" CategDesc =N'{Tmp.CategDesc}' ,";
                Sql += $" CategPicName =N'{Tmp.CategPicName}',";
                Sql += $" CategFather ={Tmp.CategFather} ";
                Sql += $"where CategId ={Tmp.CategId} ";
            }
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnStr;
            Conn.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;
            RetVal = Cmd.ExecuteNonQuery();
            if(Tmp.CategId == -1)
            {
                Sql += $"select max(CategId) from T_Category where CategName = N'{Tmp.CategName}' ";
                Cmd.CommandText = Sql;
                Tmp.CategId = (int) Cmd.ExecuteScalar();
                Conn.Close();
            }
        }
        public static List<Category> GetAll()
        {
            List<Category> LstCateg = new List<Category>();
            string ConnStr;
            string Sql = "select * from T_Category ";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();//
            Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            Conn.Open();//פתיחת הצ

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = Sql;
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            while(Dr.Read())
            {
                LstCateg.Add(new Category()
                {
                    CategId = int.Parse(Dr["CategId"]+""),
                    CategName = Dr["CategName"]+"",
                    CategDesc = Dr["CategDesc"]+"",
                    CategPicName = Dr["CategPicName"]+"",
                    CategFather =int.Parse( Dr["CategFather"]+"")
                });
               
                 
            }
            Dr.Close();
            Conn.Close();
            return LstCateg;
        }
        public static Category GetById(int id)
        {
            Category tmp = null;
            string ConnStr;
            string Sql = $"select * from T_Category where CategId={id}";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();//
            Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            Conn.Open();//פתיחת הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();//הגדרת אובייקט מסוג פקודה של שאילתות
            Cmd.Connection = Conn;//הגדרת הצינור בו ישתמש אובייקט הפקודה
            Cmd.CommandText = Sql;//הגדרת השאילתה אותה ברצוננו לבצע
            SqlDataReader Dr;//הגדרת משתנה מסוג קורא נתונים שחזרו משאילתות סלקט
            Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו
                                     //נבצע לולאה שעוברת רשומה רשומה על התוצאות שחזרו 
            if(Dr.Read())
            {
                tmp = new Category()
                {
                    CategId = (int)Dr["CategId"],
                    CategName = Dr["CategName"] + "",
                    CategDesc = Dr["CategDesc"] + "",
                    CategPicName = Dr["CategPicName"] + "",
                    CategFather = (int)Dr["CategFather"]
                };
            }
            Dr.Close();
            Conn.Close();
            return tmp;
        }
        public static int DeleteById(int id)
        {
            int RetVal = 0;
            string ConnStr;
            string Sql = $"delete * from T_Category where pid={id}";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();//
            Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            Conn.Open();//פתיחת הצינור לבסיס הנתונים
            SqlCommand Cmd = new SqlCommand();//הגדרת אובייקט מסוג פקודה של שאילתות
            Cmd.Connection = Conn;//הגדרת הצינור בו ישתמש אובייקט הפקודה
            Cmd.CommandText = Sql;//הגדרת השאילתה אותה ברצוננו לבצע
            RetVal = Cmd.ExecuteNonQuery();//הפונקציה משמשת לשאילתות שלא שולפות נתונים, כגון מחיקה עדכון והוספה
            Conn.Close();
            return RetVal;
        }
    }
}