﻿<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemonSlayer.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  <div>
      <asp:label id="lblError" runat="server" cssclass="error"></asp:label>
  </div>
  <div>
      <label for="txtUsername">Username: *</label>
      <asp:textbox id="txtUsername" runat="server"></asp:textbox>
  </div>
  <div>
      <label for="txtPassword">Password: *</label>
      <asp:textbox id="txtPassword" runat="server" textmode="Password"></asp:textbox>
  </div>

  <asp:button id="btnLogin" runat="server" text="Login" onclick="btnLogin_Click" />

</asp:Content>
