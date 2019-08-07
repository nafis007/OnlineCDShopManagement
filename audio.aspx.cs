/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class audio : System.Web.UI.Page
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
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/decorated_home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Redirect("~/audio_cds.aspx");
        GridView1.Visible = false;
        string query = "select * from cd_collection where category_id=1 ";
        this.LoadGrid(query);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/buy.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        GridView1.Visible = false;
        string drop_down_choice = DropDownList2.SelectedItem.Text;
        
      
        if (drop_down_choice.Equals("artist"))
        {
            if (TextBox2.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "*fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=1 and artist_firstname like '" + TextBox2.Text + "%'";
            this.LoadGrid(query);

        }
        if (drop_down_choice.Equals("album"))
        {
            if (TextBox2.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "*fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=1 and cd_name like '" + TextBox2.Text + "%'";
            this.LoadGrid(query);
        }

        if (drop_down_choice.Equals("origin"))
        {
            if (TextBox2.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "*fill in the text field";
                return;
            }
            string query = "select * from cd_collection where category_id=1 and origin like '" + TextBox2.Text + "%'";
            this.LoadGrid(query);
        }
        if (drop_down_choice.Equals("year"))
        {
            if (TextBox2.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "*fill in the text field";
                return;
            }
           // int a = 2007;
            int year_int = int.Parse(TextBox2.Text);
            string query = "SELECT * FROM cd_collection WHERE category_id=1 and  EXTRACT( YEAR FROM release_date) =" + year_int;
            this.LoadGrid(query);

        }
        if (drop_down_choice.Equals("genre"))
        {
            if (TextBox2.Text.Equals(""))
            {
                Label1.Visible = true;
                Label1.Text = "*fill in the text field";
                return;
            }
            string query ="select c1.cd_name,c1.artist_firstname, c1.price, c2.genre_name from cd_collection c1 join cd_genre c2 on(c1.genre_id= c2.genre_id) where c1.category_id=1 and  c2.genre_name like '"+TextBox2.Text+"%'";
            this.LoadGrid(query);
        }
        
        


        }


    }
