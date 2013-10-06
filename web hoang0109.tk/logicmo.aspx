<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logicmo.aspx.cs" Inherits="logicmo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Giải bài tập login mờ</title>
    <style>

        .table_456456{            margin-right: auto;
                            border-style:solid;
                            border-color:red;
            border-width:1px;
        }
        .td_35345{
            border-style:solid;
            border-width:1px;
             border-color:red;
            }
        .td {
            border-style:solid;
            border-width:1px;
             border-color:red;
        }
      

    </style>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
    <script type="text/javascript">
        function bt_thucong_Click() {
            window.location.assign("http://google.com.vn");
        }
        function selectValue() {

            if (document.getElementById("rd_console_1_0").checked == true) {

                document.getElementById("console1").innerText = "Nhập A'";

            }
            if (document.getElementById("rd_console_1_1").checked == true) {

                document.getElementById("console1").innerText = "Nhập B'";

            }
            if (document.getElementById("rd_console_1_2").checked == true) {

                document.getElementById("console1").innerText = "Nhập C'";

            }
            if (document.getElementById("rd_console_2_0").checked == true) {

                document.getElementById("console2").innerText = "Nhập A'";

            }
            if (document.getElementById("rd_console_2_1").checked == true) {

                document.getElementById("console2").innerText = "Nhập B'";

            }
            if (document.getElementById("rd_console_2_2").checked == true) {

                document.getElementById("console2").innerText = "Nhập C'";

            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td class="td">
                Nhập A
            </td>
            <td class="td">
                <asp:TextBox ID="txt_a" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="td">
                Nhập B
            </td>
            <td class="td">
                <asp:TextBox ID="txt_b" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="td">
                Nhập C
            </td>
            <td class="td">
                <asp:TextBox ID="txt_c" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="td">
                Nhập Lệnh 
            </td>
            <td class="td">
                <table>
                    <tr>
                        <td> If</td>
                        <td>
                            <asp:RadioButtonList ID="rd_console_1" runat="server" onchange="return selectValue();">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            </asp:RadioButtonList> 

                        </td>
                        <td>
                            <asp:RadioButtonList ID="rd_console_andor" runat="server">
                            <asp:ListItem>and</asp:ListItem>
                            <asp:ListItem>or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                             <asp:RadioButtonList ID="rd_console_2" runat="server" onchange="return selectValue();">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                             </asp:RadioButtonList>
                        </td>
                        <td>
                            then
                        </td>
                        <td>
                              <asp:RadioButtonList ID="rd_console_3" runat="server">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                 </asp:RadioButtonList>
                        </td>
                        <td>

                        </td>
                    </tr>
                </table>
              
              
            </td>

        </tr>
        <tr>
            <td id="console1" runat="Server"  class="td"> </td>
            <td id="console1_text" runat="Server"  class="td">
                <asp:TextBox ID="txt_console1" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td id="console2" runat="Server"  class="td"> </td>
            <td id="console2_text" runat="Server"  class="td">
                <asp:TextBox ID="txt_console2" runat="server"></asp:TextBox> </td>
        </tr>
        
        <tr>
            
            <td class="td">
                Kiểu suy diễn
            </td>
            <td class="td">
                <asp:RadioButtonList ID="rd_kieusuydien" runat="server">
                    <asp:ListItem Selected="True">MinMax</asp:ListItem>
                    <asp:ListItem Value="TichCucDai">Tích Cực Đại</asp:ListItem>
                </asp:RadioButtonList>
            </td>

        </tr>
        
        <tr>
            
             <td class="td"><asp:Button ID="bt_tinhtaptrung" runat="server" Text="Tinh Tập trung.." OnClick="bt_tinhtaptrung_Click" /></td>
            <td class="td">
                <asp:RadioButtonList ID="rd_tinhtaptrung" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                </asp:RadioButtonList></td>
            
            </tr>
         <tr>
            
             
            <td colspan="2" style="text-align:center" id="td">
                <asp:Button ID="bt_caculator" runat="server" Text="Tính" Height="43px" Width="104px" OnClick="bt_caculator_Click" />
            </td>
            

        </tr>
    </table>
        <div id="showketqua" runat="server">

        </div>
    </div>
    </form>
</body>
</html>
