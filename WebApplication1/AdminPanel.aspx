<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="WebApplication1.AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <asp:Button ID="Button2" runat="server" Style="z-index: 1; left: 860px; top: 101px; position: absolute; width: 159px; height: 87px" Text="Refresh PDP Table" OnClick="Button2_Click" />
         <asp:Button ID="Button3" runat="server"  Style="z-index: 1; left: 1450px; top: 101px; position: absolute; width: 159px; height: 87px" Text="Refresh Reservation Table" OnClick="Button3_Click" />


        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 28px; top: 131px; position: absolute; height: 62px; width: 282px" Text="DOCTOR TABLE"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 617px; top: 131px; position: absolute; height: 62px; width: 282px" Text="PDP TABLE"></asp:Label> 
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 1155px; top: 131px; position: absolute; height: 62px; width: 282px" Text="Reservation TABLE"></asp:Label> 
           
        <asp:TextBox ID="Txt_Doctor_Name" runat="server" style="z-index: 1; left: 373px; top: 227px; position: absolute; height: 49px"></asp:TextBox>
        <asp:TextBox ID="Txt_Doctor_Surname" runat="server" style="z-index: 1; left: 371px; top: 350px; position: absolute; height: 45px;"></asp:TextBox>
        <asp:TextBox ID="Txt_Doctor_Title" runat="server" style="z-index: 1; left: 370px; top: 456px; position: absolute; height: 39px;"></asp:TextBox>
        <asp:Button ID="Btn_Add_Doctor" runat="server" style="z-index: 1; left: 362px; top: 537px; position: absolute; width: 154px; height: 49px; bottom: 276px" Text="ADD DOCTOR" OnClick="Btn_Add_Doctor_Click" />
        <asp:Button ID="Btn_Remove_Doctor" runat="server" style="z-index: 1; left: 360px; top: 633px; position: absolute; height: 49px; width: 154px" Text="REMOVE DOCTOR" OnClick="Btn_Remove_Doctor_Click" />
        <asp:Label ID="Lbl_Doctor_Error" runat="server" ForeColor="#CC3300" style="z-index: 1; left: 20px; top: 729px; position: absolute; height: 121px; width: 531px; bottom: 84px;" Font-Size="XX-Large"></asp:Label>
        

        <asp:Table ID="Reservation_Table" runat="server" Style="overflow-y: scroll; display: block; z-index: 1; left: 1155px; top: 203px; position: absolute; height: 497px; width: 650px" BorderStyle="Solid" GridLines="Both" CaptionAlign="Top">
        </asp:Table>


        <asp:Table ID="PDP_table" runat="server" Style="overflow-y: scroll; display: block; z-index: 1; left: 617px; top: 200px; position: absolute; height: 496px; width: 495px" BorderStyle="Solid" GridLines="Both" CaptionAlign="Top">
        </asp:Table>
        <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Italic="True" Font-Overline="True" Font-Size="XX-Large" Font-Strikeout="True" Font-Underline="True" ForeColor="#003366" style="background-color:darkblue;color:red; border-bottom-color:gold; border-color:gold;z-index: 1; left: 874px; top: 728px; position: absolute; height: 168px; width: 315px" Text="RESET SYSTEM " OnClick="Button4_Click" />
        <p>
        <asp:Label ID="Lbl_System" runat="server" ForeColor="#CC3300" style="z-index: 1; left: 1251px; top: 742px; position: absolute; height: 150px; width: 597px" Font-Size="XX-Large"></asp:Label>
        

        </p>
    </form>

</body>
</html>
