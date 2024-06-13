using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Data;
using System.Data;

namespace DAL
{
    public class ClientDAL
    {
        public static bool ChekLogin(Client tmp)//הפונקציה מחזירה את כל רשימת המוצרים המערכת מתוך בסיס הנתונים
        {
            bool status = false;
            //string ConnStr;
            string Sql = $"select * from t_Client Where Email ='{tmp.Email}' and Pass = '{tmp.Pass}'";//הגדרת מחרוזת עם משפט שאילתה
            DbContext Db = new DbContext(); 
            DataTable Dt = Db.Execute(Sql);


            //ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            //SqlConnection Conn = new SqlConnection();//
            //Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            //Conn.Open();//פתיחת הצינור לבסיס הנתונים
            //SqlCommand Cmd = new SqlCommand();//הגדרת אובייקט מסוג פקודה של שאילתות
            //Cmd.Connection = Conn;//הגדרת הצינור בו ישתמש אובייקט הפקודה
            //Cmd.CommandText = Sql;//הגדרת השאילתה אותה ברצוננו לבצע
            //SqlDataReader Dr;//הגדרת משתנה מסוג קורא נתונים שחזרו משאילתות סלקט
            // Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו
           
            if (Dt.Rows.Count > 0)
            {      
                 tmp.CId = (int)Dt.Rows[0]["Cid"];
                 tmp.FullName = Dt.Rows[0]["FullName"] + "";
                 status = true;
            }
            Db.Close();
            
            return status;
        }
        public static void Save(Client tmp)
        {
            string Sql = "";
            if(tmp.CId ==-1)
            {
                Sql += $"insert into t_client(Email, Pass, FullName) ";
                Sql += $" values(N'{tmp.Email}',N'{tmp.Pass}',N'{tmp.FullName}') ";
            }
            else
            {
                Sql = "update t_client set ";
                Sql += $" Email = N'{tmp.Email}',";
                Sql += $" Pass = N'{tmp.Pass}',";
                Sql += $" Added = '{tmp.Added}'";
                Sql += $" where cid ={tmp.CId}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);
            if (tmp.CId == -1)
            {
                Sql = $"select max(CId) from t_client Where Email = N'{tmp.Email}' ";
                tmp.CId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }
        public static List<Client> GetAll()
        {
            List<Client> LstClient = new List<Client>();
            string Sql = "select * from t_client ";//הגדרת מחרוזת עם משפט שאילתה
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                LstClient.Add(new Client()
                {
                    CId = (int)Dt.Rows[i]["cid"],
                    Email = Dt.Rows[i]["Email"] + "",
                    Pass = Dt.Rows[i]["Pass"] + "",
                    FullName = Dt.Rows[i]["FullName"] + "",
                    Added = (DateTime)Dt.Rows[i]["Added"]
                });
            }
            DB.Close();
            return LstClient;
        }
        public static Client GetById(int Id)
        {
            Client tmp = null;
            string Sql = $"select * from t_client Where cid={Id}";
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
            if (Dt.Rows.Count > 0)
            {
                tmp = new Client()
                {
                    CId = (int)Dt.Rows[0]["cid"],
                    Email = Dt.Rows[0]["Email"] + "",
                    Pass = Dt.Rows[0]["Pass"] + "",
                    FullName = Dt.Rows[0]["FullName"] + "",
                    Added = (DateTime)Dt.Rows[0]["Added"]
                };
            }
            DB.Close();
            return tmp;
        }
        public static int DeleteById(int id)
        {
            int RetVal = 0;
            string Sql = $"delete * from t_client Where cid={id}";//הגדרת מחרוזת עם משפט שאילתה
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            //הפונקציה משמשת לשאילתות שלא שולפות נתונים, כגון מחיקה עדכון והוספה
            Db.Close();
            return RetVal;
        }
    }
}