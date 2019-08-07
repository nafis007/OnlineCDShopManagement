using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class databasehandling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/decorated_home.aspx");
    }
    protected void Button18_Click(object sender, EventArgs e)
    {

    }

    //showing our database tables on the following button clicks
    protected void Button25_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/cd.aspx");
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/genre.aspx");
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/category.aspx");
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer.aspx");
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/sales.aspx");
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin.aspx");
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/user.aspx");
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/history.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/cd_insert.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/genre_insert.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        //Response.Redirect("~/category_insert.aspx");
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin_insert.aspx");
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/cd_update.aspx");
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/genre_update.aspx");
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string deleteQuery = string.Format("delete from cd_history");
        oc.updateDB(deleteQuery);
        //TextBox1.Text = "";
        //TextBox2.Text = "";
        //Label1.Text = "";
        oc.close();
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin_delete.aspx");
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string deleteQuery = string.Format("delete from cd_sales_log");
        oc.updateDB(deleteQuery);
        //TextBox1.Text = "";
        //TextBox2.Text = "";
        //Label1.Text = "";
        oc.close();
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/user_payment.aspx");
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string deleteQuery = "delete from cd_pay_order";
        oc.updateDB(deleteQuery);
        //TextBox1.Text = "";
        //TextBox2.Text = "";
        //Label1.Text = "";
        oc.close();
    }
}