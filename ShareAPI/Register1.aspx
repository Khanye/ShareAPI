<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateMasterPage.Master" AutoEventWireup="true" CodeBehind="Register1.aspx.cs" Inherits="ShareAPI.WebForm2" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table border="0" style="width:100%; font-size: medium; font-family: 'Times New Roman', Times, serif;">
    <tr>
        <td style="height: 18px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Name:</td>
        <td style="height: 18px">
            <asp:TextBox ID="txtusername" runat="server" Width="455px"></asp:TextBox>
        </td>
        <td style="height: 18px"></td>
    </tr>
    <tr>
        <td style="height: 24px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email:</td>
        <td style="height: 24px">
            <asp:TextBox ID="txtemail" runat="server" Width="453px"></asp:TextBox>
        </td>
        <td style="height: 24px"></td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:</td>
        <td style="height: 23px">
            <input id="txtpassword" type="password" /></td>
        <td style="height: 23px"></td>
    </tr>
    <tr>
        <td style="height: 23px">Confirm Password:&nbsp; </td>
        <td style="height: 23px">
            <input id="txtconfirmpasword" type="password" /></td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px"></td>
        <td class="text-justify" style="height: 23px">
            <asp:Button ID="btnRegister" runat="server" Text="Register" Width="451px" />
        </td>
        <td style="height: 23px"></td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;</td>
        <td style="height: 23px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; OR</td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px"></td>
        <td class="text-justify" style="height: 23px">
            <asp:Button ID="btnfacebookreg" runat="server" BackColor="Blue" ForeColor="White" Text="Register with Facebook" />
        </td>
        <td style="height: 23px"></td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;</td>
        <td class="text-justify" style="height: 23px">
            <asp:Button ID="btngmailreg" runat="server" BackColor="Maroon" Text="Register with Gmail" />
        </td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;</td>
        <td class="text-justify" style="height: 23px">
            <asp:Button ID="btntwitterreg" runat="server" BackColor="#3333FF" Text="Register with Twitter" />
        </td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;</td>
        <td style="height: 23px">&nbsp;</td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px">&nbsp;</td>
        <td style="height: 23px">&nbsp;</td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
</table>
</asp:Content>


