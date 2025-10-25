
using System.Collections.Generic;
using System.Data.OleDb;
using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;    
using System.Web.UI.WebControls;

public partial class logingcheck : System.Web.UI.Page

{

  
    protected void Page_Load(object sender, EventArgs e)

         
    {
            // no input  --> go back to loging
            if (Request.Form.Count < 0)
                Response.Redirect("loging.aspx");

            //convert the fileds from loging so we can use them

              string name = Request.Form["usernameTxt"];
              string password = Request.Form["passwordTxt"];

            //   check if into exist ---> trun ito an sql string
            string strSql = "SELECT id ,privateName,admin FROM tavla1 WHERE (userName ='" + name + "') AND (passWord = '" + password + "')";
     

                OleDbConnection con = DAL.GetConnection();
                con.Open();
                OleDbCommand cmd = DAL.GetCommand(con, strSql);
                OleDbDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Session["name"] = rdr.GetString(1);
                    Session["id"] = (int)rdr.GetValue(0);
                    Session["mgr"] = (bool)rdr.GetBoolean(2);
            

                    Response.Redirect("user.aspx");

                }
                else
                {
                    Response.Redirect("Loging.aspx?err =משתמש לא קיים");
                }
        
    }
}

    
    