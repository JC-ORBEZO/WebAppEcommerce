<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ecommerce.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
    <div class="formAcceso">
        <asp:Label Text="Usuario" runat="server" /><br />
        <asp:TextBox ID="Usuario" runat="server" /><br />
        <asp:Label Text="Password" runat="server" /><br />
        <asp:TextBox ID="Password" runat="server" /><br />
        <asp:Button ID="Enviar" Text="Enviar" OnClick="Enviar_Click" runat="server" />
    </div>    
    <span id="Mensaje" runat="server"></span>
</asp:Content>
