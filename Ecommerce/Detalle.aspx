<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Ecommerce.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle</h1>
    <div>
        <h3><%:recibi %></h3>
        <%foreach (var item in nuevaLista)
            {
                if (item.id == int.Parse(recibi))
                {%>
        <div>
            <img src="<%:item.Url %>" alt="Alternate Text" width="200" height="200" />
            <h2 id="valor"><%: item.id %></h2>
            <h3><%:item.codigo %></h3>
            <p><%:item.descripcion %></p>
            <asp:Button Text="Agregar al Carrito" runat="server" />
        </div>
        <%}

            } %>
    </div>
</asp:Content>
