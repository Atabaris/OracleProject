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
    <div style="top: 15px; left: 0px; position: absolute; height: 613px; width: 1880px">
    
        <asp:Button ID="Button1" runat="server" style="top: 412px; left: 866px; position: absolute; height: 26px; width: 185px" Text="Enter" OnClick="Button1_Click" />
    
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
             <tr>
                <td class="auto-style2"><b>Enter Number</b></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="175px"></asp:TextBox>
                 </td>
            </tr>
        </table>
    
         <asp:Image ID="Image1" runat="server" Height="66px" Width="1920px" src="Images/c4.jpg" style="margin-left: 0px; margin-top: -25px;"/>
       <a href ="Admin.aspx"> <asp:Label ID="HOME_page"  runat="server" style="top: 4px; left: 121px; position: absolute; height: 36px; width: 89px; color:white; font-size:20px; font-weight:bold" Text="HOME"></asp:Label> </a>
       <a href="Admin.aspx"> <asp:Label ID="ABOUTUS_page" runat="server" style="top: 4px; position: absolute; height: 36px; width: 151px; color:white; font-size:20px; font-weight:bold; right: 1444px;" Text="ABOUT US"></asp:Label>  </a>  
       <a href ="Admin.aspx"><asp:Label ID="CONTACTUS_page" runat="server" style="top: 4px; left: 1311px; position: absolute; height: 36px; width: 176px; color:white; font-size:20px; font-weight:bold" Text="CONTACT US"></asp:Label> </a>
       <a href ="Admin.aspx"> <asp:Label ID="SETTINGS_page" runat="server" style="top: 4px; left: 1600px; position: absolute; height: 36px; width: 136px; color:white; font-size:20px; font-weight:bold" Text="SETTINGS"></asp:Label>        </a>                      
        <asp:Label ID="Protection" runat="server" style="top: 750px; left: 594px; position: absolute; height: 19px; width: 781px" Text="Sitede yer alan tüm içeriğin hakları saklıdır. <b>2017 © AB</b> - Site Sahibi izni olmaksızın kullanılamaz. Bu bir <b>AtaBerk</b> yapımıdır."></asp:Label>
        
       <asp:Image ID="Image2" runat="server" style="top: -5px; left: 0px; position: absolute; height: 84px; width: 92px" src="Images/c5.png"/>
       <asp:Label ID="SECURITY_number" runat="server" style="font-size:25px;font-weight:bold;top: 362px; left: 921px; position: absolute; height: 34px; width: 74px" Text="null"></asp:Label>
        <asp:Label ID="EROR_LABEL" runat="server" ForeColor="#CC3300" style="z-index: 1; left: 764px; top: 475px; position: absolute; width: 377px; height: 50px" Text="Label"></asp:Label>
    </div>
        
    </form>
</body>
</html>
