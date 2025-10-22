using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for kidometSelector
/// </summary>
/// 
public class kidometSelector
{
    public static string GetPhoneOption()
    {
        DataTable dt = DAL.GetTable("SELECT * FROM kidometTelphone");
        string str = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<option value ='" + dt.Rows[i]["id"] + "'> " + dt.Rows[i]["phoneCode"] + "</option>";
        }
        return str;
    }
}