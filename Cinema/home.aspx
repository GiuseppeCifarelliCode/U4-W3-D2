<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Cinema.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid d-flex flex-column align-items-center w-50">
        <label for="nome">Nome</label>
        <asp:TextBox ID="nome" runat="server" CssClass="mb-2"></asp:TextBox>
        <label for="cognome">Cognome</label>
        <asp:TextBox ID="cognome" runat="server" CssClass="mb-2"></asp:TextBox>
        <div>
            <asp:DropDownList ID="sale" runat="server" CssClass="my-2">
                <asp:ListItem Value="nord" Text="SALA NORD"></asp:ListItem>
                <asp:ListItem Value="est" Text="SALA EST"></asp:ListItem>
                <asp:ListItem Value="sud" Text="SALA SUD"></asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBox ID="ridotto" runat="server" Text="Ridotto" />
        </div>
        <asp:Button ID="ticketButton" runat="server" Text="Buy Ticket" CssClass="btn btn-primary" OnClick="buyTicket" /> 
        <asp:Label ID="message" runat="server"></asp:Label>
    </div>
     <div class="container d-flex flex-column align-items-center mt-2">
     <asp:Label ID="nordLabel" runat="server" Text="Sala Nord --- Biglietti Venduti: 0 --- Ridotti: 0"></asp:Label>
     <asp:Label ID="estLabel" runat="server" Text="Sala Est --- Biglietti Venduti: 0 --- Ridotti: 0"></asp:Label>
     <asp:Label ID="sudLabel" runat="server" Text="Sala Sud --- Biglietti Venduti: 0 --- Ridotti: 0"></asp:Label>

 </div>
</asp:Content>
