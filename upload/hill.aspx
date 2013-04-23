<%@ page language="C#" autoeventwireup="true" inherits="hill, App_Web_l05oqfda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
</body>
</html>
