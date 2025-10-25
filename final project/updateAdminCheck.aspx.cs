using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updatAdminCheck : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mgr"] == null || (bool)Session["mgr"] == false)
        {
            Response.Redirect("admin.aspx?err=אין הרשאה לביצוע עדכון");
            return;
        }


        int userID = (int)Session["id2"];


        string uname_2 = Request.Form["userName_3"];
        string pass_2 = Request.Form["passWord_3"];
        string email_2 = Request.Form["email_3"];
        string fname_2 = Request.Form["firstName_3"];
        string lname_2 = Request.Form["lastName_3"];
        string addres_2 = Request.Form["addres_3"];
        string date_2 = Request.Form["date_3"];
        int ctiy_2 = int.Parse(Request.Form["ctiy_selcet_2"]);
        int phonecode = int.Parse(Request.Form["phone_select_2"]);
        int phone = int.Parse(Request.Form["phoneNumber_2"]);
        int genderInt = int.Parse(Request.Form["Gender_2"]);
        string gender = (genderInt == 1) ? "Female" : "Male";
        string formattedDate = DateTime.Parse(date_2).ToString("MM/dd/yyyy");
        int mgr = 0;
        if (Request.Form["admin"]!=null) mgr = 1;






        string strSql = "UPDATE tavla1 SET " +
        "[userName] = '" + uname_2.Replace("'", "''") + "', " +
       "[passWord] = '" + pass_2.Replace("'", "''") + "', " +
       "[privateName] = '" + fname_2.Replace("'", "''") + "', " +
       "[lastName] = '" + lname_2.Replace("'", "''") + "', " +
       "[email] = '" + email_2.Replace("'", "''") + "', " +
       "[addres] = '" + addres_2.Replace("'", "''") + "', " +
       "[phoneNumber] = '" + phone + "', " +
       "[gender] = '" + gender + "', " +
       "[birthDate] = #" + formattedDate + "#, " +
        "[phoneCode] = '" + phonecode + "', " +
        "[city2] = '" + ctiy_2 + "', " +
        "[admin] = '"+ mgr +"'  "+
        "WHERE [id] = " + userID;


        int num = DAL.ExecuteNonQuery(strSql);
        if (num > 0)
        {
            Response.Redirect("admin.aspx");

        }
        else
        {
            Response.Redirect("updateAdmin.aspx?err= בעיה בעדכון ממסד הנתונים");

        }
        Session["name"] = fname_2;
    }
}
