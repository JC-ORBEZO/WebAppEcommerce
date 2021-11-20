<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Ecommerce.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Registro</h1>
    <div class="formRegistro">
        <asp:TextBox ID="Dni" runat="server" placeholder="DNI"/><br />
        <asp:TextBox ID="Nombre" runat="server" placeholder="Nombre"/><br />
        <asp:TextBox ID="Apellido" runat="server" placeholder="Apellido"/><br />
        <asp:TextBox ID="Telefono" runat="server" placeholder="Telefono"/><br />
        <asp:TextBox ID="Correo" runat="server" placeholder="Correo"/><br />
        <asp:TextBox ID="Direccion" runat="server" placeholder="Direccion"/><br />
        <asp:TextBox ID="Password1" runat="server" placeholder="Password1"/><br />
        <asp:TextBox ID="Password2" runat="server"  placeholder="Password2" /><br />
        <asp:Button ID="Registrar" Text="Registrar" OnClick="Registrar_Click" runat="server" />
    </div>
    <span id="Mensaje" runat="server"></span>
    </asp:Content>
