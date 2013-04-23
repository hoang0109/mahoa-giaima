<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Affine.aspx.cs" Inherits="WebHoc._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MaHoa-Giai Ma theo phuong phap Affine</title>
    <style type="text/css">
        .auto-style1 {
            width: 474px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
         
    
        <center><b><i style="font-family: 'times New Roman', Times, serif; font-size: 14px; color: #CC6600;">Mã Hóa Và Giải Mã Theo Phương Pháp Affine</b></i></center></div>
   
    
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
        <div>
      <p>  <asp:Label ID="Label1" runat="server" Text="Mã Hóa Affine"></asp:Label></p>
      <p> Gia Tri Mod <asp:TextBox ID="k_mod" runat="server"></asp:TextBox> </p>
      <p> Nhập Khóa K _A <asp:TextBox ID="k_a" runat="server" Height="31px" Width="146px"></asp:TextBox> </p>
      <p> Nhập Khóa K _B <asp:TextBox ID="k_b" runat="server"></asp:TextBox> </p>
      <p> Nhập Chuỗi cần mã hóa <asp:TextBox ID="chuoimahoa" runat="server"></asp:TextBox> </p>
            <asp:Button ID="Button1" runat="server" Text="Ma Hoa" OnClick="Button1_Click" /> 
            <asp:Button ID="Button2" runat="server" Text="Giai Ma" OnClick="Button2_Click" />
            </div>
        <div>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Bai Giai"></asp:Label></p>
            <p>
                <asp:Label ID="KhoaK" runat="server" Text=""></asp:Label></p>
            <p>
                <asp:Label ID="Chuoi" runat="server" Text=""></asp:Label></p>
            <p>
                <asp:Label ID="Chuoidangso" runat="server" Text=""></asp:Label></p>
            <p>
                <asp:Label ID="kqConverChuoi" runat="server" Text=""></asp:Label></p>
            <p>
                <asp:Label ID="KetQua" runat="server" Text=""></asp:Label></p>
            <p>
                <asp:Label ID="DapAn" runat="server" Text=""></asp:Label></p>
        </div>
            </td>
            <td style="border: 1px dashed #000000">
                <div>
                    <p>
                <asp:Label ID="KetQuaNghicDao" runat="server" Text=""></asp:Label></p>
                    
                    <p runat="server" id="ShowKetQuaNghicDao">
                        </p>
                </div>
                </td>
        </tr>
    </table>
   </form>
    
</body>
</html>
