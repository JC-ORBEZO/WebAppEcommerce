<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Ecommerce.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>PÁGINA DE VENTAS</h1>

 <h2>LISTA DE VENTAS</h2>
    <%foreach (var item in listaVenta)
        {%>
            <div>
                <h3><%:item.Codigo %></h3>
                <h3><%:item.Dni %></h3>
                <h3><%:item.TipoDePago %></h3>
                <h3><%:item.Precio %></h3>
            </div>
        <%} %>
</asp:Content>
