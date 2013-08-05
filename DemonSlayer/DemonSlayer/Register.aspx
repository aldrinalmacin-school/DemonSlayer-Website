﻿<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DemonSlayer.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div>
      <label for="txtUsername">Username: *</label>
      <asp:textbox id="txtUsername" runat="server"></asp:textbox>
  </div>
  <div>
      <label for="txtPassword">Password: *</label>
      <asp:textbox id="txtPassword" runat="server" textmode="Password"></asp:textbox>
  </div>
  <div>
      <label for="txtPassword2">Confirm Password: *</label>
      <asp:textbox id="txtPassword2" runat="server" textmode="Password"></asp:textbox>
  </div>
  <div>
      <label for="rblRole">Role: *</label>
      <asp:radiobuttonlist id="rblRole" runat="server" repeatdirection="Horizontal">
          <asp:listitem value="User" text="User" selected="true"></asp:listitem>
          <asp:listitem value="Admin" text="Admin"></asp:listitem>
      </asp:radiobuttonlist>
  </div>

  <asp:button id="btnRegister" runat="server" text="Register" 
          onclick="btnRegister_Click" />
</asp:Content>
