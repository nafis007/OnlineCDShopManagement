<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminpanel.aspx.cs" Inherits="adminpanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: right;
            width: 545px;
        }
        .style3
        {
            text-align: right;
            width: 545px;
            height: 29px;
        }
        .style4
        {
            height: 29px;
            text-align: left;
        }
        .style5
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 89px; background-color: #006699;">
    
        <table class="style1">
            <tr>
                <td class="style3" style="color: #FFFFFF">
&nbsp; User Name:</td>
                <td class="style4">
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 2px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" style="color: #FFFFFF">
                    Password:</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="margin-left: 539px" Text="Log In" />
    
    </div>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Back to Home" />
    </form>
</body>
</html>
