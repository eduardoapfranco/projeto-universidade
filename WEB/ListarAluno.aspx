<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ListarAluno.aspx.vb" Inherits="WEB.CadastraAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h2><%: Title  %></h2>
    <p>Abaixo está a listagem de todos os alunos.</p>
    <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
</asp:Content>
