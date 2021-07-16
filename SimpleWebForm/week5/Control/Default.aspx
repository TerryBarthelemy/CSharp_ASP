<%@ Page Title="" Language="C#" MasterPageFile="AdminMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Control_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="textMainContent" Runat="Server">
    <br />
Username: <asp:TextBox ID="user_name_txt" runat="server" ></asp:TextBox>
<br />
Password: <asp:TextBox ID="pwd_txt" runat="server"></asp:TextBox>
<br />
<asp:Button ID="loginBTN" runat="server" OnClick="loginBTN_Click" Text="Login" />
    <br />
<asp:Label ID="lblfeedback" runat="server"></asp:Label>
</asp:Content>


