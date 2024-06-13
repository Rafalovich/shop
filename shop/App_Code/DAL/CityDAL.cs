using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CityDAL
    {
        public static void Save(City tmp)
        {
            string Sql = "";
            if (tmp.CityId == -1)
            {
                Sql += $"insert into t_City(cityName ) ";
                Sql += $" values(N'{tmp.CityName}') ";
            }
            else
            {
                Sql = "update t_City set ";
                Sql += $" cityName = N'{tmp.CityName}' ";
                Sql += $" where CityId ={tmp.CityId}";


            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);
            if (tmp.CityId == -1)
            {
                Sql = $"select max(CityId) from t_City Where CityName = N'{tmp.CityName}' ";
                tmp.CityId = (int)Db.ExecuteScalar(Sql);
            }
            Db.Close();
        }
        public static List<City> GetAll()
        {
            List<City> LstCity = new List<City>();
            string Sql = "select * from t_City ";//הגדרת מחרוזת עם משפט שאילתה
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                LstCity.Add(new City()
                {
                    CityId = (int)Dt.Rows[i]["CityId"],
                    CityName = Dt.Rows[i]["CityName"] + ""
                });
            }
            DB.Close();
            return LstCity;
        }
        public static City GetById(int Id)
        {
            City tmp = null;
            string Sql = $"select * from t_City Where cityid={Id}";
            DbContext DB = new DbContext();
            DataTable Dt = DB.Execute(Sql);
            if (Dt.Rows.Count > 0)
            {
                tmp = new City()
                {
                    CityId = (int)Dt.Rows[0]["CityId"],
                    CityName = Dt.Rows[0]["CityName"] + ""
                };
            }
            DB.Close();
            return tmp;
        }
        public static int DeleteById(int id)
        {
            int RetVal = 0;
            string Sql = $"delete * from t_city Where cityid={id}";//הגדרת מחרוזת עם משפט שאילתה
            DbContext Db = new DbContext();
            RetVal = Db.ExecuteNonQuery(Sql);
            //הפונקציה משמשת לשאילתות שלא שולפות נתונים, כגון מחיקה עדכון והוספה
            Db.Close();
            return RetVal;
        }
    }
}