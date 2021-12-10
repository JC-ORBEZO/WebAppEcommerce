<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Caja.aspx.cs" Inherits="Ecommerce.Caja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Página De Caja</h1>
    <span id="Contenedor3" runat="server"></span>
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
</asp:Content>
