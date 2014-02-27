<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="BeatLive.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> צור תחנת רדיו חדשה</h1>
        שם התחנה:
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        לוגו:
        <asp:FileUpload ID="FileUpload1" runat="server" />
        jpg בלבד
        <br />
        עיצוב:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        שם משתמש:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        ססמה:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="צור תחנה!" />
    
        <br />
        לאחר לחיצה על הכפתור תפנה לביצוע תשלום באתר פייפל<br />
     לאחר התשלום תוכל להיכנס לממשק הניהול עם הפרטים החדשים שלך</div>
    </form>
</body>
</html>
