using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        string menu = "<div class='navbar'>";

        menu += "<button class='btn' onclick=\"location.href='Default.aspx'\">דף הבית</button>";

        if (Session["id"] == null)
        {
            menu += "<button class='btn' onclick=\"location.href='Loging.aspx'\">כניסה</button>";
            menu += "<button class='btn' onclick=\"location.href='Registration.aspx'\">הרשמה</button>";
        }
        else
        {
            menu += "<button class='btn' onclick=\"location.href='Home.aspx'\">דף המשתמש</button>";
            menu += "<button class='btn' onclick=\"location.href='update.aspx'\">עדכון</button>";
        }

        if (Session["mgr"] != null && (bool)Session["mgr"])
        {
            menu += "<button class='btn' onclick=\"location.href='admin.aspx'\">ניהול אדמין</button>";
        }

        menu += "</div>";
        menuLiteral.Text = menu;


    }

}
