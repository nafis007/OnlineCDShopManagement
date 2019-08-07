using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/databasehandling.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string adminusernamecheck = string.Format("select * from np_admin where admin_username = upper('{0}')", TextBox1.Text);
        DataTable admin_table = oc.searchDB(adminusernamecheck);

        if (String.IsNullOrWhiteSpace(TextBox1.Text) || String.IsNullOrWhiteSpace(TextBox2.Text))
        {
            Label1.Text = "Please enter all informations";
        }
        else if (admin_table.Rows.Count != 0) {
            Label1.Text = "User with this name already exists, give another user name";
        }
        else
        {
            string insertQuery = string.Format("insert into np_admin(admin_id, admin_username,admin_password) values(np_admin_sequence.nextval, '{0}', '{1}')", TextBox1.Text.ToUpper(), TextBox2.Text);
            oc.updateDB(insertQuery);
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label1.Text = "";
            oc.close();
        }
    }
}