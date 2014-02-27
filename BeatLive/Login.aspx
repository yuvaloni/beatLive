<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BeatLive.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
        <h1> התחברות </h1>
        שם משתמש:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        ססמה:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
        <br />
    
        
    </form>
</body>
</html>
