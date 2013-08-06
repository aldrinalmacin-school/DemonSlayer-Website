<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="DemonSlayer._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to Demon Slayer Website!
    </h2>
    <p>
        <a target="_blank" href="https://github.com/aldrinalmacin/Project-1">Click here</a> to check out our game in progress Github.
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
          AutoGenerateColumns="False" DataSourceID="AllPosts">
          <Columns>
            <asp:BoundField DataField="Post" SortExpression="Post" />
          </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="AllPosts" runat="server" 
          ConnectionString="<%$ ConnectionStrings:strConn %>" 
          SelectCommand="SELECT [Post] FROM [Posts] ORDER BY [PostID] DESC">
        </asp:SqlDataSource>
    </p>
  </asp:Content>
