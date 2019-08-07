using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class user_payment : System.Web.UI.Page
{
    private void LoadGrid(string q_parameter)
    {
        // GridView1.Visible = false;
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string query = q_parameter;//"select * from products order by id";
        DataTable table = oc.searchDB(query);
        this.GridView1.DataSource = table;
        this.GridView1.DataBind();
        GridView1.Visible = true;
        oc.close();
    }
    private void LoadGrid2(string q_parameter)
    {
        // GridView1.Visible = false;
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string query = q_parameter;//"select * from products order by id";
        DataTable table = oc.searchDB(query);
        this.GridView2.DataSource = table;
        this.GridView2.DataBind();
        GridView2.Visible = true;
        oc.close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string showQuery = "select * from cd_pay_order";
        this.LoadGrid2(showQuery);
        oc.close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string searchQuery = string.Format("select user_id from np_user where user_name='{0}'", TextBox3.Text);
        //for check purpose
        //this.LoadGrid(searchQuery);
        DataTable user_id_table= oc.searchDB(searchQuery);
        if (user_id_table.Rows.Count == 0)
        {
            Label1.Text = "enter user name correctly";
            TextBox3.Text = "";
        }
        else {
            this.LoadGrid(searchQuery);
        }



        //TextBox1.Text = "";
        //Label1.Text = "";
        oc.close();
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox4.Text = GridView1.SelectedRow.Cells[1].Text;
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox2.Text = GridView2.SelectedRow.Cells[2].Text;
        TextBox3.Text = GridView2.SelectedRow.Cells[5].Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrWhiteSpace(TextBox1.Text) || String.IsNullOrWhiteSpace(TextBox2.Text) || String.IsNullOrWhiteSpace(TextBox3.Text) || String.IsNullOrWhiteSpace(TextBox4.Text))
        {
            Label1.Text = "Please enter all informations";
        }
        else
        {
            OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
            string insertQuery = string.Format("insert into cd_sales_log(sales_id, purchase_date,cd_id2,user_name,user_id) values(cd_sales_log_sequence.nextval, '{0}',{1},'{2}',{3})", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            oc.updateDB(insertQuery);
            

            //for pay order table status update
            //OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
            
            string p_o_cd_id = TextBox2.Text;
            string updated_status = "approved";
            string status = "status";

            string updateQuery = string.Format("update cd_pay_order set {0} = '{1}' where p_o_cd_id= {2}", status, updated_status, p_o_cd_id);
            oc.updateDB(updateQuery);
            //oc.close();
            GridView1.Visible = false;
            //GridView2.Visible = false;
            //GridView2.DataBind();
            //GridView2.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

            Label1.Text = "";
            oc.close();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/databasehandling.aspx");
    }
}