<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table style="width:100%;">
        <tr>
            <td style="width: 197px; text-align: right">Username :</td>
            <td style="width: 190px">
                <asp:TextBox ID="txtBoxUsername" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBoxUsername" ErrorMessage="Username Could not be Empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 197px; text-align: right">Password :</td>
            <td style="width: 190px">
                <asp:TextBox ID="txtBoxPass" runat="server" TextMode="Password" Width="203px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBoxPass" ErrorMessage="Password Could not be Blank" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 197px">&nbsp;</td>
            <td style="width: 190px">
                <asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal" Width="160px">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Customer</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RV_Radio_Login_Admin_Customer" runat="server" ControlToValidate="Gender" ErrorMessage="Must Select One" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 197px">&nbsp;</td>
            <td style="width: 190px">
                <asp:Button ID="btnLogin" runat="server" Height="28px" Text="Login" Width="86px" OnClick="btnLogin_Click" />
&nbsp;&nbsp;
                <input id="Reset_login" style="height: 30px; width: 89px" type="reset" value="reset" /></td>
            <td>
                <asp:HyperLink ID="HyperLink_Forgot" runat="server" NavigateUrl="~/Forgot_Pass.aspx" ToolTip="Forgot Password">Forgot Password ?</asp:HyperLink>
            </td>
        </tr>
    </table>
    
</asp:Content>

