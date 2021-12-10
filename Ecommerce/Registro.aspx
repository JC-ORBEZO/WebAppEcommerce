<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Ecommerce.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PÁGINA DE REGISTRO</h1>
    <div class="formRegistro">
        <asp:Label Text="Dni" runat="server" /><br />
        <asp:TextBox ID="Dni" runat="server" /><br />
        <asp:Label Text="Nombre" runat="server" /><br />
        <asp:TextBox ID="Nombre" runat="server" /><br />
        <asp:Label Text="Apellido" runat="server" /><br />
        <asp:TextBox ID="Apellido" runat="server" /><br />
        <asp:Label Text="Telefono" runat="server" /><br />
        <asp:TextBox ID="Telefono" runat="server" /><br />
        <asp:Label Text="Direccion" runat="server" /><br />
        <asp:TextBox ID="Direccion" runat="server" /><br />
        <asp:Label Text="Email" runat="server" /><br />
        <asp:TextBox ID="Email" runat="server" /><br />
        <asp:Label Text="Password" runat="server" /><br />
        <asp:TextBox ID="Password" runat="server" /><br />
        <asp:Button ID="Registrar" Text="Registrar" OnClick="Registrar_Click" runat="server" />
    </div>    
    <span id="Mensaje" runat="server"></span>
</asp:Content>
