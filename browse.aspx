<%@ Page Language="C#" AutoEventWireup="true" CodeFile="browse.aspx.cs" Inherits="browse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 371px;
        }
        .style2
        {
            width: 236px;
        }
        .style5
        {
            width: 236px;
            height: 88px;
        }
        .style6
        {
            height: 88px;
        }
        .style7
        {
            width: 236px;
            height: 83px;
        }
        .style8
        {
            height: 83px;
        }
        .style9
        {
            width: 236px;
            height: 80px;
        }
        .style10
        {
            height: 80px;
        }
    </style>
</head>
<body style="height: 355px">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style9">
                    <asp:Button ID="Button1" runat="server" Height="59px" onclick="Button1_Click" 
                        Text="MOVIES" Width="230px" />
                </td>
                <td class="style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Button ID="Button2" runat="server" Height="66px" onclick="Button2_Click" 
                        Text="Audio" Width="226px" />
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Button ID="Button3" runat="server" Height="70px" onclick="Button3_Click" 
                        Text="Games" Width="229px" />
                </td>
                <td class="style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button4" runat="server" Height="71px" onclick="Button4_Click" 
                        Text="Software" Width="227px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
