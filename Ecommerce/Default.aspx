<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%foreach (var item in ListaArticulos)
        {%>
        <div>
            <img src="<%:item.Url %>" alt="Alternate Text" width="200" height="200"/>
            <h3><%:item.codigo %></h3>
            <p><%:item.descripcion %></p>
            <asp:Button Text="Comprar" runat="server" />
            <asp:Button Text="Eliminar" runat="server" />
        </div>
        <%} %>
</asp:Content>
