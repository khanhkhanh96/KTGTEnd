<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Head.ascx.cs" Inherits="controls_WebUserControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 80px;
    }
    .style2
    {
        text-align: center;
        font-size: medium;
    }
</style>

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td class="style2" style="background-color: #008080">
            TRANG WEB NGHE NHẠC HAY HAY</td>
    </tr>
    <tr>
        <td class="style2" style="background-color: #008080; height: 30px;">
            <asp:Label ID="Label1" runat="server" Text="Chào "></asp:Label>
            <asp:Label ID="Label2" runat="server" style="text-align: right" Text="Khách"></asp:Label>
        </td>
    </tr>
</table>

