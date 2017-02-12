<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation_Screen.aspx.cs" Inherits="WebApplication1.Reservation_Screen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .picCircle {
           position: absolute;
           max-height: 200px;
           max-width: 230px;
           overflow: hidden;
           border-radius: 20%;
           -webkit-backface-visibility: hidden;
           -moz-backface-visibility: hidden;
           -webkit-transform: translate3d(0, 0, 0);
           -moz-transform: translate3d(0, 0, 0);
            width: 248px;
            height: 221px;

        }
        /*GROW*/
         .RightArrow {
         transform: scale(1);
        -webkit-transition: all .85s ease;
        -moz-transition: all .85s ease;
        -o-transition: all .85s ease;
        -ms-transition: all .85s ease;
        transition: all .85s ease;
         }
         .RightArrow:hover {
 
        -webkit-transform:scale(1.1);
        -moz-transform:scale(1.1);
        -ms-transform:scale(1.1);
        -o-transform:scale(1.1);
        transform:scale(1.1);
        }

    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1"  runat="server" Height="78px" Width="1944px" src="http://www.dreamtemplate.com/dreamcodes/bg_images/color/c4.jpg" style="margin-left: -10px; margin-top: -25px;"/>
        <asp:Image ID="Image3"  runat="server" Height="78px" Width="1944px" src="http://www.dreamtemplate.com/dreamcodes/bg_images/color/c4.jpg" style="margin-left: -10px; margin-top: 250px;"/> 
        <asp:Image ID="Image4"  runat="server" Height="78px" Width="1944px" src="http://www.dreamtemplate.com/dreamcodes/bg_images/color/c4.jpg" style="margin-left: -10px; margin-top: 150px;"/>
        <asp:Image ID="Image2" runat="server" src=" http://hd-wall-papers.com/images/wallpapers/website-background/website-background-17.jpg" style="margin-left: -10px; margin-top: -10px; top: 58px; left: -9px; position: absolute; width: 1973px; height: 22px;"/>
 
   

        
 
    <asp:Label ID="Protection" runat="server" style="top: 862px; left: 592px; position: absolute; height: 19px; width: 781px; margin-top: 0px;" Text="Sitede yer alan tüm içeriğin hakları saklıdır. <b>2017 © AB</b> - Site Sahibi izni olmaksızın kullanılamaz. Bu bir <b>AtaBerk</b> yapımıdır."></asp:Label>

        <div class="grow picCircle" style =" top: 140px; left: 1010px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton1" runat="server" Height="222px"  Width="248px" src="http://weknowyourdreams.com/images/eye/eye-03.jpg" alt="" OnClick="ImageButton1_Click2"/>
        </div>
        <div class="grow picCircle" style =" top: 140px; left: 660px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton2" runat="server" Height="222px"  Width="248px" src="http://wdy.h-cdn.co/assets/cm/15/09/54eb698451151_-_9-things-you-didn-t-know-about-your-ears-mdn.jpg" alt="" OnClick="ImageButton1_Click1"/>
        </div>
        <div class="grow picCircle" style =" top: 362px; left: 1010px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton3" runat="server" Height="222px"  Width="248px" src="http://i.milliyet.com.tr/YeniAnaResim/2015/03/30/fft99_mf5467758.Jpeg" alt="" OnClick="ImageButton1_Click4"/>
        </div>
        <div class="grow picCircle" style =" top: 362px; left: 660px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton4" runat="server" Height="222px"  Width="248px" src="http://www.fatihdis.com/en/images/djmediatools/32-genel-dis-hekimligi/10.jpg" alt="" OnClick="ImageButton1_Click3"/>
        </div>
        <div class="grow picCircle" style =" top: 584px; left: 660px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton5" runat="server" Height="222px"  Width="248px" src="http://i48.tinypic.com/24w4oc7.jpg" alt="" OnClick="ImageButton1_Click3"/>
        </div>
        <div class="grow picCircle" style =" top: 584px; left: 1010px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton6" runat="server" Height="222px"  Width="248px" src=" http://guzelliksalonlari.tk/wp-content/uploads/sa%C5%9Fkayna%C4%9F%C4%B1.jpg" alt="" OnClick="ImageButton1_Click3"/>                       
        </div>        
        <div class="grow picCircle" style =" top: 362px; left: 1360px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton7" runat="server" Height="222px"  Width="248px" src="http://www.1ciltbakimi.com/wp-content/uploads/2016/04/B%C3%BCy%C3%BCk-Sivilce-Nas%C4%B1l-Ge%C3%A7er.png" alt="" OnClick="ImageButton1_Click3"/>                       
        </div> 
       <div class="grow picCircle" style =" top: 362px; left: 310px">
        <asp:ImageButton CssClass="RightArrow" class="img-responsive"  ID="ImageButton8" runat="server" Height="222px"  Width="248px" src="https://supplementpolice.com/wp-content/uploads/2014/05/Common-Cold.jpg" alt="" OnClick="ImageButton1_Click3"/>                       
        </div> 
        
    </div>                 
    </form>
    </body>
</html>
