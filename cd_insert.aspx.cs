using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class cd_insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*String importdate=TextBox1.Text;
        String cdname = TextBox2.Text;
        String price = TextBox3.Text;
        String categorid = TextBox4.Text;
        String genreid = TextBox5.Text;
        TextBox6.Text;
        TextBox7.Text;
        TextBox8.Text;
        TextBox9.Text;
        TextBox10.Text;
        TextBox11.Text;
        TextBox12.Text;*/

        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string categorycheck = string.Format("select * from cd_category where category_id={0}", TextBox4.Text);
        string genrecheck = string.Format("select * from cd_genre where genre_id={0}", TextBox5.Text);
        DataTable cat_table = oc.searchDB(categorycheck);
        DataTable gen_table = oc.searchDB(genrecheck);
        //checkings
        if (String.IsNullOrWhiteSpace(TextBox1.Text) || String.IsNullOrWhiteSpace(TextBox2.Text) || String.IsNullOrWhiteSpace(TextBox3.Text) || String.IsNullOrWhiteSpace(TextBox4.Text) || String.IsNullOrWhiteSpace(TextBox5.Text) ||
          String.IsNullOrWhiteSpace(TextBox10.Text) || String.IsNullOrWhiteSpace(TextBox11.Text) || String.IsNullOrWhiteSpace(TextBox12.Text))
        {
            Label2.Text = "Please enter all informations";
        }

        else if (cat_table.Rows.Count == 0) {
            Label2.Text = "No Such Category Id,Please enter Correctly";
        }
        else if (gen_table.Rows.Count == 0)
        {
            Label2.Text = "No Such Genre Id,Please enter Correctly";
        }
        //checkings done
        else
        {
            string insertQuery = string.Format("insert into cd_collection(cd_id, import_date , cd_name, price, category_id, genre_id, artist_lastname, artist_firstname, director_lastname, director_firstname,company, release_date, origin) values(cd_collection_sequence.nextval, '{0}', '{1}', {2}, {3}, {4}, '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
            TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text);
            //DataTable table = oc.searchDB(query);
            //this.GridView1.DataSource = table;
            //this.GridView1.DataBind();
            oc.updateDB(insertQuery);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            Label2.Text = "";
            oc.close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/databasehandling.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/category.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/genre.aspx");
    }
}