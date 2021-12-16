<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Ecommerce.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--<h1 class="text-center">Lista de Artículos</h1>-->
    <div class="row row-cols-3">
        <%int count = 0; foreach (var item in listaArticulos)
            {%>
        <!--<div style="border:1px solid black;width:30%;display:flex;flex-direction:column;align-items:center;">
        <img src="<%:item.Url %>" width="100" height="100" />
        <%count = item.id; %>
        <h2><%:item.codigo %></h2>
        <h2><%:item.nombre %></h2>
        <h2><%:item.precio %></h2>
        <%contenedor = item.id; %>        
        <a href="Articulos.aspx?contador=<%=contenedor%>" title="Añadir al carrito" OnClick="AgregarCarrito_Click" class="btn btn-primary">Agregar 1</a>
    </div>    -->
        <div class="card col-auto mr-3 mt-1" style="width: 31%;">
            <img src="<%:item.Url %>" class="card-img-top" alt="Imagen">
            <div class="card-body text-center">
                <h5 class="card-title"><%:item.nombre %></h5>
                <p class="card-text"><%:item.descripcion %></p>
                <h5 class="card-title">$ <%:item.precio %></h5>
                <!--<a href="#" class="btn btn-primary">Agregar a carrito</a>-->
                <a href="Articulos.aspx?contador=<%=contenedor%>" title="Añadir al carrito" onclick="AgregarCarrito_Click" class="btn btn-primary">Agregar a carrito</a>
            </div>
        </div>
        <%} %>
    </div>
</asp:Content>
