<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mypage.aspx.cs" Inherits="mypage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 632px;
            width: 1326px;
        }
    </style>
</head>
<body style="height: 655px">
    <form id="form1" runat="server">
    <p style="background-color: #008080; font-family: Arial, Helvetica, sans-serif; font-size: xx-large; color: #FFFFFF; font-style: normal; height: 38px; width: 1326px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Welcome to CD SHOP&nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" BackColor="#336699" Height="27px" Width="1326px">
    </asp:Panel>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="140px" ImageUrl="~/images/44291.jpg" OnClick="ImageButton1_Click" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="140px" ImageUrl="~/images/movie-magic-logo-jpg_w800_h600_fit.jpg" OnClick="ImageButton2_Click" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" Height="140px" ImageUrl="~/images/joystick--ios-7-symbol_318-35524.png" OnClick="ImageButton3_Click" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton4" runat="server" Height="140px" ImageUrl="~/images/folder-2.png" OnClick="ImageButton4_Click" Width="160px" />
        <asp:ImageButton ID="ImageButton6" runat="server" 
        ImageUrl="~/images/register.png" OnClick="ImageButton6_Click" 
        style="z-index: 1; left: 346px; top: 365px; position: absolute; height: 140px; width: 160px" />
        <asp:ImageButton ID="ImageButton7" runat="server" Height="140px" ImageUrl="~/images/sign-black-icon-pen-pencil-symbol-hand.png" OnClick="ImageButton7_Click" style="z-index: 1; left: 972px; top: 363px; position: absolute" Width="160px" />
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Names="Century Gothic" 
        Font-Size="20pt" OnClick="LinkButton2_Click" 
        style="z-index: 1; left: 381px; top: 536px; position: absolute">sign in</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnClick="LinkButton3_Click" style="z-index: 1; left: 921px; top: 539px; position: absolute">create an account</asp:LinkButton>
        <asp:LinkButton ID="LinkButton4" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnClick="LinkButton4_Click" style="z-index: 1; left: 430px; top: 274px; position: absolute; right: 751px">movies</asp:LinkButton>
        <asp:LinkButton ID="LinkButton5" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnClick="LinkButton5_Click" style="z-index: 1; left: 50px; top: 275px; position: absolute">music</asp:LinkButton>
        <asp:LinkButton ID="LinkButton6" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnClick="LinkButton6_Click" style="z-index: 1; left: 814px; top: 268px; position: absolute">games</asp:LinkButton>
        <asp:LinkButton ID="LinkButton7" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnClick="LinkButton7_Click" style="z-index: 1; left: 1174px; top: 268px; position: absolute">softwares</asp:LinkButton>
    </form>
</body>
</html>
