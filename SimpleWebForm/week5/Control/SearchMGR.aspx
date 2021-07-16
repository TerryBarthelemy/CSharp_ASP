<%@ Page Title="" Language="C#" MasterPageFile="~/Control/AdminMasterPage.master" AutoEventWireup="true" CodeFile="SearchMGR.aspx.cs" Inherits="Control_SearchMGR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="textMainContent" Runat="Server">
    <br />
    <br />
    <br />
    <center>First Name: <asp:TextBox ID="firstnameTXT" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Last Name: <asp:TextBox ID="lastnameTXT" runat="server"></asp:TextBox></center>
    <br />
    <br />
    <center><asp:Button ID="searchPeople" runat="server" OnClick="searchPeople_Click" Text="Search" /></center>
    <br />
    <center><asp:GridView ID="dgvPersons" runat="server" Width="323px" AllowPaging="True" OnSelectedIndexChanged="dgvPersons_SelectedIndexChanged"  AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="PeopleID" DataNavigateUrlFormatString="ContentMGR.aspx?Per_ID={0}" Text="Edit" />
            <asp:BoundField DataField="PeopleID" HeaderText="ID" />
            <asp:BoundField DataField="FName" HeaderText="First Name" />
            <asp:BoundField DataField="LName" HeaderText="Last Name" />
        </Columns>
    </asp:GridView></center>
    &nbsp;&nbsp;&nbsp;  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

