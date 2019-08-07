<%@ Page Language="C#" AutoEventWireup="true" CodeFile="audio_cds.aspx.cs" Inherits="audio_cds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 491px;
            width: 1018px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="audio cds"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CD_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CD_ID" HeaderText="CD_ID" ReadOnly="True" SortExpression="CD_ID" />
                <asp:BoundField DataField="IMPORT_DATE" HeaderText="IMPORT_DATE" SortExpression="IMPORT_DATE" />
                <asp:BoundField DataField="CD_NAME" HeaderText="CD_NAME" SortExpression="CD_NAME" />
                <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
                <asp:BoundField DataField="CATEGORY_ID" HeaderText="CATEGORY_ID" SortExpression="CATEGORY_ID" />
                <asp:BoundField DataField="GENRE_ID" HeaderText="GENRE_ID" SortExpression="GENRE_ID" />
                <asp:BoundField DataField="ARTIST_LASTNAME" HeaderText="ARTIST_LASTNAME" SortExpression="ARTIST_LASTNAME" />
                <asp:BoundField DataField="ARTIST_FIRSTNAME" HeaderText="ARTIST_FIRSTNAME" SortExpression="ARTIST_FIRSTNAME" />
                <asp:BoundField DataField="DIRECTOR_LASTNAME" HeaderText="DIRECTOR_LASTNAME" SortExpression="DIRECTOR_LASTNAME" />
                <asp:BoundField DataField="DIRECTOR_FIRSTNAME" HeaderText="DIRECTOR_FIRSTNAME" SortExpression="DIRECTOR_FIRSTNAME" />
                <asp:BoundField DataField="COMPANY" HeaderText="COMPANY" SortExpression="COMPANY" />
                <asp:BoundField DataField="RELEASE_DATE" HeaderText="RELEASE_DATE" SortExpression="RELEASE_DATE" />
                <asp:BoundField DataField="ORIGIN" HeaderText="ORIGIN" SortExpression="ORIGIN" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:audio_category %>" ProviderName="<%$ ConnectionStrings:audio_category.ProviderName %>" SelectCommand="select * from cd_collection where category_id=1"></asp:SqlDataSource>
    </form>
</body>
</html>
