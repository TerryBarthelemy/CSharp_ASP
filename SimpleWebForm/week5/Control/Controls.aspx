<%@ Page Title="" Language="C#" MasterPageFile="~/Control/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Controls.aspx.cs" Inherits="Control_Controls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="textMainContent" Runat="Server">
    <p>
    <br />
    <asp:Label ID="login_success" runat="server" Text=" "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p style="margin-left: 400px">
    &nbsp;</p>
<p style="margin-left: 400px">
    &nbsp;</p>
<p style="margin-left: 400px">
    &nbsp;</p>
<p style="margin-left: 400px">
    <asp:Button ID="addPerson" runat="server" OnClick="addPerson_Click" Text="Add Contact" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="searchPerson" runat="server" OnClick="searchPerson_Click" Text="Search Contact" />
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

