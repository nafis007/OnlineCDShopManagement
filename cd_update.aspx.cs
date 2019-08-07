using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class cd_update : System.Web.UI.Page
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
        ////////////////////////////////delete button/////////////////////////////////////////////////

        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string delete_cdId_check = string.Format("select * from cd_collection where cd_id = {0}", TextBox1.Text);
        DataTable cd_delete_table = oc.searchDB(delete_cdId_check);

        if (String.IsNullOrWhiteSpace(TextBox1.Text))
        {
            Label1.Text = "Please enter all informations";
        }
        else if (cd_delete_table.Rows.Count == 0)
        {
            Label1.Text = "No Cd with this Id, Please enter correct Id";
        }
        else
        {
            string deleteQuery = string.Format("delete from cd_collection where cd_id={0}",TextBox1.Text);
            oc.updateDB(deleteQuery);
            TextBox1.Text = "";
            //TextBox2.Text = "";
            Label1.Text = "";
            oc.close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //////////////////////update Button//////////////////////////
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string update_cdId_check = string.Format("select * from cd_collection where cd_id = {0}", TextBox2.Text);
        DataTable cd_update_table = oc.searchDB(update_cdId_check);

        if (String.IsNullOrWhiteSpace(TextBox2.Text) || String.IsNullOrWhiteSpace(TextBox3.Text) || DropDownList1.SelectedItem.Text.Equals("Select From"))
        {
            Label2.Text = "Please enter all informations";
        }
        else if (cd_update_table.Rows.Count == 0)
        {
            Label2.Text = "No Cd with this Id, Please enter correct Id";
        }
        else
        {
            string drop_down = DropDownList1.SelectedItem.Text;
            if (drop_down.Equals("price") || drop_down.Equals("category_id") || drop_down.Equals("genre_id"))
            {
                string update_cat_id_check = string.Format("select * from cd_category where category_id = {0}", TextBox3.Text);
                string update_gen_id_check = string.Format("select * from cd_genre where genre_id = {0}", TextBox3.Text);
                DataTable cd_update_check_cat_table = oc.searchDB(update_cat_id_check);
                DataTable cd_update_check_gen_table = oc.searchDB(update_gen_id_check);

                if (drop_down.Equals("category_id") && cd_update_check_cat_table.Rows.Count == 0)
                {
                    Label2.Text = "No such categroy id available, Please enter correct Id";
                }
                else if (drop_down.Equals("genre_id") && cd_update_check_gen_table.Rows.Count == 0)
                {
                    Label2.Text = "No such genre id available, Please enter correct Id";
                }
                else {
                    string updateQuery1 = string.Format("update cd_collection set {0} = {1} where cd_id= {2}", drop_down, TextBox3.Text, TextBox2.Text);
                    oc.updateDB(updateQuery1);
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    Label2.Text = "";
                    oc.close();
                }
            }
            else {
                string updateQuery2 = string.Format("update cd_collection set {0} = '{1}' where cd_id= {2}", drop_down, TextBox3.Text, TextBox2.Text);
                oc.updateDB(updateQuery2);
                TextBox2.Text = "";
                TextBox3.Text = "";
                Label2.Text = "";
                oc.close();
            }
        }
    }
}