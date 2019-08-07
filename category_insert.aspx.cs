using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class category_insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrWhiteSpace(TextBox1.Text))
        {
            Label1.Text = "Please enter all informations";
        }
        else
        {
            OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
            string insertQuery = string.Format("insert into cd_category(category_id, category_name) values(cd_category_sequence.nextval, '{0}')", TextBox1.Text);
            oc.updateDB(insertQuery);
            TextBox1.Text = "";
            Label1.Text = "";
            oc.close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/databasehandling.aspx");
    }
}