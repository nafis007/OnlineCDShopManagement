using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/databasehandling.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ///////////////delete button////////////////////
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string delete_adminId_check = string.Format("select * from np_admin where admin_id = {0}", TextBox1.Text);
        DataTable admin_delete_table = oc.searchDB(delete_adminId_check);

        if (String.IsNullOrWhiteSpace(TextBox1.Text))
        {
            Label1.Text = "Please enter all informations";
        }
        else if (admin_delete_table.Rows.Count == 0)
        {
            Label1.Text = "No Admin with this Id, Please enter correct Id";
        }
        else
        {
            string deleteQuery = string.Format("delete from np_admin where admin_id={0}", TextBox1.Text);
            oc.updateDB(deleteQuery);
            TextBox1.Text = "";
            //TextBox2.Text = "";
            Label1.Text = "";
            oc.close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ///////////////////update button//////////////////////////
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string update_adminId_check = string.Format("select * from np_admin where admin_id = {0}", TextBox2.Text);
        DataTable admin_update_table = oc.searchDB(update_adminId_check);

        if (String.IsNullOrWhiteSpace(TextBox2.Text) || String.IsNullOrWhiteSpace(TextBox3.Text) || DropDownList1.SelectedItem.Text.Equals("Select From"))
        {
            Label2.Text = "Please enter all informations";
        }
        else if (admin_update_table.Rows.Count == 0)
        {
            Label2.Text = "No Admin with this Id, Please enter correct Id";
        }
        else
        {
            string drop_down = DropDownList1.SelectedItem.Text;


            string updateQuery2 = string.Format("update np_admin set {0} = '{1}' where admin_id= {2}", drop_down, TextBox3.Text, TextBox2.Text);
            oc.updateDB(updateQuery2);
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label2.Text = "";
            oc.close();

        }
    }
}