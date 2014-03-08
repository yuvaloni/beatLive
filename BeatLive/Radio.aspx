<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radio.aspx.cs" Inherits="BeatLive.Radio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
<script>
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
        m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-40464272-2', 'apphb.com');
    ga('send', 'pageview');

</script>
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
            bottom:100px;
            right:0px;
        }
        #add
        {
            position:absolute;
            bottom:0px;
            right:0px;
            
        }
        #add2
        {
            position:absolute;
            bottom:0px;
            right:729px;
            
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

        <div id ="add">
            <!-- BEGIN SMOWTION TAG - 728x90 - DO NOT MODIFY -->
<script type="text/javascript">
    smowtion_size = "728x90";
    smowtion_section = "5425937";
</script>
<script type="text/javascript"
src="http://ads.smowtion.com/ad.js?s=5425937&amp;z=728x90">
</script>
<!-- END SMOWTION TAG - 728x90 - DO NOT MODIFY -->

</div>
<div id ="add2">
    <!-- BEGIN SMOWTION TAG - 728x90 - DO NOT MODIFY -->
<script type="text/javascript">
    smowtion_size = "728x90";
    smowtion_section = "5425937";
</script>
<script type="text/javascript"
src="http://ads.smowtion.com/ad.js?s=5425937&amp;z=728x90">
</script>
<!-- END SMOWTION TAG - 728x90 - DO NOT MODIFY -->

        </div>

        </form>


</body>
</html>
