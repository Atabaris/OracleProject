<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Button ID="button_start" runat="server" Height="34px" OnClick="button_start_Click" Text="StartDbConnection" Width="178px" />
        <asp:Label ID="Label1" runat="server" Height="30px" style="text-align: right; margin-left: 27px" Width="303px"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Example"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
