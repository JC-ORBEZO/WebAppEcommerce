<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="Ecommerce.Acceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
    <div class="col-6 mt-5">
    <div class="formAcceso form-group" >
        <asp:Label Text="Email" runat="server"/><br />
        <asp:TextBox ID="Usuario" placeholder="ejemplo@email.com" runat="server" class="form-control"/><br />
        <asp:Label Text="Password" runat="server" /><br />
        <asp:TextBox ID="Password" runat="server" class="form-control"/><br />
        <asp:Button ID="Enviar" Text="Enviar" OnClick="Enviar_Click" runat="server" type="button" class="btn btn-primary btn-block"/>
    </div>    
    <span id="Mensaje" runat="server"></span>
    <span id="Mensaje2" runat="server"></span>
    <a href="Registro.aspx">REGISTRARSE</a>
    </div>
        </div>
</asp:Content>
