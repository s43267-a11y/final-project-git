using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for userDb
/// </summary>
public class userDb
{
    public static int getUserId(string uname)
    {
        int id = -1;
        OleDbConnection con = DAL.GetConnection();
        con.Open();

        string sql = "SELECT id FROM tavla1 WHERE UserName='" + uname + "'";
        OleDbCommand cmd = DAL.GetCommand(con, sql);

        object obj = cmd.ExecuteScalar(); // Executes SQL and returns a single value
        con.Close();

        if (obj != null)
            id = (int)obj;

        return id;
    }
    public static string GetCityOptions_2(int city)
    {
        DataTable dt = DAL.GetTable("select * from arim1");
        string str = "";
        string s;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s = "";
            if ((int)dt.Rows[i]["id"] == city)
            {
                s = " selected ";
            }

            str += "<option value = '" + dt.Rows[i]["id"] + "' " + s + ">" + dt.Rows[i]["city"] + " </option >";
        }

        return str;
    }
    public static string GetPhoneOptions_2(int city)
    {
        DataTable dt = DAL.GetTable("select * from kidometTelphone");
        string str = "";
        string s;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s = "";
            if ((int)dt.Rows[i]["id"] == city)
            {
                s = " selected ";
            }

            str += "<option value = '" + dt.Rows[i]["id"] + "' " + s + ">" + dt.Rows[i]["phoneCode"] + " </option >";
        }

        return str;
    }
}