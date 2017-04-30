<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="WebApplication1.AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            height: 159px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Image ID="blue_template" runat="server" Height="66px" Width="1920px" src="images/c4.jpg" Style="margin-left: 0px; margin-top: -25px;" />
        <asp:Image ID="page_logo" runat="server" Style="top: 13px; left: 10px; position: absolute; height: 84px; width: 92px" src="images/c5.png" />
        <asp:Table ID="Doctor_table" runat="server" Style="overflow-y: scroll; display: block; z-index: 1; left: 22px; top: 204px; position: absolute; height: 479px; width: 290px" BorderStyle="Solid" GridLines="Both" CaptionAlign="Top">
        </asp:Table>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 1; left: 380px; top: 106px; position: absolute; width: 159px; height: 87px" Text="Refresh Doctor Table" />

        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 28px; top: 131px; position: absolute; height: 62px; width: 282px" Text="DOCTOR TABLE"></asp:Label>

    </form>

</body>
</html>
