<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%int valor = 0; foreach (var item in ListaArticulos)
        {%>
        <div>
            <img src="<%:item.Url %>" alt="Alternate Text" width="200" height="200"/>
            <h2 ID="valor"><%: item.id %></h2>
            <h3><%:item.codigo %></h3>
            <p><%:item.descripcion %></p><% valor = item.id; %>
            <asp:Button ID="Detalle" Text="Ver más" runat="server" OnClick="Detalle_Click" />
            
            <a href="Detalle.aspx?identificador=<%=valor %>">enlace</a>
            <asp:Button Text="Eliminar" runat="server" />
        </div>
        <%} %>
</asp:Content>
