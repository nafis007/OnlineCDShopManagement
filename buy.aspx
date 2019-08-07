<%@ Page Language="C#" AutoEventWireup="true" CodeFile="buy.aspx.cs" Inherits="buy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 450px; width: 1191px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="if you are  a user "></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">sign in </asp:LinkButton>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Not signed in yet?"></asp:Label>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">click here</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
