<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtLCD" runat="server"></asp:TextBox>
        <asp:Button ID="memStored" runat="server" OnClick="memStored_Click" Text="MS" />
        <asp:Button ID="memRestored" runat="server" OnClick="memRestored_Click" Text="MR" />
        <asp:Button ID="memCleared" runat="server" OnClick="memCleared_Click" Text="MC" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="memLabel" style="display: none;" runat="server" Text="&quot;&quot;"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="1" />
        <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" style="width: 21px" Text="2" />
        <asp:Button ID="btn3" runat="server" OnClick="btn3_Click" Text="3" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPlus" runat="server" OnClick="btnPlus_Click" Text="+" />
        <br />
        <asp:Button ID="btn4" runat="server" OnClick="btn4_Click" Text="4" />
        <asp:Button ID="btn5" runat="server" OnClick="btn5_Click" style="width: 21px" Text="5" />
        <asp:Button ID="btn6" runat="server" OnClick="btn6_Click" Text="6" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="-" />
        <br />
        <asp:Button ID="btn7" runat="server" OnClick="btn7_Click" Text="7" />
        <asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Text="8" />
        <asp:Button ID="btn9" runat="server" OnClick="btn9_Click" Text="9" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTimes" runat="server" OnClick="btnTimes_Click" Text="x" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn0" runat="server" OnClick="btn0_Click" Text="0" />
        <asp:Button ID="btnDecimal" runat="server" OnClick="btnDecimal_Click" Text="." />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="/" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEqual" runat="server" OnClick="btnEqual_Click" Text="=" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="C" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblNum1" style="display: none;" runat="server" Text="0"></asp:Label>
    </form>
</body>
</html>
