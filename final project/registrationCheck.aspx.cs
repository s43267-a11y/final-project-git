using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration_check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // no input in username and the other filds --> go back to registration
        if (string.IsNullOrEmpty(Request.Form["userName_2"]))
        {
            Response.Redirect("registration.aspx");
            return;
        }

        // convert the fileds from registration so we can use them
        string uname = Request.Form["userName_2"];
        string pass =  Request.Form["passWord_2"];
        string email = Request.Form["email_2"];
        string fname = Request.Form["firstName_2"];
        string lname = Request.Form["lastName_2"];
        string addres = Request.Form["addres_2"];
        string date_1 = Request.Form["date_2"];
        int ctiy = int.Parse(Request.Form["ctiy_selcet"]);
        int phonecode = int.Parse(Request.Form["phone_select"]);
        int phone = int.Parse(Request.Form["phoneNumber"]);
        string formattedDate = DateTime.Parse(date_1).ToString("MM/dd/yyyy");
        int genderInt = int.Parse(Request.Form["Gender"]);
        string gender = (genderInt == 1) ? "Female" : "Male";


       
        // insert info into to sql string

        string strSql = "INSERT INTO tavla1 ([userName], [passWord], [privateName], [lastName], [email], [addres], [phoneNumber], [gender], [birthDate], [phoneCode], [city2]) " +
            "VALUES ('" + uname.Replace("'", "''") + "', '" + pass.Replace("'", "''") + "', '" + fname.Replace("'", "''") + "', '" +
            lname.Replace("'", "''") + "', '" + email.Replace("'", "''") + "', '" + addres.Replace("'", "''") + "', '" + phone + "', '" +
            gender + "', #" + formattedDate + "#, '" + phonecode + "', '" + ctiy + "')";


       

        if (userDb.getUserId(uname) > 0)
        {
            // Username already exists — go to login
            Response.Redirect("loging.aspx?err=שם המשתמש תפוס=כנס");
            return;
        }

        // Insert new user by using the sql we created
         int num = DAL.ExecuteNonQuery(strSql);

        if (num > 0)
        {
            Session["name"] = fname;
            Session["id"] = userDb.getUserId(uname);
            Response.Redirect("home.aspx");
        }
        else
        {
            Response.Redirect("registration.aspx?err=בעיה בהכנסה למסד הנתונים");
        }


    }
}