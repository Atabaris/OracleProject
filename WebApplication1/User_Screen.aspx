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
            width: 102px;
        }
               
    </style>
</head>
<body style="width: 1487px">
    <form id="form1" runat="server">
    <div style="top: 15px; left: 10px; position: absolute; height: 613px; width: 1920px">
    
        <asp:Button ID="Button1" runat="server" style="top: 326px; left: 870px; position: absolute; height: 26px; width: 185px" Text="Enter" OnClick="Button1_Click" />
    
        <table aria-orientation="horizontal" style="width: 20%; top: 75px; left: 758px; position: absolute; height: 56px; border-bottom:1pt solid black; border-top:1pt solid black" >
            <tr>
                <th colspan="2" style="color:black; font-size:36px;">Reservation System Validance</th>
            </tr>
            <tr  >
                <td class="auto-style2"><b>ID</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="Text_UserID" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr >
                <td class="auto-style2" ><b>Birth</b></td>
                <td class="auto-style1">
                    <asp:TextBox ID="Text_UserBirth" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><b>Phone</b></td>
                <td>
                    <asp:TextBox ID="Text_UserPhone" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>Name</b></td>
                <td>
                    <asp:TextBox ID="Text_UserName" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>Surname</b></td>
                <td>
                    <asp:TextBox ID="Text_UserSurname" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>Father Name</b></td>
                <td>
                    <asp:TextBox ID="Text_UserFaterName" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
        </table>
    
    
        <asp:Label ID="Label1" runat="server" style="top: -1px; left: 185px; position: absolute; height: 36px; width: 119px; color:white; font-size:36px; font-weight:bold" Text="HOME"></asp:Label>
    
    
        
    
    
    </div>

         

         <asp:Image ID="Image1" runat="server" Height="66px" Width="1980px" src="http://www.dreamtemplate.com/dreamcodes/bg_images/color/c4.jpg" style="margin-left: 0px"/>
    </form>
</body>
</html>
