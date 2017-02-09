<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Screen.aspx.cs" Inherits="WebApplication1.User_Screen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 102px;
        }
        .auto-style3 {
            width: 102px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="top: 15px; left: 10px; position: absolute; height: 613px; width: 1490px">
    
        <table aria-orientation="horizontal" style="width: 20%; top: 169px; left: 668px; position: absolute; height: 56px;" border="1">
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Birth</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox2" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Phone</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style3">Name</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">Surname</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">Father Name</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
