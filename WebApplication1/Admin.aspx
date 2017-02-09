<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            height: 23px;
            width: 102px;
        }
        .auto-style1 {
            height: 23px;
        }
        .auto-style3 {
            width: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="top: 15px; left: 10px; position: absolute; height: 599px; width: 1490px">
    
        <table aria-orientation="horizontal" style="width: 20%; top: 169px; left: 668px; position: absolute; height: 56px;" border="1">
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox2" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
