<%@ Page Language="C#" AutoEventWireup="true" CodeFile="balo.aspx.cs" Inherits="balo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            border-collapse: collapse;
            height: 1px;
            float: left;
            border: 1px solid #000000;
        }
        .auto-style2 {
            width: 50%;
        }
        .auto-style3 {
            width: 50%;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            width: 50%;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>Mã Hóa</td>
            </tr>
            <tr>
                <td class="auto-style2">Dãy siêu tăng (Eg.10,11,13,14,15,16):
        <asp:TextBox ID="txt_daysieutang" runat="server"></asp:TextBox>
                </td>
                <td>Khóa công khai (eg 1,3,3,4):<asp:TextBox ID="txt_khoacongkhai" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">P=<asp:TextBox ID="txt_p" runat="server"></asp:TextBox>
                </td>
                <td>Bản rõ (11111):<asp:TextBox ID="txt_banro" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">A=<asp:TextBox ID="txt_a" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="bt_mahoa" runat="server" Text="Mã Hóa bản rõ" OnClick="bt_mahoa_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Tính khóa công khai</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="bt_khoacongkhai" runat="server" OnClick="bt_khoacongkhai_Click" Text="Tính khóa công khai" />
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td>Giải mã</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Bản mã :
                    <asp:TextBox ID="txt_banma" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                 

                    <asp:Button ID="bt_giaima" runat="server" Text="Giải mã" OnClick="bt_giaima_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                 

                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <div id="Showketqua" runat="Server"></div>
</form>
    <!-- GoStats Simple HTML Based Code -->
<a target="_blank" title="Đếm Web miễn phí" href="http://gostats.vn"><img alt="Đếm Web miễn phí" 
src="http://c5.gostats.vn/bin/count/a_1063845/t_3/i_7/counter.png" 
style="border-width:0" /></a>
<!-- End GoStats Simple HTML Based Code -->
</body>
</html>
