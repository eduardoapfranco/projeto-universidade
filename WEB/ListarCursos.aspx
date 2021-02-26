<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ListarCursos.aspx.vb" Inherits="WEB.CadastraListaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h2><%: Title  %></h2>
    <p>Abaixo está a listagem de todos os Cursos.</p>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    
</asp:Content>
