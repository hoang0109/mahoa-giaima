<%@ page language="C#" autoeventwireup="true" inherits="Default2, App_Web_ewon3jjt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="vlsm.htm">Chia địa chỉ mạng</a><br />
        <a href="Affine.aspx">Mã hóa sử dụng phương pháp Affine</a><br />
        <a href="Rsa.aspx">Mã hóa sử dụng phương pháp RSA</a><br />
        <a href="Songuyento.aspx">Danh sách các số nguyên tố</a><br />
        <a href="Hill.aspx">Mã hóa sử dụng Hill</a><br />
        <br />
        <br />
        <br />
        <br />
    </div>
        <asp:Button ID="bt_out" runat="server" OnClick="bt_out_Click" Text="Logout" />
    </form>
</body>
</html>
