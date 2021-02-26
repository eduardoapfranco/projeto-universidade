<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CadastraCurso.aspx.vb" Inherits="WEB.CadastraCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title  %></h2>
    <p>Preencha o cadastro de curso</p>

    <div class="row">
        <div class="mb-3">
            <label for="CodigoCurso" class="form-label">Código Curso</label>
            <input type="text" class="form-control" id="CodigoCurso" placeholder="" readonly="true" runat="server">
        </div>
    </div>

     <div class="row">
        <div class="mb-4">
            <label for="NomeCurso" class="form-label">Nome Curso</label>
            <input type="text" class="form-control" id="NomeCurso" placeholder="Preencha o nome do curso"  runat="server">
        </div>

         <div class="mb-3">
            <label for="SiglaCurso" class="form-label">Sigla Curso</label>
            <input type="text" class="form-control" id="SiglaCurso" placeholder="Preencha a sigla do curso"  runat="server">
        </div>

         <div class="mb-3">
            <label for="ValorCreditoCurso" class="form-label">Valor Crédito Curso</label>
            <input type="text" class="form-control" id="ValorCreditoCurso" placeholder="Preencha o valor de crédito do curso"  runat="server">
        </div>
         <asp:Button ID="Cadastrar" CssClass="btn btn-primary" runat="server" Text="Cadastrar" />
    </div>


</asp:Content>
