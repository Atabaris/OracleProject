<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information_Screen.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 131px;
        }
        .auto-style3 {
            width: 131px;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table aria-orientation="horizontal" style="width: 52%; top: 162px; left: 295px; position: absolute; height: 56px; border-bottom:1pt solid black; border-top:1pt solid black" >
            <tr>
                <th colspan="2" style="color:black; font-size:36px;">INFORMATION SCREEN</th>
            </tr>
            <tr  >
                <td class="auto-style2"><b>ID</b></td>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr >
                <td class="auto-style2" ><b>Birth</b></td>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" style="width: 0px" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><b>Phone</b></td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>Name</b></td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>Surname</b></td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td class="auto-style3"><b>Father Name</b></td>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td class="auto-style2"><b>DOCTOR NAME</b></td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td class="auto-style2"><b>POLYCLINIC NAME</b></td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                 </td>
            </tr>
        </table>
    <div style="height: 789px">
    
        
    
        
    
        
    
         <asp:Image ID="Image1" runat="server" Height="72px" Width="1920px" src="Images/c4.jpg" style="margin-left: 0px; margin-top: -25px;"/>
        
       <asp:Image ID="Image2" runat="server" style="top: 3px; left: 9px; position: absolute; height: 84px; width: 92px" src="Images/c5.png"/>
    
        
    
        
    
        
    
         <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 473px; top: 461px; position: absolute; height: 83px; width: 419px" Text="Return Reservation Page" OnClick="Button1_Click" />
    
        
    
        
    
        
    
    </div>
    </form>
</body>
</html>
