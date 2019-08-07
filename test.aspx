<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/animate.min.css" rel="stylesheet" type="text/css" />
    <link href="css/prettyPhoto.css" rel="stylesheet" type="text/css" />
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <link href="css/responsive.css" rel="stylesheet" type="text/css" />
     <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"
        rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 336px">
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:xyz %>" 
            ProviderName="<%$ ConnectionStrings:xyz.ProviderName %>" 
            SelectCommand="SELECT * FROM &quot;NP_ADMIN&quot;"></asp:SqlDataSource>
        <asp:TextBox ID="TextBox1" runat="server" 
            style="margin-left: 399px; margin-bottom: 53px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="margin-left: 47px" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            style="margin-left: 43px" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ADMIN_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ADMIN_ID" HeaderText="ADMIN_ID" ReadOnly="True" 
                    SortExpression="ADMIN_ID" />
                <asp:BoundField DataField="ADMIN_USERNAME" HeaderText="ADMIN_USERNAME" 
                    SortExpression="ADMIN_USERNAME" />
                <asp:BoundField DataField="ADMIN_PASSWORD" HeaderText="ADMIN_PASSWORD" 
                    SortExpression="ADMIN_PASSWORD" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
