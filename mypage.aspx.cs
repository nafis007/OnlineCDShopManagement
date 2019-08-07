using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mypage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void admin_panel_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminpanel.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/userlogin.aspx");
    }
    protected void browse_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/browse.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/games.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/movie.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/software.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/adminpanel.aspx");
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/userlogin.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/audio.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/adminpanel.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/userlogin.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/audio.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/movie.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/games.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/software.aspx");
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/customersignup.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customersignup.aspx");
    }
}