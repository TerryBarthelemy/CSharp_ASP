<%@ Page Title="" Language="C#" MasterPageFile="AdminMasterPage.master" AutoEventWireup="true" CodeFile="ContentMGR.aspx.cs" Inherits="ContentMGR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="textMainContent"  Runat="Server">
    <asp:Label ID="login_success" runat="server" Text=" "></asp:Label>
    <asp:Label ID="lblPerson_ID" runat="server" Text=" "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblFeedback" runat="server" Text=" "></asp:Label>
    <br />
    <br />

    <asp:Label ID="lblfirst" runat="server" Text="First Name: "></asp:Label>
    <asp:TextBox ID="txtfirst" runat="server" MaxLength="255"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvfirst" runat="server" style="color:red" ControlToValidate="txtfirst" ErrorMessage="* Must Fill In Required Field"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblmiddle" runat="server" Text="Middle Name: "></asp:Label>
    <asp:TextBox ID="txtmiddle" runat="server" MaxLength="255"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvmiddle" runat="server" style="color:red" ControlToValidate="txtmiddle" ErrorMessage="*Must Fill In Required Field"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lbllast" runat="server" Text="Last Name: "></asp:Label>
    <asp:TextBox ID="txtlast" runat="server" MaxLength="255"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvlast" runat="server" style="color:red" ControlToValidate="txtlast" ErrorMessage="*Must Fill In Required Field"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lbladdress" runat="server" Text="Address: "></asp:Label>
    <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblcity" runat="server" Text="City: "></asp:Label>
    <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
    <br />    
    <asp:Label ID="lblstate" runat="server" Text="State:"></asp:Label>
    <asp:TextBox ID="txtstate" runat="server" MaxLength="2"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvstate" runat="server" style="color:red" ControlToValidate="txtstate" ErrorMessage="*Must Fill In Required Field"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revstate" runat="server" style="color:red"  ErrorMessage="State Not In Proper Format" 
        ControlToValidate="txtstate" ValidationExpression="^(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))$">
    </asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblzip" runat="server" Text="Zip Code: "></asp:Label>
    <asp:TextBox ID="txtzip" runat="server" MaxLength="5"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvzip" runat="server" style="color:red" ControlToValidate="txtzip" ErrorMessage="*Must Fill In Required Field"></asp:RequiredFieldValidator><br />
    <asp:CompareValidator ID="cvzip" runat="server" ControlToValidate="txtzip" ErrorMessage="*Contains Numeric Characters " Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
    <br />
    <asp:Label ID="lblemail" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvemail" runat="server" style="color:red" ControlToValidate="txtemail" ErrorMessage="*Must Fill In Required Field"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revemail" runat="server" style="color:red" ControlToValidate="txtemail" ErrorMessage="*Enter Correct Email Format" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblcellphone" runat="server" Text="Cellphone #: "></asp:Label>
    <asp:TextBox ID="txtcellphone" runat="server" MaxLength="10"></asp:TextBox>
    <asp:RegularExpressionValidator ID="revcellphone" runat="server" style="color:red" ErrorMessage="Phone Number Not In Proper Format" 
        ControlToValidate="txtcellphone" ValidationExpression="^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$">
    </asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="height: 26px" Text="Submit" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="updatePerson" runat="server" OnClick="updatePerson_Click" Text="Update Person" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="deletePerson" runat="server" OnClick="deletePerson_Click" Text="Delete Person" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="searchPerson" runat="server" OnClick="searchPerson_Click" Text="Search People" />

    <br />
    <br />
<asp:Label ID="lblResults" runat="server" Text=" "></asp:Label>
<br />
<br />
    <asp:Button ID="logoutBTN" runat="server" OnClick="logoutBTN_Click" Text="Logout" />
<br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

