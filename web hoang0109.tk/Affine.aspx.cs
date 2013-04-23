using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHoc
{
    public partial class _Default : System.Web.UI.Page
    {
        private static string chuoimahoa_ = "abcdefghijklmnopqrstuvwxyz0123456789 ";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["id"])))
            {
                Response.Redirect("login.aspx");
            }
        }
        private List<string> StringToInt(string chuoi_)
        {
            
            List<string> list = new List<string>();
            for (int i = 0; i < chuoi_.Length; i++)
            {
                for (int j = 0; j <chuoimahoa_.Length; j++)
                {
                    if (chuoimahoa_[j] == chuoi_[i])
                    {
                        list.Add(j.ToString());
                    }
                }
            }
            return list;
        }
        private List<string> ConverChuoi(List<string> chuoi_,int a,int b,int giatrimod,string kieu)
        {

            List<string> list = new List<string>();
            if (kieu=="mahoa")
            {
                for (int i = 0; i < chuoi_.Count; i++)
            {
                int x = (((a*Convert.ToInt32(chuoi_[i]))+b)%giatrimod);
                list.Add(x.ToString());
            }
            }
            if (kieu=="giaima")
            {
                for (int i = 0; i < chuoi_.Count; i++)
                {
                    int x = (((a * (Convert.ToInt32(chuoi_[i]) - b)) % giatrimod));
                    if (x<0)
                    {
                        x = x + giatrimod;
                    }
                    
                    list.Add(x.ToString());
                }
            }
            
            return list;
        }
        private List<string> KetQuaCuoi(List<string> chuoi_)
        {

            List<string> list = new List<string>();
            for (int i = 0; i < chuoi_.Count; i++)
            {
                list.Add(chuoimahoa_[Convert.ToInt32(chuoi_[i])].ToString());
            }
            return list;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
            List<string> luutru = new List<string>();
            List<string> luutru2 = new List<string>();
            KhoaK.Text = "K=(" + k_a.Text + "," + k_b.Text + ")";
            Chuoi.Text = chuoimahoa.Text;
            Chuoidangso.Text = "";
            luutru = StringToInt(chuoimahoa.Text);
            Chuoidangso.Text = "Chuoi dang so : ";
            for (int i = 0; i < luutru.Count; i++)
            {
                Chuoidangso.Text = Chuoidangso.Text + luutru[i]+",";
            }
            luutru = ConverChuoi(luutru,Convert.ToInt32(k_a.Text),Convert.ToInt32(k_b.Text),Convert.ToInt32(k_mod.Text),"mahoa");
            KetQua.Text = "y=(a*x+b)mod giatrimod = ";
            for (int i = 0; i < StringToInt(chuoimahoa.Text).Count; i++)
            {
                KetQua.Text = KetQua.Text + luutru[i]+",";
                luutru2.Add(luutru[i]);
            }
            luutru2 = KetQuaCuoi(luutru2);
            DapAn.Text = "Ket Qua Cuoi : ";
            for (int i = 0; i < luutru2.Count; i++)
            {
                DapAn.Text = DapAn.Text + luutru2[i] + ",";
            }
           // KetQua.Text = ((30 * 11 + 35) % 37).ToString();
        }
         catch{}
        }
        public class so
        {
            public int phannguyen;
            public int phandu;
            public void nhap(int phannguyen_, int phandu_)
            {
                this.phannguyen = phannguyen_;
                this.phandu = phandu_;
            }

        }
        private static so chia(int a_, int b_)
        {
            so ketqua_ = new so();
            int a = a_;
            int b = b_;
            ketqua_.phannguyen = ((a / b) - ((a / b) % 1));
            ketqua_.phandu = a % b;
            return ketqua_;
        }
        public static int[,] nghicdao =new int[9,9];
        public static int tinhA(int giatrimod, int k_a_)
        {
            int ketqua = 0;
            so tinhtoan = new so();
            int[,] matrix = new int[9, 9];
            matrix[0, 0] = giatrimod;
            matrix[1, 0] = k_a_;
            matrix[0, 1] = 1;
            matrix[0, 2] = 0;
            matrix[1, 1] = 0;
            matrix[1, 2] = 1;
            int x1 = -1;
            int i = 1;
            while (x1 != 0)
            {
                tinhtoan = chia(matrix[(i - 1), 0], matrix[i, 0]);
                matrix[i, 3] = tinhtoan.phannguyen;
                x1 = tinhtoan.phandu;
                i++;
                tinhtoan = chia(matrix[(i - 2), 0], matrix[i - 1, 0]);
                matrix[i, 0] = tinhtoan.phandu;
                matrix[i, 1] = matrix[i - 2, 1] - matrix[i - 1, 1] * matrix[i - 1, 3];
                matrix[i, 2] = matrix[i - 2, 2] - matrix[i - 1, 2] * matrix[i - 1, 3];
                
                if (matrix[i - 1, 0] == 1)
                {
                    if (matrix[i - 1, 2] > 0)
                    {
                        ketqua = matrix[i - 1, 2];
                    }
                    else
                    {
                        ketqua = giatrimod + matrix[i - 1, 2];
                    }
                }

            }
            nghicdao = matrix;


            return ketqua;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                int breakk = 0; ;
                int nghicdaoa = tinhA(Convert.ToInt32(k_mod.Text), Convert.ToInt32(k_a.Text));


                ShowKetQuaNghicDao.InnerHtml = "<p>Xi,Ui,Vi,Yi</p>";
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
                //            ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + nghicdaoa;
                //        }
                //    }
                //    ShowKetQuaNghicDao.InnerHtml = ShowKetQuaNghicDao.InnerHtml + "</p>";
                //    if (breakk < 0 || breakk == 0)
                //    {
                //        break;

                //    }

                //}
                KetQuaNghicDao.Text = "ket qua nghic dao : " + nghicdaoa;
                List<string> luutru = new List<string>();
                List<string> luutru2 = new List<string>();
                KhoaK.Text = "K=(" + k_a.Text + "," + k_b.Text + ")";
                Chuoi.Text = chuoimahoa.Text;
                Chuoidangso.Text = "";
                luutru = StringToInt(chuoimahoa.Text);
                Chuoidangso.Text = "Chuoi dang so : ";
                for (int i = 0; i < luutru.Count; i++)
                {
                    Chuoidangso.Text = Chuoidangso.Text + luutru[i] + ",";
                }
                luutru = ConverChuoi(luutru, nghicdaoa, Convert.ToInt32(k_b.Text), Convert.ToInt32(k_mod.Text), "giaima");
                KetQua.Text = "x=a-1(y-b)mod giatrimod = ";
                for (int i = 0; i < StringToInt(chuoimahoa.Text).Count; i++)
                {
                    KetQua.Text = KetQua.Text + luutru[i] + ",";
                    luutru2.Add(luutru[i]);
                }
                luutru2 = KetQuaCuoi(luutru2);
                DapAn.Text = "Ket Qua Cuoi : ";
                for (int i = 0; i < luutru2.Count; i++)
                {
                    DapAn.Text = DapAn.Text + luutru2[i] + ",";
                }
            }
            catch { }
        }
    }
}