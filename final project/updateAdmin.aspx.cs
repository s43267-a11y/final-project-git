using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateAdmin : System.Web.UI.Page
{

    protected DataRow row;
    protected string s3;
    protected string s1;
    protected string s0;
    protected string date;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["mgr"] == null || (bool)Session["mgr"] == false)
        {
            Response.Redirect("admin.aspx?err=אין הרשאה לביצוע עדכון");
            return;
        }

        Session["id2"] = int.Parse(Request.QueryString["id"]);

        DataTable dt = DAL.GetTable("select * from tavla1 where id=" + Session["id2"]);
        row = dt.Rows[0];

        DateTime d = Convert.ToDateTime(row["birthDate"]);
        date = d.ToString("yyyy-MM-dd");

        string genderValue = row["gender"].ToString().ToLower();

        if (genderValue == "female")
        {
            s1 = "checked";
        }
        else
        {
            s0 = "checked";
        }

        if ((bool)row["admin"])
            s3= "checked";
    }
}