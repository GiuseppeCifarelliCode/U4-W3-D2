<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Cinema.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid d-flex flex-column align-items-center">
        <label for="username">Username</label>
         <asp:TextBox ID="username" runat="server" CssClass="my-2"></asp:TextBox>
        <label for="psw">Password</label>
        <asp:TextBox ID="psw" runat="server" TextMode="Password" CssClass="my-2"></asp:TextBox>
        <asp:button ID="submit" runat="server" Text="Login" CssClass="btn btn-primary my-2" OnClick="submit_Click"/>
        <asp:Label ID="message" runat="server"></asp:Label>
    </div>
</asp:Content>
