using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class software : System.Web.UI.Page
{
    private void LoadGrid(string q_parameter)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string query = q_parameter;//"select * from products order by id";
        DataTable table = oc.searchDB(query);
        this.GridView1.DataSource = table;
        this.GridView1.DataBind();
        GridView1.Visible = true;
        oc.close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/decorated_home.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
       // Response.Redirect("~/software_cds.aspx");
        string query = "select * from cd_collection where category_id=4 ";
        this.LoadGrid(query);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/buy.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
         
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        Label1.Visible = false;
        Label4.Visible = false;
        string drop_down_choice = DropDownList1.SelectedItem.Text;
        if (drop_down_choice.Equals("name"))
        {
            if (TextBox1.Text.Equals(""))
            {
                Label4.Visible = true;
                Label4.Text = "*fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=4 and cd_name like '%" + TextBox1.Text + "%'";
            this.LoadGrid(query);

        }
        if (drop_down_choice.Equals("name and year"))
        {
            string field2 = TextBox2.Text;
            if (field2.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "you have to fill in both the fields to search by name and year";
                return;

            }
            int year_int = int.Parse(TextBox2.Text);
           // string query = "SELECT * FROM cd_collection WHERE category_id=4 and  EXTRACT( YEAR FROM release_date) =" + year_int;
            string query = "SELECT * FROM cd_collection WHERE category_id=4 and  EXTRACT( YEAR FROM release_date) =" + year_int + "and cd_name like '%" + TextBox1.Text + "%'";
            this.LoadGrid(query);


        }
        if (drop_down_choice.Equals("company"))
        {
            if (TextBox1.Text.Equals(""))
            {
                Label4.Visible = true;
                Label4.Text = "*fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=4 and company like '" + TextBox1.Text + "%'";
            this.LoadGrid(query);


        }

    }
}