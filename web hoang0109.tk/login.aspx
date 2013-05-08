<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
    <!-- GoStats Simple HTML Based Code -->
<a target="_blank" title="Đếm Web miễn phí" href="http://gostats.vn"><img alt="Đếm Web miễn phí" 
src="http://c5.gostats.vn/bin/count/a_1063845/t_3/i_7/counter.png" 
style="border-width:0" /></a>
<!-- End GoStats Simple HTML Based Code -->
</body>
</html>
