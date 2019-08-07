using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

public partial class customersignup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {



        Label1.Visible = false;
        //taking necessary inputs of the customer from a text box.
        string ln=TextBox1.Text; 
        string fn=TextBox2.Text;
        string loc=DropDownList1.Text;
        string cell=TextBox4.Text;
        string email = TextBox5.Text;
        string username = TextBox6.Text;
        string pass = TextBox7.Text;

        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");

        string usernamecheck = string.Format("select * from np_user where user_name = '{0}'", TextBox6.Text);
        DataTable user_table = oc.searchDB(usernamecheck);

        //checking whether the fields are empty of not
        if ((String.IsNullOrWhiteSpace(TextBox1.Text) || String.IsNullOrWhiteSpace(TextBox2.Text) || String.IsNullOrWhiteSpace(DropDownList1.Text) ||
         String.IsNullOrWhiteSpace(TextBox6.Text) || String.IsNullOrWhiteSpace(TextBox7.Text) ))
        {
            Label1.Visible = true;
            Label1.Text = "Some of the mandatory fields (ie last name or first name, or location or username & passwords are still unfilled\nfill them properly )";

        }
        else if (user_table.Rows.Count != 0)
        {
            Label1.Visible = true;
            Label1.Text = "User with this name already exists, give another user name";
        }
        else//if not, this would redirect to sign in page
        {//if everything is okay, insert the customer entry to the np_user schema 
            //insert into np_user(user_id, last_name , first_name, location, cell, email, user_name, user_password) values(1,'kazi','mishkat', 'dhanmandi', '123','m@','misha','misha');
            //(np_user_sequence2.nextval,'kazi','mishkat', 'dhanmandi', '123','m@','misha','misha');
            string q1 = "insert into np_user(user_id, last_name , first_name, location, cell, email, user_name, user_password) values(np_user_sequence2.nextval," + "'" + ln + "'," +"'" + fn+"',"+"'"+loc+"',"+"'"+cell+"',"+"'"+email+"',"+"'"+username+"',"+"'"+pass+"')" ;
            

            //connecting to oracle
            SqlDataSource1.SelectCommand = q1;
            SqlDataSource1.SelectCommandType = SqlDataSourceCommandType.Text;
            DataView dv1 = SqlDataSource1.Select(DataSourceSelectArguments.Empty) as DataView;

            //OleDbCommand comd = new OleDbCommand(q1, SqlDataSource1);

            Response.Redirect("~/decorated_home.aspx");

        }




      
        

      


       
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}