<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Caja.aspx.cs" Inherits="Ecommerce.Caja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Página De Caja</h1>
    <span id="contenedor" runat="server"></span>
    <%if (receptor != null)
        {
            foreach (var item in receptor)
            {%>
    <div style="border:1px solid black;width:30%;display:flex;flex-direction:column;align-items:center;">
        <img src="<%:item.Url %>" width="100" height="100" />
        <h2><%:item.codigo %></h2>
        <h2><%:item.nombre %></h2>
        <h2><%:item.precio %></h2>
    </div>            
        <%}
            }
            else {%>
                <h2>CARRITO VACÍO</h2>
            <%}
            %>
    <asp:Button Text="COMPRAR" ID="Comprar" OnClick="Comprar_Click" runat="server" />
    <%if (detalles!=null) {  
        foreach (var itea in detalles)
        {%>
    <div>
        <h2>CODIGO DE VENTA: <%=itea.CodigoVenta %></h2>
        <h2>ID DE ARTICULO: <%= itea.IdArticulo %></h2>
        <h2>CANTIDAD: <%=itea.Cantidad %></h2>
        <h2>PRECIO: <%= itea.Precio %></h2>
    </div>
            
        <%} }%>
</asp:Content>
