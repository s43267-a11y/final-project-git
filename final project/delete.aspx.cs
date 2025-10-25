using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // optional: only allow admin to delete
        if (Session["mgr"] == null || (bool)Session["mgr"] == false)
        {
            Response.Redirect("admin.aspx?err=אין הרשאה לביצוע מחיקה");
            return;
        }

        // get id from querystring
        if (Request.QueryString["id"] != null)
        {
            int id = int.Parse(Request.QueryString["id"]);

            // delete query
            string strSql = "DELETE FROM tavla1 WHERE id = " + id;

            int num = DAL.ExecuteNonQuery(strSql);

            // check result
            if (num == 0)
            {
                Response.Redirect("admin.aspx?err=המחיקה נכשלה או המשתמש לא נמצא");
            }
            else
            {
                Response.Redirect("admin.aspx?msg=המשתמש נמחק בהצלחה");
            }
        }
        else
        {
            Response.Redirect("admin.aspx?err=לא נבחר משתמש למחיקה");
        }
    }
}