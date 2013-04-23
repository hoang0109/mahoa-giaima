<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tinh_Trung_Vi.aspx.cs" Inherits="Tinh_Trung_Vi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tinh trung vi</title>

    <link rel="stylesheet" type="text/css" href="/css.css"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Tính trung vị của ma trận ( môn xử lý ảnh)</p>
    <p> Nhập ma trận: 
        <asp:TextBox ID="txt_matrix" runat="server"></asp:TextBox>
        </p>
    <p> Nhập cấp của ma trận Số hàng:<asp:TextBox ID="txt_hang" runat="server"></asp:TextBox>
&nbsp;Số cột:
        <asp:TextBox ID="txt_cot" runat="server"></asp:TextBox>
        </p>
    <p>Nhập (-) :<asp:TextBox ID="txt_gioihan" runat="server"></asp:TextBox>
        &nbsp;K:<asp:TextBox ID="txt_k" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="bt_tinhtoan" runat="server" Text="Tính trung vị" OnClick="bt_tinhtoan_Click" />
        <asp:Button ID="bt_tinhtrungbinh" runat="server" Text="Tính trung bình" OnClick="bt_tinhtrungbinh_Click" />
        <asp:Button ID="bt_tinhtrungbinh_theok" runat="server" Text="Tính trung bình theo k" OnClick="bt_tinhtrungbinh_theok_Click" />
    </div>
        <div id="showketqua" runat="server">
        </div>

    </form>
</body>
</html>
