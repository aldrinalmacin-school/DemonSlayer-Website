<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUsers.aspx.cs" Inherits="DemonSlayer.Admin.EditUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="UserID" DataSourceID="DemonSlayerSQL">
    <Columns>
      <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" 
        ReadOnly="True" SortExpression="UserID" />
      <asp:BoundField DataField="Username" HeaderText="Username" 
        SortExpression="Username" />
      <asp:BoundField DataField="Password" HeaderText="Password" 
        SortExpression="Password" />
      <asp:BoundField DataField="SaltString" HeaderText="SaltString" 
        SortExpression="SaltString" />
      <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
    </Columns>
  </asp:GridView>
  <asp:SqlDataSource ID="DemonSlayerSQL" runat="server" 
    ConnectionString="<%$ ConnectionStrings:strConn %>" 
    SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
</asp:Content>
