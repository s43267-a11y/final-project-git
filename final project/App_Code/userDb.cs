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
        DataTable citydt = DAL.GetTable("select * from arim1");
        DataTable kidometdt = DAL.GetTable("select * from kidometTelphone");

        string str = "<table border='1'>";

        // table headers
        str += "<thead><tr>";
        str += "<th>id</th>";
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
        str += "<th>מחק</th>"; // delete column
        str += "<th>עדכון</th>";
        str += "</tr></thead>";

        str += "<tbody>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<tr>";

            str += "<td>" + dt.Rows[i]["id"] + "</td>";
            str += "<td>" + dt.Rows[i]["userName"] + "</td>";
            str += "<td>" + dt.Rows[i]["passWord"] + "</td>";
            str += "<td>" + dt.Rows[i]["privateName"] + "</td>";
            str += "<td>" + dt.Rows[i]["lastName"] + "</td>";
            str += "<td>" + dt.Rows[i]["email"] + "</td>";
            str += "<td>" + dt.Rows[i]["addres"] + "</td>";
            str += "<td>" + dt.Rows[i]["phoneNumber"] + "</td>";
            str += "<td>" + dt.Rows[i]["gender"] + "</td>";
            str += "<td>" + dt.Rows[i]["birthDate"] + "</td>";

            // 🔹 get phone prefix
            string kidometPhone = "";
            if (dt.Rows[i]["phoneCode"] != DBNull.Value)
            {
                DataRow[] rows_2 = kidometdt.Select("id = " + dt.Rows[i]["phoneCode"]);
                if (rows_2.Length > 0)
                    kidometPhone = rows_2[0]["phoneCode"].ToString();
            }
            str += "<td>" + kidometPhone + "</td>";

            // 🔹 get city name
            string cityName = "";
            if (dt.Rows[i]["city2"] != DBNull.Value)
            {
                DataRow[] rows = citydt.Select("id = " + dt.Rows[i]["city2"]);
                if (rows.Length > 0)
                    cityName = rows[0]["city"].ToString();
            }
            str += "<td>" + cityName + "</td>";

            // 🔹 delete & update links as icons
            str += "<td><a href='delete.aspx?id=" + dt.Rows[i]["id"] + "' " +
                   "onclick=\"return confirm('האם אתה בטוח שברצונך למחוק משתמש זה?');\" " +
                   "class='action-btn delete-btn' title='מחק'><i class='fa-solid fa-trash'></i></a></td>";

            str += "<td><a href='updateAdmin.aspx?id=" + dt.Rows[i]["id"] + "' " +
                   "onclick=\"return confirm('האם אתה בטוח שברצונך לעדכן משתמש זה?');\" " +
                   "class='action-btn update-btn' title='עדכן'><i class='fa-solid fa-pen-to-square'></i></a></td>";
            str += "</tr>";
        }

        str += "</tbody></table>";

        return str;

    }


}
