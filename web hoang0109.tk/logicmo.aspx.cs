using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logicmo : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bt_caculator_Click(object sender, EventArgs e)
    {
        showketqua.InnerHtml = null;
        string[] A = Suly.Split_String(txt_a.Text, ';');
        string[] B = Suly.Split_String(txt_b.Text, ';');
        string[] C = Suly.Split_String(txt_c.Text, ';');
        string[] D = Suly.Split_String(txt_console1.Text, ';');
        string[] F = Suly.Split_String(txt_console2.Text, ';');
        string[,] M1 = null;
        string[,] M2 = null;
        string[] N1 = null;
        string[] N2 = null;
        string[] ketqua = null;
        string congthuc = String.Format("Công thức phép tính : If {0} {1} {2} then {3}", rd_console_1.SelectedValue, rd_console_andor.SelectedValue, rd_console_2.SelectedValue, rd_console_3.SelectedValue);
        showketqua.InnerHtml = "<h1><p> " + congthuc + " <p></h1>";
        if (rd_kieusuydien.SelectedValue=="MinMax")
            {
                try
                {
                    if (rd_console_1.SelectedValue == "A")
                    {
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M1 = Suly.Logicmo_Mxy(A, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M1 = Suly.Logicmo_Mxy(A, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }
                    if (rd_console_1.SelectedValue == "B")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M1 = Suly.Logicmo_Mxy(B, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M1 = Suly.Logicmo_Mxy(B, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }
                    if (rd_console_1.SelectedValue == "C")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M1 = Suly.Logicmo_Mxy(C, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M1 = Suly.Logicmo_Mxy(C, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }

                    if (rd_console_2.SelectedValue == "A")
                    {
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M2 = Suly.Logicmo_Mxy(A, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M2 = Suly.Logicmo_Mxy(A, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                    if (rd_console_2.SelectedValue == "B")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M2 = Suly.Logicmo_Mxy(B, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M2 = Suly.Logicmo_Mxy(B, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                    if (rd_console_2.SelectedValue == "C")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M2 = Suly.Logicmo_Mxy(C, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M2 = Suly.Logicmo_Mxy(C, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                }
                catch
                {
                    Response.Write("<script>alert('Lỗi rồi : Xem lại xem đã nhập lệnh chưa');</script>");
                }
            }
            if (rd_kieusuydien.SelectedValue == "TichCucDai")
                {
                    try
                {
                    if (rd_console_1.SelectedValue == "A")
                    {
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M1 = Suly.Logicmo_Tichxy(A, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M1 = Suly.Logicmo_Tichxy(A, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }
                    if (rd_console_1.SelectedValue == "B")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M1 = Suly.Logicmo_Tichxy(B, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M1 = Suly.Logicmo_Tichxy(B, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }
                    if (rd_console_1.SelectedValue == "C")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M1 = Suly.Logicmo_Tichxy(C, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M1 = Suly.Logicmo_Tichxy(C, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M1) + "</table></br>";
                        }
                    }

                    if (rd_console_2.SelectedValue == "A")
                    {
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M2 = Suly.Logicmo_Tichxy(A, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M2 = Suly.Logicmo_Tichxy(A, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_AC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                    if (rd_console_2.SelectedValue == "B")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M2 = Suly.Logicmo_Tichxy(B, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "C")
                        {
                            M2 = Suly.Logicmo_Tichxy(B, C);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_BC = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                    if (rd_console_2.SelectedValue == "C")
                    {
                        if (rd_console_3.SelectedValue == "A")
                        {
                            M2 = Suly.Logicmo_Tichxy(C, A);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CA = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                        if (rd_console_3.SelectedValue == "B")
                        {
                            M2 = Suly.Logicmo_Tichxy(C, B);
                            showketqua.InnerHtml = showketqua.InnerHtml + "<h2> M_CB = </h2>" + "<table class='table_456456'>" + Suly.inmatrix(M2) + "</table></br>";
                        }
                    }
                }
                catch
                {
                    Response.Write("<script>alert('Lỗi rồi : Xem lại xem đã nhập lệnh chưa');</script>");
                }
            }
            //
            try
            {
                N1 = Suly.logicmo_AB(D, M1);
                N2 = Suly.logicmo_AB(F, M2);
                showketqua.InnerHtml = showketqua.InnerHtml + "<p>" + rd_console_3.SelectedValue + "'" + rd_console_1.SelectedValue + "' = " + "{" + Suly.inarr(N1) + "}</p></br>";
                showketqua.InnerHtml = showketqua.InnerHtml + "<p>" + rd_console_3.SelectedValue + "'" + rd_console_2.SelectedValue + "' = " + "{" + Suly.inarr(N2) + "}</p></br>";
            }
            catch
            {

                Response.Write("<script>alert('Lỗi rồi : Xem lại xem đã nhập A` B` C` chưa');</script>");
            }
            try
            {
                ketqua = Suly.logicmo_andor(N1, N2, rd_console_andor.SelectedValue);
                showketqua.InnerHtml = showketqua.InnerHtml + "<p>" + rd_console_3.SelectedValue + "' = " + "{" + Suly.inarr(ketqua) + "}</p></br>";
            }
            catch
            {

                Response.Write("<script>alert('Lỗi rồi : Xem lại xem đã chọn and or chưa');</script>");
            }
        }
        
        
        
       
    
    protected void bt_tinhtaptrung_Click(object sender, EventArgs e)
    {
        try
        {
            showketqua.InnerHtml = null;
            string[] A = null;
            if (rd_tinhtaptrung.Text == "A")
            {
                A = Suly.Split_String(txt_a.Text, ';');
            }
            if (rd_tinhtaptrung.Text == "B")
            {
                A = Suly.Split_String(txt_b.Text, ';');
            }
            if (rd_tinhtaptrung.Text == "C")
            {
                A = Suly.Split_String(txt_c.Text, ';');
            }
            string[] tinhtaptrung = Suly.TinhTapTrung(A, true);
            string[] tinhcogian = Suly.TinhCoGian(A, true);
            string[] tinhnhanmanh = Suly.TinhNhanhManh(A, true);
            showketqua.InnerHtml = showketqua.InnerHtml + "<p> Tinh Tập Trung </p> " + rd_tinhtaptrung.Text + " = {";
            for (int i = 0; i < tinhtaptrung.Length; i++)
            {
                showketqua.InnerHtml = showketqua.InnerHtml + tinhtaptrung[i] + ";";
            }
            showketqua.InnerHtml = showketqua.InnerHtml + " }</br>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<p> Tinh Co Giãn </p> " + rd_tinhtaptrung.Text + " = {";
            for (int i = 0; i < tinhcogian.Length; i++)
            {
                showketqua.InnerHtml = showketqua.InnerHtml + tinhcogian[i] + ";";
            }
            showketqua.InnerHtml = showketqua.InnerHtml + " }</br>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<p> Tinh Nhấn Mạnh </p> " + rd_tinhtaptrung.Text + " = {";
            for (int i = 0; i < tinhcogian.Length; i++)
            {
                showketqua.InnerHtml = showketqua.InnerHtml + tinhnhanmanh[i] + ";";
            }
            showketqua.InnerHtml = showketqua.InnerHtml + " }</br>";
        }
        catch (Exception exx)
        {
            Response.Write("<script>alert('loi roi nha kiem tra lai di ma loi la "+exx+"');</script>");
                
            
        }
        
    }

}