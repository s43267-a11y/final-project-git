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

        // Home
        menu += "<button class='btn' title='בית' onclick=\"location.href='Default.aspx'\"><i class='fa-solid fa-house'></i></button>";

        if (Session["id"] == null)
        {
            menu += "<button class='btn' title='כניסה' onclick=\"location.href='Loging.aspx'\"><i class='fa-solid fa-right-to-bracket'></i></button>";
            menu += "<button class='btn' title='הרשמה' onclick=\"location.href='Registration.aspx'\"><i class='fa-solid fa-user-plus'></i></button>";
        }
        else
        {
            menu += "<button class='btn' title='דף המשתמש' onclick=\"location.href='Home.aspx'\"><i class='fa-solid fa-user'></i></button>";
            menu += "<button class='btn' title='עדכון' onclick=\"location.href='update.aspx'\"><i class='fa-solid fa-pen-to-square'></i></button>";
            menu += "<button class='btn' title='התנתק' onclick=\"location.href='logout.aspx'\"><i class='fa-solid fa-right-from-bracket'></i></button>";
        }

        if (Session["mgr"] != null && (bool)Session["mgr"])
        {
            menu += "<button class='btn' title='ניהול אדמין' onclick=\"location.href='admin.aspx'\"><i class='fa-solid fa-user-tie'></i></button>";
        }

        menu += "</div>";
        menuLiteral.Text = menu;


    }

}
