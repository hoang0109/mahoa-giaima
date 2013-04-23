using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Convert.ToString(Session["id"])))
        {
            Response.Redirect("login.aspx");
        }
    }    
    protected void bt_maxhoa_Click(object sender, EventArgs e)
    {
        try
        {
            List<int> x = Suly.TextToInt(txt_text.Text);
            int hangmatran = Convert.ToInt16(txt_capmatran.Text);
            int[,] matrix = Suly.StringToMatrix(txt_matrankhoa.Text, hangmatran);
            List<int> y = Suly.ykxmodn(matrix, x, 26);
            ketqua.InnerHtml = "<p>Chuỗi dạng số : " + Suly.ListToHtml(x) + "</p>";
            ketqua.InnerHtml = "<p> Y=KxModn = ";
            ketqua.InnerHtml = ketqua.InnerHtml + Suly.ListToHtml(y);
            ketqua.InnerHtml =ketqua.InnerHtml + "</p>";
            ketqua.InnerHtml = ketqua.InnerHtml + "<p> Đổi xang chữ cái ";
            List<string> xx = Suly.IntToText(y);
            ketqua.InnerHtml = ketqua.InnerHtml + Suly.ListToHtml(xx);
            ketqua.InnerHtml = ketqua.InnerHtml + "</p>";
            ketqua.InnerHtml = ketqua.InnerHtml + "<p> k^-1= 1/det(a)*k^* </p>";
            ketqua.InnerHtml = ketqua.InnerHtml + "<p> det(k) ="+Suly.det(matrix,hangmatran)+"</p>";
          
        }
        catch (Exception)
        {

            ketqua.InnerHtml = "<p>Kiem tra qua trinh nhap</p>";
        }
        
   

    }
}