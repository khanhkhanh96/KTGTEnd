<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NAvmenu.ascx.cs" Inherits="controls_WebUserControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 40px;
    }
</style>

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td style="background-image: none; text-align: center; background-color: #FFFF00; height: 40px;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Nghenhac.aspx">Nghe nhạc</asp:HyperLink>
&nbsp; 
&nbsp;&nbsp; |&nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/login.aspx">Đăng nhập</asp:HyperLink>
        &nbsp; |&nbsp;&nbsp; |&nbsp;
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Trangtainhac.aspx">Tải nhạc</asp:HyperLink>
&nbsp; |&nbsp; 
            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/profile.aspx">Đăng kí</asp:HyperLink>
            &nbsp;</td>
    </tr>
</table>

