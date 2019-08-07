<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        cd SHOP</h2>
    <p>
        Put content here.
        <asp:Button ID="test_button1" runat="server" onclick="Button1_Click" 
            Text="Test button edited" />
    </p>
</asp:Content>
