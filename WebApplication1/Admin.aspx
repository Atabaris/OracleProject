<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
   <div style="top: 15px; left: 0px; position: absolute; height: 613px; width: 1880px">
    
        <asp:Button ID="button_enter" runat="server" style="top: 232px; left: 882px; position: absolute; height: 26px; width: 185px" Text="Enter" OnClick="button_enter_Click"/>
    
        <table aria-orientation="horizontal" style="width: 20%; top: 75px; left: 758px; position: absolute; height: 56px; border-bottom:1pt solid black; border-top:1pt solid black" >
            <tr>
                <th colspan="2" style="color:black; font-size:36px;">ADMINISTRATOR</th>
            </tr>
            <tr  >
                <td class="auto-style2"><b>ID</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="text_UserID" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
           <tr  >
                <td class="auto-style2"><b>PASSWORD</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="text_Password" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Image ID="blue_template" runat="server" Height="66px" Width="1920px" src="images/c4.jpg" style="margin-left: 0px; margin-top: -25px;"/>
         <asp:Image ID="page_logo" runat="server" style="top: -5px; left: 0px; position: absolute; height: 84px; width: 92px" src="images/c5.png"/>       
        <asp:Label ID="label_error" runat="server" style="top: 282px; left: 764px; position: absolute; height: 45px; width: 387px" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="#FF3300"></asp:Label>
   </div>
    </form>
</body>
</html>
