using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



    public partial class RSA : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // tính toán khóa bí mật
        protected void Button1_Click(object sender, EventArgs ee)
        {
              int p, q, pn, e;
           //tính toán các giá trị
            q = Convert.ToInt32(txt_q.Text);
            p = Convert.ToInt32(txt_p.Text);
            e = Convert.ToInt32(txt_e.Text);
            pn=((p - 1) * (q - 1));
            lb_n.Text = (p * q).ToString();
            lb_pn.Text = pn.ToString();
            lb_E.Text = e.ToString();
            lb_d.Text = Suly.Tinh_Nghich_Dao(pn, e).ToString();
            lb_e0.Text = lb_E.Text;
            lb_pn0.Text = lb_pn.Text;

            // ghi quá trình tính nghịch đảo ra màn hình
            
            int[,] nghicdao =Suly.TinhNghichDao(pn,e);

            ShowKetQuaNghicDao.InnerHtml = "<table><tr><td>Xi</td><td>Ui</td><td>Vi</td><td>Yi</td></tr>";
            ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml +Suly.inmatrix(nghicdao,4)+"</table>" ;
            //for (int i = 0; i < 9; i++)
            //{
            //    ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + "<p>";
            //    for (int j = 0; j < 4; j++)
            //    {
            //        ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + nghicdao[i, j] + ",";

            //        breakk = nghicdao[i, 0];
            //        if (breakk < 0 || breakk == 0)
            //        {
            //            break;
            //            ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + Suly.Tinh_Nghich_Dao(pn, e);
            //        }
            //    }
            //    ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + "</p>";
            //    if (breakk < 0 || breakk == 0)
            //    {
            //        break;

            //    }

            //}
        }
        // mã hóa X gửi đi 
        protected void Button2_Click(object sender, EventArgs ee)
        {
            //gán các giá trị và ghi ra màn hình
            int e, x, n;
            e =Convert.ToInt32(txt_mahoa_E.Text);
            x =Convert.ToInt32(txt_mahoa_x.Text);
            n =Convert.ToInt32(txt_mahoa_n.Text);
            lb_mahoa_e.Text = e.ToString();
            lb_mahoa_n.Text = n.ToString();
            lb_mahoa_x.Text = x.ToString();
            // tính toán dựa trên đề bài
            int banma = Suly.tinhnhanh_rsa(x, e, n);
            lb_banma.Text = banma.ToString();

            //ghi ra quá trình tính toán
            int[,] matrix = new int[30, 30];
            matrix = Suly.tinhnhanh_rsa_matrix(x, e, n);
            ShowQuaTrinhMaHoa.InnerHtml = "<table><tr><td>X</td><td>A</td><td>Y</tr>";
            ShowQuaTrinhMaHoa.InnerHtml =  ShowQuaTrinhMaHoa.InnerHtml+ Suly.inmatrix(matrix,3)+"</table>";
            //int breakk = 30;
            //for (int i = 0; i < 20; i++)
            //{
                
            //    ShowQuaTrinhMaHoa.InnerHtml =ShowQuaTrinhMaHoa.InnerHtml+ "<p>" + matrix[i, 0] + "," + matrix[i, 1] + "," + matrix[i, 2] + "</p>";
            //    breakk = matrix[i, 0];
            //    if (breakk == 1)
            //    {
            //        break;
            //    }
            //}

        }
}
