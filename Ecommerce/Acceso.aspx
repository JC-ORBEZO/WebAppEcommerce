<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="Ecommerce.Acceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formAcceso">
        <asp:Label Text="Email" runat="server" /><br />
        <asp:TextBox ID="Usuario" placeholder="ejemplo@email.com" runat="server" /><br />
        <asp:Label Text="Password" runat="server" /><br />
        <asp:TextBox ID="Password" runat="server" /><br />
        <asp:Button ID="Enviar" Text="Enviar" OnClick="Enviar_Click" runat="server" />
    </div>    
    <span id="Mensaje" runat="server"></span>
    <span id="Mensaje2" runat="server"></span>
    <a href="Registro.aspx">REGISTRARSE</a>
</asp:Content>
