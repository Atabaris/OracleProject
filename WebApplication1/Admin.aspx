<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="top: 5px; left: 8px; position: absolute; height: 853px; width: 1490px">
    
        
    
        <asp:Label ID="Admin_ID" runat="server" style="top: 140px; left: 380px; position: absolute; height: 70px; width: 210px" Text="ID&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;:" BorderStyle="Groove" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="False"></asp:Label>
        <asp:Label ID="Admin_Password" runat="server" style="top: 250px; left: 380px; position: absolute; height: 70px; width: 210px" Text="Password&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;:" BorderStyle="Groove" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    

        <asp:TextBox ID="TextBox1" runat="server" style="top: 250px; left: 620px; position: absolute; height: 70px; width: 260px" BorderStyle="Outset" TextMode="Password" ValidateRequestMode="Enabled"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="top: 139px; left: 620px; position: absolute; height: 70px; width: 260px" BorderStyle="Outset" ValidateRequestMode="Enabled"></asp:TextBox>
    
        <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" Font-Size="X-Large" style="top: 275px; left: 900px; position: absolute; height: 45px; width: 220px" Text="Show Password" />
    
        
    
        <asp:Button ID="Button1" runat="server" style="top: 588px; left: 610px; position: absolute; height: 90px; width: 260px" Text="Enter" />
    
        
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Font-Underline="True" ForeColor="#FF3300" style="top: 59px; left: 382px; position: absolute; height: 57px; width: 504px"></asp:Label>
        
        
    
    </div>
    </form>
</body>
</html>
