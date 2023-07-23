<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtBox_a" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtbox_b" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="27px" OnClick="btnAdd_Click" Text="Add" Width="73px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Sub" runat="server" Height="28px" OnClick="Btn_Sub_Click" Text="Subtract" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Mul" runat="server" Height="26px" OnClick="Btn_Mul_Click" Text="Multiply" Width="79px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Divide" runat="server" Height="26px" OnClick="Btn_Divide_Click" Text="Divide" Width="83px" />
        <br />
        <br />
        <asp:Label ID="Lbl_Answer" runat="server" Text="Your Answer"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
