using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class UsersDAL
    {
        public static void Save(Users Tmp)
        {
            int RetVal = 0;
            string ConnStr;
            string Sql = "";
            if (Tmp.UserId == -1)
            {
                Sql += $"insert into T_Users (FName, LName, CityId,Addres,Mail," +
                    $"Password,BirthDate,Phone,RegisDate )";
                Sql += $" values (N'{Tmp.FName}',N'{Tmp.LName}',{Tmp.CityId},N'{Tmp.Addres}',N'{Tmp.Mail}'" +
                    $"N'{Tmp.Password}',{Tmp.BirthDate},N'{Tmp.Phone}',{Tmp.RegisDate}";
            }
            else
            {
                Sql += "update T_Users set ";
                Sql += $" FName= N'{Tmp.FName}' ";
                Sql += $" LName= N'{Tmp.LName}' ";
                Sql += $" CityId ={Tmp.CityId} ";
                Sql += $" Addres= N'{Tmp.Addres}' ";
                Sql += $" Mail= N'{Tmp.Mail}' ";
                Sql += $" Password= N'{Tmp.Password}' ";
                Sql += $" BirthDate ={Tmp.BirthDate} ";
                Sql += $" Phone= N'{Tmp.Phone}' ";
                Sql += $" RegisDate ={Tmp.RegisDate} ";
                Sql += $" where UserId = {Tmp.UserId} ";
            }
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnStr;
            Conn.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = Sql;
            RetVal = Cmd.ExecuteNonQuery();
            if(Tmp.UserId ==-1)
            {
                Sql = $"select max(UserId) from T_Users where LName = N'{Tmp.LName}' ";
                Cmd.CommandText = Sql;
                Tmp.UserId = (int)Cmd.ExecuteScalar();
                Conn.Close();
            }
        }
        public static List<Users>GetAll()
        {
            List<Users>  LstUser = new List<Users>();
            string ConnStr;
            string Sql = "select * from T_Users ";
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection Conn = new SqlConnection();//
            Conn.ConnectionString = ConnStr;//הגדרת מחרוזת ההתחברות עבור אובייקט הצינור
            Conn.Open();//פתיחת הצ

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = Sql;
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                LstUser.Add(new Users()
                {
                    UserId = int.Parse(Dr["UserId"] + ""),
                    FName = Dr["FName"] + "",
                    LName = Dr["LName"] + "",
                    CityId = int.Parse(Dr["CityId"] + ""),
                    Addres = Dr["Addres"] + "",
                    Mail = Dr["Mail"] + "",
                    Password = Dr["Password"] + "",
                    BirthDate = (DateTime)Dr["BirthDate"]
                });
            }
            Dr.Close();
            Conn.Close();
            return LstUser;
        }
        public static Users GetById(int id)
        {
            Users tmp =null;
            string ConnStr;
            string Sql = $"select * from T_Users where UserId={id}";
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
                tmp = new Users()
                {
                    UserId = int.Parse(Dr["UserId"] + ""),
                    FName = Dr["FName"] + "",
                    LName = Dr["LName"] + "",
                    CityId = int.Parse(Dr["CityId"] + ""),
                    Addres = Dr["Addres"] + "",
                    Mail = Dr["Mail"] + "",
                    Password = Dr["Password"] + "",
                    BirthDate = (DateTime)Dr["BirthDate"]
                }; 
            }
            Dr.Close();
            Conn.Close();
            return tmp;
        }
    }
}