<%@ Page Language="C#" AutoEventWireup="true" CodeFile="movie.aspx.cs" Inherits="movie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Home | Bootstrap .net Templates</title>
    <%-- ------ CSS ------ --%>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/animate.min.css" rel="stylesheet" type="text/css" />
    <link href="css/prettyPhoto.css" rel="stylesheet" type="text/css" />
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <link href="css/responsive.css" rel="stylesheet" type="text/css" />
     <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"
        rel="stylesheet" type="text/css" />
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
    <link rel="shortcut icon" href="images/favicon.ico" />
</head>
<body>
    <form id="form1" runat="server">
        <header id="header">
    <div class="top-bar">
    <div class="container">
    <div class="row">
    <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      <div class="top-number"><p>&nbsp;</p></div>
    </div>
     <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      <div class="social">
     <ul class="social-share">
        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
        <li><a href="#"><i class="fa fa-linkedin"></i></a></li>        
        <li><a href="#"><i class="fa fa-skype"></i></a></li>
     </ul>     
       
    </div>
    </div>
    </div>
      </div><%--container--%>
        </div><%--/top-bar--%>
      <nav class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    &nbsp;</div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="decorated_home.aspx">Home</a></li>
                       <li><a href="audio.aspx">audio</a></li>
                        <li><a href="movie.aspx">movies</a></li>                        
                       <!-- <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Pages <i class="fa fa-angle-down"></i></a>
                            <ul class="dropdown-menu">
                                <li><a runat="server" href="~/contactus.aspx">Blog Single</a></li>
                                <li><a href="#">Pricing</a></li>
                                <li><a href="#">404</a></li>
                                <li><a href="#">Shortcodes</a></li>
                            </ul>
                        </li> -->
                        <li><a href="software.aspx">softwares</a></li> 
                        <li><a href="games.aspx">games</a></li> 
                        <li><a href="userlogin.aspx">log in</a></li> 
                         <li><a href="customersignup.aspx">signup</a></li> 
                        
                                               
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
    <div>
    
        Latest movie thumbnails:<br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="294px" 
            ImageUrl="~/8b9f098291fb9ba23beafa095efd0763b1c92964.jpg" Width="221px" />
        <asp:Image ID="Image5" runat="server" Height="291px" ImageUrl="~/images/p15227_d_v7_aa.jpg" style="z-index: 1; left: 952px; top: 204px; position: absolute" Width="231px" />
        <asp:Image ID="Image2" runat="server" Height="294px" ImageUrl="~/images/ShawshankRedemptionMoviePoster.jpg" style="z-index: 1; left: 241px; top: 204px; position: absolute" Width="221px" />
        <asp:Image ID="Image4" runat="server" Height="291px" ImageUrl="~/images/Forrest-Gump_poster_goldposter_com_38.jpg" style="z-index: 1; left: 709px; top: 208px; position: absolute" Width="231px" />
        <asp:Image ID="Image3" runat="server" Height="291px" ImageUrl="~/images/the-godfather.12977.jpg" style="z-index: 1; left: 473px; top: 205px; position: absolute" Width="221px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="112px">
            <asp:ListItem>Search by</asp:ListItem>
            <asp:ListItem>movie</asp:ListItem>
            <asp:ListItem>artist</asp:ListItem>
            <asp:ListItem>director</asp:ListItem>
            <asp:ListItem>year</asp:ListItem>
            <asp:ListItem>genre</asp:ListItem>
            <asp:ListItem>origin</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 45px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="go" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 32px" 
            Text="show all movies" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField HeaderText="choose" NavigateUrl="~/userlogin.aspx" 
                    Text="buy" DataNavigateUrlFields="cd_id" 
                    DataNavigateUrlFormatString="userlogin.aspx?cd_id={0}" />
            </Columns>
        </asp:GridView>
        &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            style="margin-left: 5px" Text="Back to Home" />
    
    </div>
    </form>
</body>
</html>
