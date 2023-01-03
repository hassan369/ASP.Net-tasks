<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="testing_authentication.WebUserControl1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 99px;
    }
    .auto-style3 {
        font-size: large;
        background-color: #CCCCFF;
    }
</style>
<table class="auto-style1">
    <tr>
        <td class="auto-style2">
<asp:Label ID="Label2" runat="server" Text="رأيكم يهمنا" BackColor="#99CCFF"></asp:Label>
        </td>
    </tr>
</table>
<p>
    <asp:Label ID="Label3" runat="server" Text="ما مدى رضاك عن الخدمات الالكترونية؟"></asp:Label>
</p>
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem Value="1">ممتاز</asp:ListItem>
    <asp:ListItem Value="2">جيد جدا</asp:ListItem>
    <asp:ListItem Value="3">جيد</asp:ListItem>
    <asp:ListItem Value="4">ضعيف</asp:ListItem>
    <asp:ListItem Value="5">مقبول</asp:ListItem>

</asp:RadioButtonList>

<asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="تصويت" />
<p>
    &nbsp;</p>
<div id="after" runat="server" style="display:none;">
    &nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
&nbsp;
    ممتاز<br />
&nbsp;<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
&nbsp; جيد جدا
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;
    جيد<br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>

&nbsp; ضعيف&nbsp;
    <br />
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

&nbsp;&nbsp;مقبول  
    <br />
            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>

&nbsp;&nbsp;اجمالي عدد المصوتين
</div>