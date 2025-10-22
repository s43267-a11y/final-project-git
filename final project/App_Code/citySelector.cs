using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for citySelector
/// </summary>
public class citySelector
{
   public static string GetCityOption()
    {
        DataTable dt = DAL.GetTable("SELECT * FROM arim1");
        string str = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<option value ='" + dt.Rows[i]["id"] + "' > " + dt.Rows[i]["city"] + "</option>";
        }
        return str;
    }
}