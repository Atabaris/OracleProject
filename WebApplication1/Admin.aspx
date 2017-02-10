<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
   <div style="top: 15px; left: 0px; position: absolute; height: 613px; width: 1880px">
    
        <asp:Button ID="Button1" runat="server" style="top: 232px; left: 882px; position: absolute; height: 26px; width: 185px" Text="Enter"/>
    
        <table aria-orientation="horizontal" style="width: 20%; top: 75px; left: 758px; position: absolute; height: 56px; border-bottom:1pt solid black; border-top:1pt solid black" >
            <tr>
                <th colspan="2" style="color:black; font-size:36px;">ADMINISTRATOR</th>
            </tr>
            <tr  >
                <td class="auto-style2"><b>ID</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="Text_UserID" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
           <tr  >
                <td class="auto-style2"><b>PASSWORD</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="Text_Password" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Image ID="Image1" runat="server" Height="66px" Width="1920px" src="http://www.dreamtemplate.com/dreamcodes/bg_images/color/c4.jpg" style="margin-left: 0px; margin-top: -25px;"/>
         <asp:Image ID="Image2" runat="server" style="top: -5px; left: 0px; position: absolute; height: 84px; width: 92px" src="http://kurumsal.tamindir.com/wp-content/uploads/2014/11/kurumsal_tamindir_1764.png"/>       
   </div>
    </form>
</body>
</html>
