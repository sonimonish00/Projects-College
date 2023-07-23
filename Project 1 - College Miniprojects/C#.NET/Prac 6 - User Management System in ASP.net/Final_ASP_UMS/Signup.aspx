<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    <table style="width:100%;">
        <tr>
            <td style="width: 185px; text-align: right">Username :</td>
            <td style="width: 184px">
                <asp:TextBox ID="TextBox_username" runat="server" Width="300px"></asp:TextBox>
            </td>
            <td style="width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Username" runat="server" ErrorMessage="Username Is Required" ForeColor="Red" ControlToValidate="TextBox_username"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Password :</td>
            <td style="width: 184px">
                <asp:TextBox ID="TextBox_pass" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Pass" runat="server" ErrorMessage="Password Is Required" ForeColor="Red" ControlToValidate="TextBox_pass"></asp:RequiredFieldValidator>
            &nbsp;<br />
                <asp:RegularExpressionValidator ID="regex_Pass" runat="server" ControlToValidate="TextBox_pass" ErrorMessage="Minimum 8 characters at least 1 Alphabet and 1 Number - Ex: pass1234 " ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Confirm Password :</td>
            <td style="width: 184px">
                <asp:TextBox ID="TextBox_repass" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Repass" runat="server" ErrorMessage="Confirm pass is Required" ForeColor="Red" ControlToValidate="TextBox_repass"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox_pass" ControlToValidate="TextBox_repass" ErrorMessage="Password Must Match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right; height: 26px;">Email-ID :</td>
            <td style="width: 184px; height: 26px;">
                <asp:TextBox ID="TextBox_email" runat="server" TextMode="Email" Width="300px"></asp:TextBox>
            </td>
            <td style="height: 26px; text-align: left; width: 251px;">
                <asp:RequiredFieldValidator ID="RFV_Email" runat="server" ErrorMessage="Email-ID is Required" ForeColor="Red" ControlToValidate="TextBox_email"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox_email" ErrorMessage="Invalid Email Adderss" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Phone No :</td>
            <td style="width: 184px">
                <asp:TextBox ID="TextBox_phone" runat="server" TextMode="Number" Width="300px"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Phone" runat="server" ErrorMessage="Phone No. is Required" ForeColor="Red" ControlToValidate="TextBox_phone"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox_phone" ErrorMessage="Indian Phone Number" ForeColor="Red" ValidationExpression="^[789]\d{9}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 185px; text-align: right">Full Name :</td>
            <td style="height: 23px; width: 184px">
                <asp:TextBox ID="TextBox_fullname" runat="server" Width="300px"></asp:TextBox>
            </td>
            <td style="height: 23px; text-align: left; width: 251px;">
                <asp:RequiredFieldValidator ID="RFV_Full" runat="server" ErrorMessage="Full Name is Required" ForeColor="Red" ControlToValidate="TextBox_fullname"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Gender :</td>
            <td style="width: 184px">
                <asp:RadioButtonList ID="RadioButtonList_gender" runat="server" Height="28px" RepeatDirection="Horizontal" Width="144px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Gender" runat="server" ErrorMessage="Gender is Required" ForeColor="Red" ControlToValidate="RadioButtonList_gender"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Marital Status :</td>
            <td style="width: 184px">
                <asp:DropDownList ID="MartialDropDown" runat="server" Height="16px" Width="186px">
                    <asp:ListItem Value="Marital Status">Select Your Marital Status</asp:ListItem>
                    <asp:ListItem>Married</asp:ListItem>
                    <asp:ListItem>UnMarried</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Martial" runat="server" ErrorMessage="Martial Status is Required" ForeColor="Red" ControlToValidate="MartialDropDown"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">Address :</td>
            <td style="width: 184px">
                <asp:TextBox ID="TextBox_Address" runat="server" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
            <td style="text-align: left; width: 251px">
                <asp:RequiredFieldValidator ID="RFV_Address" runat="server" ErrorMessage="Address is Required" ForeColor="Red" ControlToValidate="TextBox_Address"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 185px; text-align: right">&nbsp;</td>
            <td style="width: 184px; text-align: center;">
                <asp:Button ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Reset1" style="width: 70px" type="reset" value="reset" /></td>
            <td id="vg" aria-multiline="True" style="text-align: left; width: 251px">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
    </table>
   
</asp:Content>

