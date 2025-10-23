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

        string menu = "<div class='menu-container'>";
        
        menu += "<a href='Default.aspx'><input class='btn' type='button' value=' דף הבית ' /></a><br />";

        if (Session["id"] == null)
        {
            menu += "<a href='Loging.aspx'><input class='btn' type='button' value=' כניסה ' /></a><br />";
            menu += "<a href='Registration.aspx'><input class='btn' type='button' value=' הרשמה ' /></a><br />";
        }
        else
        {
            menu += "<a href='Home.aspx'><input class='btn' type='button' value=' דף המשתמש ' /></a><br />";
            menu += "<a href='update.aspx'><input class='btn' type='button' value=' עדכון ' /></a><br />";
        }
        if (Session["mgr"] != null && (bool)Session["mgr"] == true)
        {
            menu += "<a herf ='admin.aspx'><input class='btn' type='button' value='דף אדמין/></a><br/>";
        }


        menu += "</div>"; // close the wrapper

        menuLiteral.Text = menu;

    }

}
