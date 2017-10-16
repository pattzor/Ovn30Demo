<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index_ajax.aspx.cs" Inherits="Ovn30Demo.index_ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/myJavaScript.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <input type="button" id="loadContacts" value="Load contacts" />
    <table class="table table-condensed table-bordered">
        <thead>
            <tr>
                <th>ID</th>
                <th>Firstnam</th>
                <th>Lastnam</th>
                <th>SSN</th>
            </tr>
        </thead>
        <tbody id="myTableBody">
        </tbody>
    </table>
</asp:Content>
