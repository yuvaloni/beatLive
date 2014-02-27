<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radio.aspx.cs" Inherits="BeatLive.Radio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <style type="text/css">

        #i {
            height: 96px;
            width: 307px;
            position:absolute;
            top:0px;
            right:0px;
        }
        #b1
        {
            position:absolute;
            width:100%;
            height:15px;
            top:110px;

        }
        #b2
        {
            position:absolute;
            width:100%;
            height:15px;
            top: 286px;
        }
        #player
        {
            position:absolute;
            left:38%;
            top:130px;
        }
        #about 
        {
            position:absolute;
            top:291px;
            left:0px;
        }
        #news
        {
            position:absolute;
            top:291px;
            right:0px;
        }
        #ad
        {
            position:absolute;
            bottom:0px;
            right:0px;
        }

    </style>
    <title></title>
</head>
<body bgcolor="<%gcolor(); %>">
    <form id="form1" runat="server">
    <div>

                   <font color="<% gocolor(); %>" size="80px"> <%Response.Write(Request.QueryString["name"]); %></font>

                         <img id="i" src =" <%Response.Write("/"+Request.QueryString["name"]+"/Logo.jpg");  %>"/>
                        <br />
                     <img id="b1" src="<%gocolor(); %>.jpg" />
                   <br />
                    <object id="player">
                        <param name="movie" value="/player.swf?song=<%generate(); %>" />
                    </object>
                   <br />
                             <img id="b2" src="<%gocolor(); %>.jpg" />
    </div>
        <br />

                <div id="about"><font color="<% gocolor(); %>" size="80px"><b>אודותינו:</b></font><br /><font color="<%gocolor(); %>" size="30px"><%gabout(); %></font></div>
                <div id="news"><font color="<% gocolor(); %>" size="80px"><b>חדשות:</b></font><br/><font color="<%gocolor(); %>" size="30px"><%gnews(); %></font></div>
        <div id ="ad" dir="rtl"><font color="<%gocolor(); %>" soze="12px"><a href="index.html">מופעל ע"י Beat.Live</a></font></div>
        </form>

</body>
</html>
