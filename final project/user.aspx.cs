using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
    {
            if (Session["id"] != null)
            {
                string userId = Session["id"].ToString();
                string sql = @"
               SELECT DISTINCT Table1.* FROM Table1 INNER JOIN Favorites ON Table1.ID = Favorites.recipeID WHERE Favorites.userID = " + userId;
                DataTable dt = DAL.GetTable(sql);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else
            {
                Response.Redirect("loging.aspx");
            }
        }
    }
}

