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

    public static string GetUserTable()
    {
        DataTable dt = DAL.GetTable("select * from tavla1");
        string str = "<table border='1'>";

        // שורת כותרות
        str += "<thead><tr>";
        str += "<th>userName</th>";
        str += "<th>passWord</th>";
        str += "<th>privateName</th>";
        str += "<th>lastName</th>";
        str += "<th>email</th>";
        str += "<th>addres</th>";
        str += "<th>phoneNumber</th>";
        str += "<th>gender</th>";
        str += "<th>birthDate</th>";
        str += "<th>phoneCode</th>";
        str += "<th>city2</th>";
        str += "</tr></thead>";

        // שורות הנתונים
        str += "<tbody>";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<tr>";
            str += "<td>" + dt.Rows[i]["userName"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["passWord"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["privateName"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["lastName"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["email"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["addres"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["phoneNumber"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["gender"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["birthDate"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["phoneCode"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["city2"].ToString() + "</td>";
            str += "</tr>";
        }
        str += "</tbody>";

        str += "</table>";

        return str;
    }


}
