<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Caja.aspx.cs" Inherits="Ecommerce.Caja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Página De Caja</h1>
    <span id="contenedor" runat="server"></span>
    <!--
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
        else
        {%>
                <h2>CARRITO VACÍO</h2>
            <%}
            %>
    -->

    <!--
    <%if (detalles != null)
        {
            foreach (var itea in detalles)
            {%>
    <div>
        <h2>CODIGO DE VENTA: <%=itea.CodigoVenta %></h2>
        <h2>ID DE ARTICULO: <%= itea.IdArticulo %></h2>
        <h2>CANTIDAD: <%=itea.Cantidad %></h2>
        <h2>PRECIO: <%= itea.Precio %></h2>
    </div>
            
        <%}
        }%>
    -->
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col" class="text-center">Codigo</th>
                <th scope="col" class="text-center">Cantidad</th>
                <th scope="col" class="text-center">Precio Unitario</th>
                <th scope="col" class="text-center"></th>
            </tr>
        </thead>
        <tbody>
            <%int enumerador = 1; if (receptorDetalles != null)
                {
                    foreach (var itema in receptorDetalles)
                    {%>
            <tr>
                <th scope="row"><%:enumerador++ %></th>
                <td class="text-center"><%:itema.IdArticulo %></td>
                <td class="text-center">
                    <!--<a href="Caja.aspx?cantidad=<%=itema.IdArticulo%>" title="+" class="btn btn-primary">+</a>-->
                    <%:itema.Cantidad %>
                    <!--<a href="Caja.aspx?cantidad=<%=itema.IdArticulo%>" title="-" class="btn btn-success">-</a>-->
                </td>
                <td class="text-center"><%:itema.Precio %></td>
                <td>
                    <img src="<%:itema.Imagen %>" alt="Alternate Text" width="40" height="40" /></td>
            </tr>

            <%}
            }%>
            <asp:Button Text="COMPRAR" ID="Comprar" OnClick="Comprar_Click" class="btn btn-success" runat="server" />
             
        </tbody>
    </table>
</asp:Content>
