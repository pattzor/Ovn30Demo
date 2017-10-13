<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Ovn30Demo.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">
    <div class="form-group">
        <label for="TextBoxFirstname">Firstname:</label>
        <asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="TextBoxLastname">Password:</label>
        <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="TextBoxSSN">Password:</label>
        <asp:TextBox ID="TextBoxSSN" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="ButtonContact" runat="server" Text="Something" />
</asp:Content>
