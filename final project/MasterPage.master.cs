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
        

        
        string menu = "<div class='nav-links'>";


        // Home
        menu += "<button class='btn' title='בית' onclick=\"location.href='home.aspx'\"><i class='fa-solid fa-house'></i><span>בית</span></button>";

        if (Session["id"] == null)
        {
            menu += "<button class='btn' title='כניסה' onclick=\"location.href='Loging.aspx'\"><i class='fa-solid fa-right-to-bracket'></i><span>כניסה</span></button>";
            menu += "<button class='btn' title='הרשמה' onclick=\"location.href='Registration.aspx'\"><i class='fa-solid fa-user-plus'></i><span>הרשמה</span></button>";
        }
        else
        {
            menu += "<button class='btn' title='דף המשתמש' onclick=\"location.href='user.aspx'\"><i class='fa-solid fa-user'></i><span>משתמש</span></button>";
            menu += "<button class='btn updateLink' title='עדכון' onclick=\"location.href='update.aspx'\"><i class='fa-solid fa-pen-to-square'></i><span>עדכון</span></button>";
            menu += "<button class='btn logoutLink' title='התנתק' onclick=\"location.href='logout.aspx'\"><i class='fa-solid fa-right-from-bracket'></i><span>התנתק</span></button>";
        }

        if (Session["mgr"] != null && (bool)Session["mgr"])
        {
            menu += "<button class='btn' title='ניהול אדמין' onclick=\"location.href='admin.aspx'\"><i class='fa-solid fa-user-tie'></i><span>אדמין</span></button>";
        }

        menu += "</div>";
        menuLiteral.Text = menu;



    }

}
