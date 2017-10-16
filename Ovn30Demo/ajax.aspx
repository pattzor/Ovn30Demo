<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ajax.aspx.cs" Inherits="Ovn30Demo.ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="javascript/myJavaScript.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <input id="loadButton" type="button" value="Load Contacts" />
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>ID</th>
                <th>Firstname</th>
                <th>Lastname</th>
                <th>SSN</th>
                <th>&nbsp;</th>
            </tr>
        </thead>
        <tbody id="myTableBody"></tbody>
    </table>
</asp:Content>
