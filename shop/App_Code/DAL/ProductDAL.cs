using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using Data;
using System.Data;

namespace DAL
{
    public class ProductDAL
    {
        public static void Save(Product Tmp)//הפונקצי תקבל מוצר ותשמור אותו בבסיס הנתונים
        {
           
            
            string Sql = "";
            if (Tmp.Pid == -1)//בדיקה האם המוצר הינו מוצר חדש
            {
                Sql = $"insert into t_products(Pname,Price,Pdesc,Picname ) ";
                Sql += $" values(N'{Tmp.Pname}',{Tmp.Price},N'{Tmp.PDesc}',N'{Tmp.PicName}')";
            }
            else
            {
                Sql = "update t_products set ";
                Sql += $" Pname =N'{Tmp.Pname}',";
                Sql += $"Price ={Tmp.Price},";
                Sql += $"PDesc =N'{Tmp.PDesc}',";
                Sql += $"PicName =N'{Tmp.PicName}' ";
                Sql += $" where pid ={Tmp.Pid}";
            }

            

            DbContext DB = new DbContext();
            DB.ExecuteNonQuery(Sql);
            if(Tmp.Pid == -1)
            {
                Sql = $"select max(Pid) from t_products Where Pname=N'{Tmp.Pname}' ";
                
                Tmp.Pid=(int) DB.ExecuteScalar(Sql);//פונקצי העבור תא בודד החוזר מהדאטא בייס פונקציה זו לא יכולה לקבל יותר מערך אחד
            }
            DB.Close();
        }
        public static List<Product> GetAll()//הפונקציה מחזירה את כל רשימת המוצרים המערכת מתוך בסיס הנתונים
        {
            List<Product> LstProd = new List<Product>();
            Product tmp;
           
            string Sql = "select * from t_products";//הגדרת מחרוזת עם משפט שאילתה
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
            //SqlDataReader Dr;//הגדרת משתנה מסוג קורא נתונים שחזרו משאילתות סלקט
            //Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו
            //נבצע לולאה שעוברת  על טבלת הנתונים רשומה רשומה על התוצאות שחזרו 
            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                tmp = new Product()
                {
                    Pid = (int)Dt.Rows[i]["Pid"],
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Price = int.Parse(Dt.Rows[i]["Price"] + ""),
                    PDesc = Dt.Rows[i]["PDesc"] + "",
                    PicName = Dt.Rows[i]["PicName"] + ""
                };
                LstProd.Add(tmp);
            }
            DB.Close();
            return LstProd;
        }
        public static Product GetById(int Id)//הפונקציה מחזירה את כל רשימת המוצרים המערכת מתוך בסיס הנתונים
        {
            
            Product tmp = null;
            
            string Sql = $"select * from t_products Where Pid={Id}";//הגדרת מחרוזת עם משפט שאילתה
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
                                     //נבצע לולאה שעוברת רשומה רשומה על התוצאות שחזרו 
            if (Dt.Rows.Count > 0)
            {
                tmp = new Product()
                {
                    Pid = (int)Dt.Rows[0]["Pid"],
                    Pname = Dt.Rows[0]["Pname"] + "",
                    Price = int.Parse(Dt.Rows[0]["Price"] + ""),
                    PDesc = Dt.Rows[0]["PDesc"] + "",
                    PicName = Dt.Rows[0]["PicName"] + ""
                };
            }
            DB.Close();
   
            return tmp;
        }
        public static int DeleteById(int Id)
        {
            int RetVal = 0;
            string Sql = $"delete * from t_products Where Pid={Id}";//הגדרת מחרוזת עם משפט שאילתה
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
             //הפונקציה משמשת לשאילתות שלא שולפות נתונים, כגון מחיקה עדכון והוספה
            Db.Close();
            return RetVal;
        }
    }
}