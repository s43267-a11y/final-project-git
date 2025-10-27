using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    public partial class recipes : System.Web.UI.Page
    {

        protected DataRow row_3;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            if (string.IsNullOrEmpty(id))
            {
                Response.Redirect("home.aspx");
                return;
            }



            DataTable dt = DAL.GetTable($"SELECT * FROM Table1 WHERE id = {id}");
            row_3= dt.Rows[0];


        }

    }