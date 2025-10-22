using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class update : System.Web.UI.Page
{
    
    protected DataRow row;
    protected string s1;
    protected string s0;
    protected string date; 

    protected void Page_Load(object sender, EventArgs e)
    {
      

        if (Session["id"] == null)
            Response.Redirect("home.aspx");

        

        DataTable dt = DAL.GetTable("select * from tavla1 where id=" + Session["id"]);
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




    }




}
