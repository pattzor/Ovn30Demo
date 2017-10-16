<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index_new.aspx.cs" Inherits="Ovn30Demo.index_new" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <asp:Table ID="TableContacts" CssClass="table table-condensed table-hover" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>ID</asp:TableHeaderCell>
            <asp:TableHeaderCell>Firstname</asp:TableHeaderCell>
            <asp:TableHeaderCell>Lastname</asp:TableHeaderCell>
            <asp:TableHeaderCell>SSN</asp:TableHeaderCell>
            <asp:TableHeaderCell>&nbsp;</asp:TableHeaderCell>
        </asp:TableHeaderRow>

    </asp:Table>
</asp:Content>
