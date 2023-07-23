<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Forgot_Pass.aspx.cs" Inherits="Forgot_Pass" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .modalBackground {
               background-color: black;
               filter: alpha(opacity=90);
               opacity: 0.8;
        }
        .modalPopup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 500px;
            height: 350px;
        }
    </style>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div align="center">
        <asp:Button ID="Back_Button" runat="server" Text="Click Here To Reset Password"  Height="26px" Width="513px" />
    </div>

    <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup">
        <center><strong><h2>Forgot Password</h2></strong></center><br/>
        <table style="width: 100%;">
            <tr>
                <td style="width: 215px; text-align: right">Username :</td>
                <td style="width: 177px">
                    <asp:TextBox ID="txtBoxUser_Forgot" runat="server" Width="168px" Height="19px"></asp:TextBox>
                </td>
                <td style="width: 446px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 215px">&nbsp;</td>
                <td style="width: 177px">
                    <asp:Button ID="Btn_OTP" runat="server" Height="35px" style="display:block;text-align:center;" Text="Send OTP" Width="110px" OnClick="Btn_OTP_Click" />
                </td>
                <td style="width: 446px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 215px; text-align: right;">Enter OTP You Have Recieved :</td>
                <td style="width: 177px">
                    <asp:TextBox ID="txtBox_OTP" runat="server" Height="17px" Width="169px" Enabled="False"></asp:TextBox>
                </td>
                <td style="width: 446px">
                    <asp:Button ID="btnGO" runat="server" Height="30px" Text="GO" Width="66px" OnClick="btnGO_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 215px; text-align: right;">Reset Password :</td>
                <td style="width: 177px">
                    <asp:TextBox ID="txtBoxresetPass" runat="server" Enabled="False" Height="16px" TextMode="Password" Width="169px"></asp:TextBox>
                </td>
                <td style="width: 446px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 215px; text-align: right;">&nbsp;</td>
                <td style="width: 177px">
                    <asp:Button ID="btn_Final_Ok" runat="server" Height="29px" OnClick="btn_Final_Ok_Click" Text="Reset Password" Width="111px" />
                </td>
                <td style="width: 446px">
                    <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
    </asp:Panel>

<ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="modalBackground" DropShadow="True" PopupControlID="Panel1" OkControlID="btn_Cancel" TargetControlID="Back_Button"></ajaxToolkit:ModalPopupExtender>

</asp:Content>
