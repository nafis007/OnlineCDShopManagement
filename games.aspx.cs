using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class games : System.Web.UI.Page
{
    private void LoadGrid(string q_parameter)
    {
        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string query = q_parameter;//"select * from products order by id";
        DataTable table = oc.searchDB(query);
      /*  if (!table.IsInitialized)
        {
            Label1.Visible = true;
            Label1.Text = "nodata";

        }*/
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
        //Response.Redirect("~/game_cds.aspx");
        GridView1.Visible = false;
        string query = "select * from cd_collection where category_id=3 ";
        this.LoadGrid(query);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/buy.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        Label1.Visible = false;
        string drop_down_choice = DropDownList1.SelectedItem.Text;
        if (drop_down_choice.Equals("game"))
        {
            if (TextBox1.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=3 and cd_name like '" + TextBox1.Text + "%'";
            this.LoadGrid(query);
        }
        if (drop_down_choice.Equals("company"))
        {
            if (TextBox1.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "fill in the text field";
                return;
            }
            if (TextBox1.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=3 and company like '" + TextBox1.Text + "%'";
            this.LoadGrid(query);

        }
        if (drop_down_choice.Equals("genre"))
        {
            if (TextBox1.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "fill in the text field";
                return;
            }
            string query = "select c1.cd_name, c1.price, c2.genre_name from cd_collection c1 join cd_genre c2 on(c1.genre_id= c2.genre_id) where c1.category_id=3 and  c2.genre_name like '"+TextBox1.Text+"%'";

            this.LoadGrid(query);


        }

    }
}