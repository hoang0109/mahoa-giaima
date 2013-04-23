<%@ page language="C#" autoeventwireup="true" inherits="login, App_Web_l05oqfda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ID<asp:TextBox ID="txt_user" runat="server"></asp:TextBox>
        <br />
        Pass<asp:TextBox ID="txt_pass" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="login" />
    
    </div>
        <asp:Label ID="ketqua" runat="server" Text="ketqua"></asp:Label>
    </form>
</body>
</html>
