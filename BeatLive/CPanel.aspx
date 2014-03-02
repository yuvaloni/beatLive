<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CPanel.aspx.cs" Inherits="BeatLive.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div dir="rtl"><font size="30px">כתובת הרדיו שלך: <% Response.Write("http://beatlive.apphb.com/Radio.aspx?name="+(string)Session["id"]); %> </font></div>
        <h2>העלאת שירים</h2>
        </br>
        שם השיר:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        אמן:<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        הקובץ:<asp:FileUpload  ID="FileUpload1" runat="server" />
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
            *צוות האתר אינו אחראי לתוכן שמועלה ע"י המשתמשים
        <br />
        <br />
        <br />
        <br />
        <br />
        <h1>אודות התחנה:</h1>
        </br>
        (מקסיםמום 400 תווים)
        </br>
        <asp:TextBox ID="TextBox3" runat="server" Height="191px" TextMode="MultiLine" Width="610px"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click"/>
        <br />
        <br />
        <h1>חדשות:</h1>
        <br/>
        (מקסימום 400 תווים)
         <br/>
        <asp:TextBox ID="TextBox4" runat="server" Height="191px" TextMode="MultiLine" Width="610px"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
