using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class userlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customersignup.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/decorated_home.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string user = TextBox1.Text;
        string pass = TextBox2.Text;



        //query retrieving from admin table
        string selectquery1 = "select * from np_admin where admin_username = " + "'" + user + "'" + " and admin_password = " + "'" + pass + "'";
        //query retrieving from user table
        string selectquery2 = "select * from np_user where user_name = " + "'" + user + "'" + " and user_password = " + "'" + pass + "'";

        //for admin validation
        SqlDataSource1.SelectCommand = selectquery1;
        SqlDataSource1.SelectCommandType = SqlDataSourceCommandType.Text;
        DataView dv1 = SqlDataSource1.Select(DataSourceSelectArguments.Empty) as DataView;

        //for user validation
        SqlDataSource2.SelectCommand = selectquery2;
        SqlDataSource2.SelectCommandType = SqlDataSourceCommandType.Text;
        DataView dv2 = SqlDataSource2.Select(DataSourceSelectArguments.Empty) as DataView;

        int result1 = dv1.Count;
        int result2 = dv2.Count;

        if (result1 == 0 && result2==0) //no user no admin as given
        {

            Label1.Text = "UserName or Password is wrong";

        }
        else if (result1 == 0 && result2 != 0) //only user is real
        {
            //Session["user"] = user;
            //Response.Redirect("~/mypage.aspx"); //just for checking, in real life it will go to payment page
            GridView1.Visible = true;
            Label1.Text = "Please Confirm your order from below table";
        }
        else if(result1!=0 && result2==0) {     //only admin is real
            //Label1.Text = "Please Confirm your order from below table";
            Response.Redirect("~/databasehandling.aspx");
        }
        //TextBox1.Text= null;
        TextBox2.Text = null;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customersignup.aspx");
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cd_id = GridView1.SelectedRow.Cells[0].Text;
        string cd_name = GridView1.SelectedRow.Cells[1].Text;
        string price = GridView1.SelectedRow.Cells[2].Text;
        string user_name = TextBox1.Text;
        string status = "pending";

        OracleConnect oc = new OracleConnect("localhost", "orcl", "hr", "hr");
        string insertQuery = string.Format("insert into cd_pay_order(order_id, p_o_cd_id,p_o_cd_name,p_o_cd_price,p_o_user_name,status) values(cd_pay_order_sequence.nextval,{0},'{1}',{2},'{3}','{4}')", cd_id, cd_name, price, user_name, status);
        oc.updateDB(insertQuery);
        TextBox1.Text = "";
        Label1.Text = "";
        Label3.Text = "Thank You, Your order has been received for validation";
        oc.close();
        GridView1.Visible = false;
    }
}