<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ajax_div.aspx.cs" Inherits="Ovn30Demo.ajax_div" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="javascript/myJavaScriptDIV.js"></script>
    <link href="style/myDivStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <input id="loadButton" type="button" value="Load Contacts" />
    <div class="myDivTableContainer">
        <div class="myDivTable">
            <div class="myDivTableHead">
                <div class="myDivTableHeadRow">
                    <div class="myDivTableCell">ID</div>
                    <div class="myDivTableCell">Firstname</div>
                    <div class="myDivTableCell">Lastname</div>
                    <div class="myDivTableCell">SSN</div>
                    <div class="myDivTableCell">&nbsp;</div>
                </div>
            </div>
            <div class="myDivTableBody">

            </div>
        </div>
    </div>
</asp:Content>
