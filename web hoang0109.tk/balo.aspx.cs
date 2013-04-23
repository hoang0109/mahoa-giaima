using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class balo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Convert.ToString(Session["id"])))
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void bt_mahoa_Click(object sender, EventArgs e)
    {
            string khoacongkhai = txt_khoacongkhai.Text;
	        string[] khoacongkhai_ar =khoacongkhai.Split(new Char[] {','});
	        int[] khoacongkhai_ar_int = new int[khoacongkhai_ar.Length];
	
	        for (int i=0;i<khoacongkhai_ar.Length;i++)
	        {
	            khoacongkhai_ar_int[i] = Convert.ToInt32(khoacongkhai_ar[i]);
	        }

        Showketqua.InnerText = "Kết quả mã hóa bản rõ:";
        Showketqua.InnerText = Showketqua.InnerText + Suly.mahoa_banro_balo(txt_banro.Text, khoacongkhai_ar_int);
    }
    protected void bt_giaima_Click(object sender, EventArgs e)
    {
            try
        {
	         int p=Convert.ToInt32(txt_p.Text);
	            int a = Convert.ToInt32(txt_a.Text);
	            int banma = Convert.ToInt32(txt_banma.Text);
	            int c = (Suly.Tinh_Nghich_Dao(p, a)*banma)%p;
	        int[] khoacongkhai = Suly.stringtoarrayint(txt_daysieutang.Text);
	        string[,] matrix = Suly.giaima_banma_balo(c, khoacongkhai);
	        string html = Suly.inmatrix(matrix);
            Showketqua.InnerHtml = "c=a^-1*y mod p = " +c;
                Showketqua.InnerHtml =Showketqua.InnerHtml+"<table>"+ html+"</table>";
        }
         catch (System.Exception ex)
         {
             Showketqua.InnerText = ex.ToString();
         }

    }
    protected void bt_khoacongkhai_Click(object sender, EventArgs e)
    {
        try
        {
            int p = Convert.ToInt32(txt_p.Text);
            int a = Convert.ToInt32(txt_a.Text);
            string daysieutang = txt_daysieutang.Text;
            string[] daysieutang_ar = daysieutang.Split(new Char[] { ',' });
            int[] daysieutang_ar_int = new int[daysieutang_ar.Length];

            for (int i = 0; i < daysieutang_ar.Length; i++)
            {
                daysieutang_ar_int[i] = Convert.ToInt32(daysieutang_ar[i]);
            }
            int[] macongkhai = Suly.khoacongkhai_balo(daysieutang_ar_int, p, a);
            Showketqua.InnerText = "Mã công khai";
            foreach (var s in macongkhai)
            {
                Showketqua.InnerText = Showketqua.InnerText + s + ",";
            }
        }
        catch (System.Exception ex)
        {
            Showketqua.InnerText = "Kiểm tra dữ liệu nhập vào"+ex;
        }
    }
}