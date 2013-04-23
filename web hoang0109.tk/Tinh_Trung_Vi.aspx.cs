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
                        Response.Write("<script>alert('Loi so sanh ket qua')</script>");
                    }
                }
                catch
                {
                    Response.Write("<script>alert('Loi tinh hieu')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('Loi tinh trung vi')</script>");
            }
        }
        catch{
            Response.Write("<script>alert('Loi nhap ma tran')</script>");
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
}