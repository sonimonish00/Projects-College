<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Customer_Dashboard.aspx.cs" Inherits="Customer_Dashboard" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
     .auto-style2 {
         width: 200px;
         text-align: right;
     }
     .auto-style3 {
         width: 633px;
     }
    </style>
    <div>&nbsp;<span class="auto-style1"><strong>Welcome <asp:Label ID="lbl_Customer" runat="server" Text="Customer"></asp:Label> </strong></span>&nbsp;<asp:Button ID="btn_Logout_Customer" runat="server" Height="35px" Text="LOGOUT" Width="142px" style="text-align: center; float:right;" OnClick="btn_Logout_Customer_Click" />
           
    </div>
        <div >
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <ajaxToolkit:TabContainer ID="UMS" runat="server" ActiveTabIndex="1" Height="335px" Width="99%">
                <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" HeaderText="View Profile">
                    <ContentTemplate>
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style2">Username :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_User" runat="server" Height="16px" Width="509px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Email :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_Email" runat="server" Height="16px" Width="500px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Phone :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_Phone" runat="server" Height="16px" Width="506px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Full Name :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_Full" runat="server" Height="16px" Width="503px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Gender :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_gender" runat="server" Height="16px" Width="502px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Marital Status :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_Martial" runat="server" Height="16px" Width="501px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Addresss :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_View_address" runat="server" Height="67px" TextMode="MultiLine" Width="505px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    <asp:Button ID="Btn_Refresh" runat="server" Height="32px" OnClick="Btn_Refresh_Click" Text="Refresh" Width="117px" />
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>

                <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="Edit Profile">
                    <ContentTemplate>
                        
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style2">New Password :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="Txtbox_Edit_NewPass" runat="server" Height="21px" TextMode="Password" Width="507px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Email :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_Edit_Email0" runat="server" Height="16px" Width="500px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Phone :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TxtBox_Edit_Phone" runat="server" Height="16px" Width="506px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Full Name :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_Edit_Full0" runat="server" Height="16px" Width="503px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Gender :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_Edit_gender0" runat="server" Height="16px" Width="502px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Marital Status :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_Edit_Martial0" runat="server" Height="16px" Width="501px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Addresss :</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="TextBox_Edit_address0" runat="server" Height="51px" TextMode="MultiLine" Width="496px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    <asp:Button ID="Btn_Edit" runat="server" Height="30px" OnClick="Btn_Edit_Click" Text="Update Info." Width="183px" />
                                </td>
                            </tr>
                        </table>
                        
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
    </div>
           
</asp:Content>

