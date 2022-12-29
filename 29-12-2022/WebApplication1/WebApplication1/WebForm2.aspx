<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    &nbsp;&nbsp;
                    <br />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Text="Red" Value="red"></asp:ListItem>
                        <asp:ListItem Text="Green" Value="green"></asp:ListItem>
                        <asp:ListItem Text="Blue" Value="blue"></asp:ListItem>
                    </asp:DropDownList>
    </form>
</body>
</html>
