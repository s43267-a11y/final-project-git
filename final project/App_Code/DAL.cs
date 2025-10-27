using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public class DAL
{

    public static OleDbConnection GetConnection()
    {
        OleDbConnection con = new OleDbConnection();
        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\user data\Documents\Database2.accdb;Persist Security Info=True";

        
        return con;
    }


    public static OleDbCommand GetCommand(OleDbConnection con, string sqlStr)
    {

        OleDbCommand cmd = new OleDbCommand();  

        cmd.Connection = con;   
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sqlStr;
        return cmd;
    }




     static public int ExecuteNonQuery(string strSql)
    {
        int rowsAffected;

        OleDbConnection con = GetConnection();
        con.Open();

        OleDbCommand cmd = GetCommand(con, strSql);

        rowsAffected = cmd.ExecuteNonQuery();
        con.Close();
        return rowsAffected;
    }


    static public Object ExecuteScalar(string strSql)
    {

        OleDbConnection con = GetConnection();
        con.Open();

        OleDbCommand cmd = GetCommand(con, strSql);

        Object obj = cmd.ExecuteScalar();
        con.Close();
        return obj;
    }

    static public DataTable GetTable(string strSql)
    {

        DataTable dt = new DataTable();

        OleDbConnection con = GetConnection();
        OleDbCommand cmd = GetCommand(con, strSql);

        System.Diagnostics.Debug.WriteLine(strSql);

        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSql, con);
        dataAdapter.Fill(dt);
        return dt;
    }
}
