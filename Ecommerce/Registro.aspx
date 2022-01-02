<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Ecommerce.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
    <div class="col-6 mt-5">
    <h1 class="text-center">PÁGINA DE REGISTRO</h1>
    <div class="formRegistro">
        <asp:Label Text="Dni" runat="server" /><br />
        <asp:TextBox ID="Dni" runat="server" class="form-control"/>
        <asp:Label Text="Nombre" runat="server" /><br />
        <asp:TextBox ID="Nombre" runat="server" class="form-control"/>
        <asp:Label Text="Apellido" runat="server" /><br />
        <asp:TextBox ID="Apellido" runat="server" class="form-control"/>
        <asp:Label Text="Telefono" runat="server" /><br />
        <asp:TextBox ID="Telefono" runat="server" class="form-control"/>
        <asp:Label Text="Direccion" runat="server" /><br />
        <asp:TextBox ID="Direccion" runat="server" class="form-control"/>
        <asp:Label Text="Email" runat="server" /><br />
        <asp:TextBox ID="Email" runat="server" class="form-control"/>
        <asp:Label Text="Password" runat="server" /><br />
        <asp:TextBox ID="Password" runat="server" class="form-control"/>
        <asp:Button ID="Registrar" Text="Registrar" OnClick="Registrar_Click" runat="server" type="button" class="btn btn-success btn-block mt-2"/>
    </div>    
        </div>
        </div>
    <span id="Mensaje" runat="server"></span>
</asp:Content>
