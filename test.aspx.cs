using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user = TextBox1.Text;
        string pass = TextBox2.Text;
        

        

            string selectquery = "select * from np_admin where admin_username = " + "'" + user + "'" + " and admin_password = " + "'" + pass + "'";

            SqlDataSource1.SelectCommand = selectquery;
            SqlDataSource1.SelectCommandType = SqlDataSourceCommandType.Text;
            DataView dv = SqlDataSource1.Select(DataSourceSelectArguments.Empty) as DataView;
            int result = dv.Count;
            if (result == 0)
            {
               
                Label1.Text = "UserName or Password is wrong";

            }
            else
            {
                //Session["user"] = user;
                Response.Redirect("~/databasehandling.aspx");
            }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.Visible = true;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}