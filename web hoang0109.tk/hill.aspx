<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hill.aspx.cs" Inherits="hill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link rel="stylesheet" type="text/css" href="css.css">

    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Mật mã Hill<br />
    <table border="1" >
    	<tr>
    		<td>Chuỗi cần mã hóa</td>
            <td>
                <asp:TextBox ID="txt_text" runat="server"></asp:TextBox>
            </td>
    	</tr>
    	<tr>
    		<td>Ma trận khóa</td>
            <td>
                <asp:TextBox ID="txt_matrankhoa" runat="server"></asp:TextBox>
            </td>
    	</tr>
    	
    	<tr>
    		<td>Ma trận cấp</td>
            <td>
                 <asp:TextBox ID="txt_capmatran" runat="server"></asp:TextBox></td>
    	</tr>
    	
    </table>
         <asp:Button ID="bt_maxhoa" runat="server" Text="Mã hóa" OnClick="bt_maxhoa_Click" />
    </div>
    </form>
    <p runat="server" id="ketqua">
                        </p>
    <!-- GoStats Simple HTML Based Code -->
<a target="_blank" title="Đếm Web miễn phí" href="http://gostats.vn"><img alt="Đếm Web miễn phí" 
src="http://c5.gostats.vn/bin/count/a_1063845/t_3/i_7/counter.png" 
style="border-width:0" /></a>
<!-- End GoStats Simple HTML Based Code -->
</body>
</html>
