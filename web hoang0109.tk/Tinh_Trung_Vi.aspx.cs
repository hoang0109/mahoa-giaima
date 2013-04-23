using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tinh_Trung_Vi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Convert.ToString(Session["id"])))
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void bt_tinhtoan_Click(object sender, EventArgs e)
    {
        int[,] matrix1 = null ;
        int[,] trungvi = null;
        int[,] hieu = null;
        int[,] ketqua = null;
        try{

       matrix1 = Suly.StringToMatrix(txt_matrix.Text, Convert.ToInt32(txt_hang.Text), Convert.ToInt32(txt_cot.Text));
            try
            {
               trungvi  = Suly.tinhtrungvi(matrix1);
                try
                {
                    hieu = Suly.hieu2matran_trungvi(matrix1, trungvi);
                    try
                    {
                        ketqua = Suly.trungvi_ketqua(matrix1, trungvi, hieu, Convert.ToInt32(txt_gioihan.Text));
                       
                    }
                    catch
                    {
                        Response.Write("<script>alert('Lỗi so sánh kết quả')</script>");
                    }
                }
                catch
                {
                    Response.Write("<script>alert('lỗi tính hiệu')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('lỗi tính trung vị')</script>");
            }
        }
        catch{
            Response.Write("<script>alert('Lỗi nhập ma trận')</script>");
        }
        showketqua.InnerHtml = "<p>Ma tran goc I(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(matrix1) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>Trung Vi TV(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(trungvi) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>I(p) - TV(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(hieu) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>I'(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(ketqua) + "</table><br/>";
        
       
        
    }
    protected void bt_tinhtrungbinh_Click(object sender, EventArgs e)
    {
        int[,] matrix = null;
        int[,] trungbinh = null;
        int[,] hieu = null;
        int[,] ketqua = null;
        try
        {
            matrix = Suly.StringToMatrix(txt_matrix.Text, Convert.ToInt32(txt_hang.Text), Convert.ToInt32(txt_cot.Text));
        }
        catch
        {
            Response.Write("<script>alert('Lỗi nhập ma trận')</script>");
        }
        try
        {
            trungbinh = Suly.tinhtrungvitrungbinh(matrix);
        }
        catch
        {

            Response.Write("<script>alert('Lỗi tính trung bình')</script>");
        }
        try
        {
            hieu = Suly.hieu2matran_trungvi(matrix, trungbinh);
        }
        catch
        {
            
           Response.Write("<script>alert('lỗi tính hiệu')</script>");
        }
        try 
	    {	        
		    ketqua = Suly.trungvi_ketqua(matrix, trungbinh, hieu, Convert.ToInt32(txt_gioihan.Text));
	    }
	    catch
	    {
		Response.Write("<script>alert('Lỗi tính kết quả')</script>");
	    }
        showketqua.InnerHtml = "<p>Ma tran goc I(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(matrix) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>Trung Bình TB(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(trungbinh) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>I(p) - TB(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(hieu) + "</table><br/>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<p>I'(p)=</p>";
        showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(ketqua) + "</table><br/>";
    }
    protected void bt_tinhtrungbinh_theok_Click(object sender, EventArgs e)
    {
        int k = 0;
        int[,] matrix = null;
        int[,] trungbinh_k = null;
        int[,] hieu = null;
        int[,] ketqua = null;
        try
        {
            k =Convert.ToInt32(txt_k.Text);
            
            try
            {
                matrix = Suly.StringToMatrix(txt_matrix.Text, Convert.ToInt32(txt_hang.Text), Convert.ToInt32(txt_cot.Text));
            }
            catch
            {
                Response.Write("<script>alert('Lỗi nhập ma trận')</script>");
            }
            try
            {
                trungbinh_k = Suly.tinhtrungvitrungbinh_theoK(matrix,k);
            }
            catch
            {

                Response.Write("<script>alert('Lỗi tính trung bình')</script>");
            }
            try
            {
                hieu = Suly.hieu2matran_trungvi(matrix, trungbinh_k);
            }
            catch
            {

                Response.Write("<script>alert('lỗi tính hiệu')</script>");
            }
            try
            {
                ketqua = Suly.trungvi_ketqua(matrix, trungbinh_k, hieu, Convert.ToInt32(txt_gioihan.Text));
            }
            catch
            {
                Response.Write("<script>alert('Lỗi tính kết quả')</script>");
            }
            showketqua.InnerHtml = "<p>Ma tran goc I(p)=</p>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(matrix) + "</table><br/>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<p>Trung Bình TB_k(p)=</p>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(trungbinh_k) + "</table><br/>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<p>I(p) - TB_k(p)=</p>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(hieu) + "</table><br/>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<p>I'(p)=</p>";
            showketqua.InnerHtml = showketqua.InnerHtml + "<Table>" + Suly.inmatrix(ketqua) + "</table><br/>";
        }
        catch
        {

            Response.Write("<script>alert('Bạn phải nhập K')</script>");
        }
       
    }
}