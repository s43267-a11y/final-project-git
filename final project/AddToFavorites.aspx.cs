using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddToFavorites : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("loging.aspx");
            return;
        }

        string userId = Session["id"].ToString();
        string recipeId = Request.Form["recipeId"];

        if (!string.IsNullOrEmpty(recipeId))
        {
            string sql = $"INSERT INTO Favorites (userId, recipeId) VALUES ({userId}, {recipeId})";
            DAL.ExecuteNonQuery(sql); // Use your data access helper class here
        }

        Response.Redirect("user.aspx"); // Redirect to user favorites page
    }
}
