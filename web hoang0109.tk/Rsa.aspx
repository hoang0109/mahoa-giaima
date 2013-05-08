<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RSA.aspx.cs" Inherits="RSA" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
     
     
        
            
      
        td
        {
            border-style:inset;
            border-width:1px;
            border-color:Red;
        }
        
        .style1
        {
            width: 100%;
        }
        
        .style3
        {
            width: 949px;
            height: 308px;
        }
        .style12
        {
            height: 36px;
            width: 315px;
        }
        .style13
        {
            height: 36px;
            width: 316px;
        }
        .style14
        {
            height: 53px;
            width: 315px;
        }
        .style17
        {
            height: 54px;
            width: 315px;
        }
        .style19
        {
            height: 35px;
            width: 315px;
        }
        .style20
        {
            height: 35px;
            width: 316px;
        }
        .style21
        {
            height: 53px;
            width: 316px;
        }
        .style22
        {
            height: 54px;
            width: 316px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Phương pháp mã hóa RSA</p>
        <p>
            Số nguyên tố : </p>
    <table class="style3">
        <tr>
            <td class="style19">
                Chọn khóa</td>
            <td class="style20">
                Mã hóa 
                &amp; giải mã</td>
        </tr>
        <tr>
            <td class="style19">
             
                <table class="style1">
                    <tr>
                        <td>
                            P =</td>
                        <td>
                            <asp:TextBox ID="txt_p" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
             
            <td class="style20">
                <table class="style1">
                    <tr>
                        <td>
                            N =</td>
                        <td>
                            <asp:TextBox ID="txt_mahoa_n" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style19">
             
                <table class="style1">
                    <tr>
                        <td>
                            Q=</td>
                        <td>
                            <asp:TextBox ID="txt_q" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
             
            <td class="style20">
                <table class="style1">
                    <tr>
                        <td>
                            E,D =</td>
                        <td>
                            <asp:TextBox ID="txt_mahoa_E" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style19">
             
                <table class="style1">
                    <tr>
                        <td>
                            E =</td>
                        <td>
                            <asp:TextBox ID="txt_e" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            <td class="style20">
                <table class="style1" >
                    <tr>
                        <td>
                            X,Y =</td>
                        <td>
                            <asp:TextBox ID="txt_mahoa_x" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style12">
             
                <asp:Button ID="Button1" runat="server" Text="Tính khóa bí mật" 
                    onclick="Button1_Click" />
            <td class="style13">
                <asp:Button ID="Button2" runat="server" Text="Mã Hóa" onclick="Button2_Click" />
                </td>
        </tr>
        <tr>
            <td class="style14">
                Kết quả chọn khóa</td>
            <td class="style21">
                Kết quả mã hóa &amp; giải mã</td>
        </tr>
        <tr>
            <td class="style17">
                N=p*q=<asp:Label ID="lb_n" runat="server" Text="Label"></asp:Label>
                <br />
                P(n)=(q-1)*(p-1)=<asp:Label ID="lb_pn" runat="server" Text="Label"></asp:Label>
                <br />
                E=<asp:Label ID="lb_E" runat="server" Text="Label"></asp:Label>
                <br />
                d=e^-1 mod n=<asp:Label ID="lb_e0" runat="server" Text="Label"></asp:Label>
                ^-1 mod <asp:Label ID="lb_pn0" runat="server" Text="Label"></asp:Label>
                =&nbsp;<asp:Label ID="lb_d" runat="server" Text="Label"></asp:Label>
                    
                <br />
                    
                    <p runat="server" id="ShowKetQuaNghicDao">
                        </p>
                    
                <br />
                </td>
            <td class="style22">
                bản mã=x^e mod n =<asp:Label ID="lb_mahoa_x" runat="server" Text="Label"></asp:Label>
                ^<asp:Label ID="lb_mahoa_e" runat="server" Text="Label"></asp:Label>
            &nbsp;mod
                <asp:Label ID="lb_mahoa_n" runat="server" Text="Label"></asp:Label>
                &nbsp;=
                <asp:Label ID="lb_banma" runat="server" Text="Label"></asp:Label>
                <br />
                    
                    <p runat="server" id="ShowQuaTrinhMaHoa">
                        </p>
                    
            </td>
        </tr>
    </table>

    </form>
    <!-- GoStats Simple HTML Based Code -->
<a target="_blank" title="Đếm Web miễn phí" href="http://gostats.vn"><img alt="Đếm Web miễn phí" 
src="http://c5.gostats.vn/bin/count/a_1063845/t_3/i_7/counter.png" 
style="border-width:0" /></a>
<!-- End GoStats Simple HTML Based Code -->
    </body>
</html>
