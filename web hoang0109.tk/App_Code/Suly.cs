﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Suly
{
    public Suly()
    {
        //
        // TODO: Add constructor logic here
        //
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
    //Tinh nghich dao gia tri tra ve la int
    public static int Tinh_Nghich_Dao(int giatrimod, int k_a_)
    {
        int ketqua = 0;
        so tinhtoan = new so();
        int[,] matrix = new int[20, 20];
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
        //nghicdao = matrix;
        return ketqua;
    }
    //Tinh nghich dao gia tri tra ve la qua trinh tinh
    public static int[,] TinhNghichDao(int giatrimod, int k_a_)
    {
        int[,] nghicdao = new int[20, 20];
        int ketqua = 0;
        so tinhtoan = new so();
        int[,] matrix = new int[20, 20];
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
        return nghicdao;
    }
    //kiem tra chan le 1 so
    public static bool chanle(int x)
    {
        if (x % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //ham lam tron so
    public static int lamtron(double x)
    {
        return Convert.ToInt32(x - (x % 1));
    }
    public static int lamtron(double x, int t)
    {
        if (x % 1 >= 0.5)
        {

            return Convert.ToInt32(x - (x % 1) + 1);
        }
        else
        {
            return Convert.ToInt32(x - (x % 1));
        }

    }
    // ham ma hoa rsa tra ve gia tri int
    public static int tinhnhanh_rsa(int x, int a, int n)
    {
        int y = 1;
        so tinhtoan = new so();
        int[,] matrix = new int[20, 20];

        matrix[0, 0] = a;
        matrix[0, 1] = x;
        matrix[0, 3] = y;
        matrix[1, 0] = a;
        matrix[1, 1] = x;
        matrix[1, 2] = (x * y) % n;
        //Console.WriteLine(matrix[0, 0] + "," + matrix[0, 1] + "," + matrix[0, 2]);
        //Console.WriteLine(matrix[1, 0] + "," + matrix[1, 1] + "," + matrix[1, 2]);
        int i = 2;
        x = matrix[1, 0];
        while (x != 1)
        {
            matrix[i, 0] = lamtron(matrix[i - 1, 0] / 2);
            x = matrix[i, 0];
            matrix[i, 1] = (matrix[i - 1, 1] * matrix[i - 1, 1]) % n;

            if (chanle(matrix[i, 0]) == false)
            {
                matrix[i, 2] = (matrix[i, 1] * matrix[i - 1, 2]) % n;
            }
            else
            {
                matrix[i, 2] = matrix[i - 1, 2];
            }
            //Console.WriteLine(matrix[i, 0] + "," + matrix[i, 1] + "," + matrix[i, 2]);
            i = i + 1;
        }
        return matrix[i - 1, 2];
    }
    // ham ma hoa rsa tra ve gia tri matrix
    public static int[,] tinhnhanh_rsa_matrix(int x, int a, int n)
    {
        int y = 1;
        so tinhtoan = new so();
        int[,] matrix = new int[20, 20];

        matrix[0, 0] = a;
        matrix[0, 1] = x;
        matrix[0, 3] = y;
        matrix[1, 0] = a;
        matrix[1, 1] = x;
        matrix[1, 2] = (x * y) % n;
        //Console.WriteLine(matrix[0, 0] + "," + matrix[0, 1] + "," + matrix[0, 2]);
        //Console.WriteLine(matrix[1, 0] + "," + matrix[1, 1] + "," + matrix[1, 2]);
        int i = 2;
        x = matrix[1, 0];
        while (x != 1)
        {
            matrix[i, 0] = lamtron(matrix[i - 1, 0] / 2);
            x = matrix[i, 0];
            matrix[i, 1] = (matrix[i - 1, 1] * matrix[i - 1, 1]) % n;

            if (chanle(matrix[i, 0]) == false)
            {
                matrix[i, 2] = (matrix[i, 1] * matrix[i - 1, 2]) % n;
            }
            else
            {
                matrix[i, 2] = matrix[i - 1, 2];
            }
            //Console.WriteLine(matrix[i, 0] + "," + matrix[i, 1] + "," + matrix[i, 2]);
            i = i + 1;
        }
        return matrix;
    }
    // Ham matrix->String html
    public static string inmatrix(int[,] matrix)
    {
        string html = null;
        try
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                html = html + "<tr>";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    html = html + "<td>" + (matrix[i, j]) + "</td>";

                }
                html = html + "</tr>";
            }
        }
        catch
        {
            html = "<tr><td> khong ghi duoc </td></tr>";
        }

        return html;
    }
    // Ham matrix->String html
    public static string inmatrix(string[,] matrix)
    {
        string html = null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            html = html + "<tr class='tr_345gh'>";
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                html = html + "<td class='td_35345'>" + (matrix[i, j]) + "</td>";

            }
            html = html + "</tr>";
        }


        return html;
    }
    // Ham matrix->String html
    public static string inmatrix(int[,] matrix, int cot)
    {
        string html = null;
        for (int i = 0; i < System.Math.Sqrt(matrix.Length); i++)
        {
            if (matrix[i, 0] == 0)
            {
                break;
            }
            html = html + "<tr>";
            for (int j = 0; j < cot; j++)
            {

                html = html + "<td>" + (matrix[i, j]) + "</td>";

            }
            html = html + "</tr>";

        }


        return html;
    }


    // xap xep mang 1 chieu
    /// <summary>
    /// xap xep mang 1 chieu
    /// </summary>
    public static int[] sapxepmang1chieu(int[] arr)
    {
        bool swapped = true;
        int j = 0;
        int tmp;
        while (swapped)
        {
            swapped = false;
            j++;
            for (int i = 0; i < arr.Length - j; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    swapped = true;
                }
            }
        }
        return arr;
    }
    /// <summary>
    /// Chuyển đổi dạng text về dạng số
    /// </summary>
    /// <param name="x">Chuoi can chuyển đổi</param>
    /// <returns>trả về dạng list</returns>
    public static List<int> TextToInt(string x)
    {
        List<int> ketqua = new List<int>();
        string chuoimahoa_ = "abcdefghijklmnopqrstuvwxyz0123456789 ";
        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < chuoimahoa_.Length; j++)
            {
                if (x[i] == chuoimahoa_[j])
                {
                    ketqua.Add(j);
                    break;
                }
            }
        }
        return ketqua;
    }
    // Chuyển dạng số về dạng chữ tương ứng 0..26
    /// <summary>
    /// Chuyển đổi dạng số về dạng text
    /// </summary>
    /// <param name="x">Chuoi can chuyển đổi</param>
    /// <returns>trả về dạng list</returns>
    public static List<string> IntToText(List<int> x)
    {
        List<string> ketqua = new List<string>();
        string chuoimahoa_ = "abcdefghijklmnopqrstuvwxyz0123456789 ";
        foreach (int s in x)
        {
            ketqua.Add(chuoimahoa_[s].ToString());
        }
        return ketqua;
    }
    /// <summary>
    /// Chuyển dạng string về matrix
    /// </summary>
    /// <param name="x">Chuoi cần chuyển đổi</param>
    /// <param name="k">cấp ma trận</param>
    /// <returns>trả về dạng matrix int[,]</returns>
    public static int[,] StringToMatrix(string x, int k)
    {
        int[,] matrix = new int[k, k];
        string[] chuoi_tach = x.Split(new Char[] { ',' });
        int g = 0;
        for (int t = 0; t < k; t++)
        {
            for (int j = 0; j < k; j++)
            {

                matrix[t, j] = Convert.ToInt32(chuoi_tach[g]);
                g++;


            }
        }

        return matrix;
    }
    /// <summary>
    /// Chuyển dạng string về matrix
    /// </summary>
    /// <param name="x">Chuoi cần chuyển đổi</param>
    /// <param name="k">cấp ma trận</param>
    /// <returns>trả về dạng matrix int[,]</returns>
    public static int[,] StringToMatrix(string x, int sohang, int socot)
    {
        int[,] matrix = new int[sohang, socot];
        string[] chuoi_tach = x.Split(new Char[] { ',' });
        int g = 0;
        for (int t = 0; t < sohang; t++)
        {
            for (int j = 0; j < socot; j++)
            {

                matrix[t, j] = Convert.ToInt32(chuoi_tach[g]);
                g++;


            }
        }

        return matrix;
    }
    /// <summary>
    /// Tang cap ma tran 3*2 thanh 4*3
    /// </summary>
    public static int[,] tangcapmatran(int[,] matrix)
    {

        int hang = matrix.GetLength(0);
        int cot = matrix.GetLength(1);

        int[,] matrix2 = new int[hang + 2, cot + 2];
        for (int i = 1; i < hang + 1; i++)
        {
            for (int j = 1; j < cot + 1; j++)
            {
                matrix2[i, j] = matrix[i - 1, j - 1];
            }
        }

        return matrix2;
    }

    /// <summary>
    /// Trich ma tran con tinh trung vi
    /// </summary>
    /// <param name="matrix">ma tran goc</param>
    /// <param name="sohang">vi tri trung tam</param>
    /// <param name="socot">vi tri trung tam</param>
    /// <param name="x">cấp ma trận</param>
    /// <returns>trả về dạng matrix int[,]</returns>

    public static int[,] Matrix_con(int[,] matran, int sohang, int socot, int capmatran)
    {
        // tang  cap ma tran 
        int[,] matrix2 = tangcapmatran(matran);
        //ma tran con
        int[,] matrix3 = new int[capmatran, capmatran];
        int t = 0; int q = 0;
        for (int i = sohang; i < (sohang + capmatran); i++)
        {
            for (int j = socot; j < (socot + capmatran); j++)
            {
                matrix3[t, q] = matrix2[i, j];
                q++;
            }
            q = 0;
            t++;

        }
        return matrix3;
    }
    /// <summary>
    /// ma tran ket qua cua phep toan tinh ma tran trung vi
    /// </summary>
    public static int[,] trungvi_ketqua(int[,] matran, int[,] trungvi, int[,] hieu, int gioihan)
    {
        int hang = matran.GetLength(0);
        int cot = matran.GetLength(1);
        int[,] matrix2 = new int[hang, cot];
        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                if (hieu[i, j] <= gioihan)
                {
                    matrix2[i, j] = matran[i, j];
                }
                else
                {
                    matrix2[i, j] = trungvi[i, j];
                }
            }

        }
        return matrix2;
    }
    /// <summary>
    /// lay so trung tam cua ma tran
    /// </summary>
    /// <returns>trả về dạng int</returns>
    public static int laygiatritrungtam(int[] arr)
    {

        return arr[((arr.Length + 1) / 2) - 1];

    }
    /// <summary>
    /// list to html
    /// </summary>
    public static string ListToHtml(List<int> x)
    {
        string ketqua = null;
        foreach (var item in x)
        {
            ketqua = ketqua + item + "    ";
        }
        return ketqua;
    }
    public static string ListToHtml(List<string> x)
    {
        string ketqua = null;
        foreach (var item in x)
        {
            ketqua = ketqua + item + "    ";
        }
        return ketqua;
    }
    /// <summary>
    /// Y=K X mod N
    /// </summary>
    /// <param name="X">Chuoi can chuyển đổi</param>
    /// <param name="X">Ma tran K</param>
    /// <param name="N">Gia tri mod</param>
    /// <returns>trả về dạng list</returns>
    public static List<int> ykxmodn(int[,] k, List<int> x, int n)
    {
        List<int> ketqua = new List<int>();
        for (int i = 0; i < Math.Sqrt(k.Length); i++)
        {
            int xx = 0;
            for (int j = 0; j < Math.Sqrt(k.Length); j++)
            {
                xx = xx + k[i, j] * x[j];
            }
            ketqua.Add(xx % n);
        }
        return ketqua;
    }
    //Hàm tính định thức của ma trận a
    /// <summary>
    /// hàm tính định thức của ma trận A
    /// </summary>
    public static int det(int[,] a, int n)
    {
        int d = 0;
        if (n <= 0) return 0;
        if (n == 1) return a[0, 0];
        if (n == 2) return (a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]);
        else
        {
            int[,] c = new int[n - 1, n - 1]; //Ma trận con cấp n-1
            //Khai triển định thức theo cột đầu tiên (cột 0)
            for (int j = 0; j < n; j++)
            {
                //Tạo ma trận con c cấp n-1 bằng cách bỏ đi cột 0 và hàng j của ma trận a
                int p = 0; int m = 0;
                for (int i = 1; i < n; i++)
                {
                    for (int e = 0; e < n; e++)
                    {
                        if (e == j) continue;
                        c[p, m] = a[e, i];
                        p++;
                        if (p == n - 1)
                        {
                            m++;
                            p = 0;
                        }
                    }
                }

                d += ((int)Math.Pow(-1, j) * a[j, 0] * det(c, n - 1));
            }
            return d;
        }
    }

    /// <summary>
    /// Hàm tính khóa công khai cua balo
    /// </summary>
    public static int[] khoacongkhai_balo(int[] khoabimat, int p, int a)
    {
        int[] khoacongkhai = khoabimat;
        for (int i = 0; i < khoabimat.Length; i++)
        {
            khoacongkhai[i] = (khoabimat[i] * a) % p;
        }
        return khoacongkhai;
    }
    /// <summary>
    /// mã hóa bản rõ :10101010 ( hệ nhị phân) công thức balo
    /// </summary>  
    public static int mahoa_banro_balo(string banro, int[] khoacongkhai)
    {
        int y = 0;
        try
        {
            for (int i = 0; i < khoacongkhai.Length; i++)
            {
                y = y + (Convert.ToInt32(banro[i].ToString()) * khoacongkhai[i]);
            }
        }
        catch (Exception)
        {

            throw;
        }
        return y;
    }
    /// <summary>
    /// Giải mã hóa bản mã ( thuật toán balo)
    /// </summary>  
    public static string[,] giaima_banma_balo(int banma, int[] khoabimat)
    {
        string[,] matrix = new string[3, (khoabimat.Length + 2)];
        int x = banma;
        matrix[0, 0] = "S";
        matrix[1, 0] = "X";
        matrix[2, 0] = "C";
        for (int i = 3; i > -1; i--)
        {
            matrix[0, i + 1] = khoabimat[i].ToString();

            if (x >= khoabimat[i])
            {
                x = x - khoabimat[i];
                matrix[1, i + 1] = "1";
                matrix[2, i + 1] = x.ToString();

            }
            else
            {
                matrix[1, i + 1] = "0";
                matrix[2, i + 1] = x.ToString();
            }

        }

        return matrix;


    }
    /// <summary>
    /// Tinh trung bình
    /// </summary> 
    public static int tinhtrungbinh(int[] ar)
    {
        int tt = 0;
        int tong = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            tong = tong + ar[i];
        }
        double trungbinh = (double)tong / 9;

        tt = lamtron(trungbinh, 0);
        return tt;
    }
    /// <summary>
    /// Tinh trung vị trung bình
    /// </summary> 
    public static int[,] tinhtrungvitrungbinh(int[,] matran)
    {
        int[,] trungvi = new int[matran.GetLength(0), matran.GetLength(1)];
        int tt = 0;
        for (int i = 0; i < matran.GetLength(0); i++)
        {
            for (int j = 0; j < matran.GetLength(1); j++)
            {
                tt = tinhtrungbinh(matrixtoarray(Matrix_con(matran, i, j, 3)));
                trungvi[i, j] = tt;



            }
        }
        return trungvi;
    }
    ///<summary>
    ///tìm số phần tử tồn tại trong danh sách
    ///</summary>
    public static int timphantutontai(int[] ar, int phantu)
    {
        int dem = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (phantu == ar[i])
            {
                dem++;
            }
        }
        return dem;
    }
    ///<summary>
    ///Xắp xếp danh sách để tính trung vị trung bình theo K
    ///</summary>
    public static int[] sapxepdanhsach_tinhtheok(int[] ar, int trungtam)
    {
        int[] arr = new int[ar.Length];
        int vitri = 0;
        for (int i = 0; i < ar.Max(); i++)
        {
            if (i == 0)
            {
                int phantutontai = timphantutontai(ar, trungtam - i);
                for (int j = 0; j < phantutontai; j++)
                {
                    arr[vitri] = trungtam - i;
                    vitri++;
                }
            }
            else
            {
                int phantutontai = timphantutontai(ar, trungtam - i);
                for (int j = 0; j < phantutontai; j++)
                {
                    arr[vitri] = trungtam - i;
                    vitri++;
                }
                int phantutontai1 = timphantutontai(ar, trungtam + i);
                for (int j = 0; j < phantutontai1; j++)
                {
                    arr[vitri] = trungtam + i;
                    vitri++;
                }
            }


        }
        return arr;
    }
    /// <summary>
    /// Tinh trung bình theo k
    /// </summary> 
    public static int tinhtrungbinh_theok(int[] ar, int k)
    {
        int tt = 0;
        int tong = 0;
        for (int i = 0; i < k; i++)
        {
            tong = tong + ar[i];
        }
        double trungbinh = (double)tong / k;

        tt = lamtron(trungbinh, 0);
        return tt;
    }
    public static void inarr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "  ");
        }
        Console.WriteLine();
    }
    public static string inarr(string[] arr)
    {
        string ketqua = null;
        for (int i = 0; i < arr.Length; i++)
        {
            ketqua = ketqua + arr[i] + " ; ";
        }
        return ketqua;
    }
    /// <summary>
    /// Tinh trung vị trung bình theo k
    /// </summary> 
    public static int[,] tinhtrungvitrungbinh_theoK(int[,] matran, int k)
    {
        int[,] trungvi = new int[matran.GetLength(0), matran.GetLength(1)];
        int tt = 0;
        for (int i = 0; i < matran.GetLength(0); i++)
        {
            for (int j = 0; j < matran.GetLength(1); j++)
            {
                int[,] matrix_conn = Matrix_con(matran, i, j, 3);
                int[] arr = matrixtoarray(matrix_conn);
                int[] ar = sapxepdanhsach_tinhtheok(arr, matrix_conn[1, 1]);
                inarr(ar);
                tt = tinhtrungbinh_theok(ar, k);
                trungvi[i, j] = tt;



            }
        }
        return trungvi;
    }
    /// <summary>
    /// Tinh trung vi
    /// </summary> 
    public static int[,] tinhtrungvi(int[,] matran)
    {
        int[,] trungvi = new int[matran.GetLength(0), matran.GetLength(1)];
        int tt = 0;
        for (int i = 0; i < matran.GetLength(0); i++)
        {
            for (int j = 0; j < matran.GetLength(1); j++)
            {
                tt = laygiatritrungtam(matrixtoarray(Matrix_con(matran, i, j, 3)));
                trungvi[i, j] = tt;



            }
        }
        return trungvi;
    }
    /// <summary>
    /// hieu 2 ma tran de tinh trung vi
    /// </summary> 
    public static int[,] hieu2matran_trungvi(int[,] matrix1, int[,] matrix2)
    {
        int[,] hieu = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                hieu[i, j] = Math.Abs(matrix1[i, j] - matrix2[i, j]);
            }
        }
        return hieu;
    }

    /// <summary>
    /// matrix to array
    /// </summary> 
    public static int[] matrixtoarray(int[,] matrix)
    {
        int[] ar = new int[matrix.Length];
        int t = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ar[t] = matrix[i, j];
                t++;
            }

        }
        int[] arr2 = Suly.sapxepmang1chieu(ar);
        return arr2;

    }
    /// <summary>
    /// String to int[] 1,2,3,4 -> [1,2,3,4]
    /// </summary> 
    public static int[] stringtoarrayint(string x)
    {
        string khoacongkhai = x;
        string[] khoacongkhai_ar = khoacongkhai.Split(new Char[] { ',' });
        int[] khoacongkhai_ar_int = new int[khoacongkhai_ar.Length];
        for (int i = 0; i < khoacongkhai_ar.Length; i++)
        {
            khoacongkhai_ar_int[i] = Convert.ToInt32(khoacongkhai_ar[i]);
        }
        return khoacongkhai_ar_int;
    }
    /// <summary>
    /// k mu -1 cua hill
    /// </summary> 
    public static double[,] kMuTru1(int[,] matrix, int deta)
    {
        double[,] ketqua = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                ketqua[i, j] = (double)matrix[i, j] / deta;
            }
        }
        return ketqua;
    }
    /// <summary>
    /// lay ra ma tran con theo hang va cot
    /// </summary> 
    public static int[,] MatrixCon(int[,] matrix, int hang, int cot, int k)
    {
        int[,] ketqua = new int[k, k];
        int t = 0; int q = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i != hang)
            {
                q = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (j != cot)
                    {
                        ketqua[t, q] = matrix[i, j];
                        q++;
                    }


                }
                t++;
            }
        }
        return ketqua;
    }
    /// <summary>
    /// ma tran sao k^-1=1/det(a) * K*
    /// </summary> 
    public static int[,] MatrixSao(int[,] matrix, int k)
    {
        int[,] ketqua = new int[k, k];
        int[,] matrixcon = new int[k - 1, k - 1];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrixcon = MatrixCon(matrix, i, j, k - 1);
                ketqua[i, j] = Convert.ToInt32(Math.Pow((-1), i + j)) * det(matrixcon, k - 1);
            }
        }
        return ketqua;
    }
    /// <summary>
    /// Chia String S thanh String nho hon
    /// </summary>
    /// <param name="S">String goc</param>
    /// <param name="x">Moc de cat vd , ; ...</param>
    /// <returns>tra ve string[] ket qua</returns>
    public static string[] Split_String(string S, char x)
    {
        string[] ketqua = S.Split(x);
        return ketqua;
    }
    /// <summary>
    /// Tinh Tap Trung
    /// </summary>
    /// <param name="S">string[] S</param>
    /// <returns>Tra ve string[] ket qua</returns>
    public static string[] TinhTapTrung(string[] S,bool lamtron)
    {
        string[] ketqua = new string[S.Length];
        if (lamtron == true)
        {

        
            for (int i = 0; i < S.Length; i++)
            {
            
                ketqua[i] =Math.Round(Math.Pow(Convert.ToDouble(S[i]), 2.0),2).ToString();
            
            }
        }
        else
        {
            
            for (int i = 0; i < S.Length; i++)
            {
            
                ketqua[i] =Math.Pow(Convert.ToDouble(S[i]), 2.0).ToString();
            
            }
        }
        
        return ketqua;
    }
    /// <summary>
    /// Tính co giãn
    /// </summary>
    /// <param name="S">mảng S nhập để tính</param>
    /// <param name="lamtron">true là làm tròn false không</param>
    /// <returns>Trả về giá trị đã tính dưới dạng string[]</returns>
    public static string[] TinhCoGian(string[] S, bool lamtron)
    {
        string[] ketqua = new string[S.Length];

        if (lamtron == true)
        {


            for (int i = 0; i < S.Length; i++)
            {

                ketqua[i] = Math.Round(Math.Sqrt(Convert.ToDouble(S[i])), 2).ToString();

            }
        }
        else
        {

            for (int i = 0; i < S.Length; i++)
            {

                ketqua[i] = Math.Sqrt(Convert.ToDouble(S[i])).ToString();

            }
        }

        return ketqua;
    }
    /// <summary>
    /// Tinh Nhan Manh
    /// </summary>
    /// <param name="S">mảng S nhập để tính</param>
    /// <param name="lamtron">true là làm tròn false không</param>
    /// <returns>Trả về giá trị đã tính dưới dạng string[]</returns>
    public static string[] TinhNhanhManh(string[] S, bool lamtron)
    {
        string[] ketqua = new string[S.Length];

        if (lamtron == true)
        {


            for (int i = 0; i < S.Length; i++)
            {
                double x =Convert.ToDouble(S[i]);
                if (0<=x && x<=0.5)
                {
                    ketqua[i] = Math.Round(2* Math.Pow(x, 2.0),2).ToString();
                }
                if (x>0.5&&x<1)
                {
                     ketqua[i] = Math.Round(1-(2* Math.Pow(1-x, 2.0)),2).ToString();
                }
                

            }
        }
        else
        {

            for (int i = 0; i < S.Length; i++)
            {

                double x = Convert.ToDouble(S[i]);
                if (0 <= x && x <= 0.5)
                {
                    ketqua[i] =(2 * Math.Pow(x, 2.0)).ToString();
                }
                if (x > 0.5 && x < 1)
                {
                    ketqua[i] = (1 - (2 * Math.Pow(1-x, 2.0))).ToString();
                }

            }
        }

        return ketqua;
    }
    /// <summary>
    /// Tính Mxy của logic mờ VD tính Mac
    /// </summary>
    /// <param name="x">Nhập x</param>
    /// <param name="y">Nhập y</param>
    /// <returns>ma trận kết quả</returns>
    public static string[,] Logicmo_Mxy(string[] x, string[] y)
    {
        string[,] ketqua = new string[x.Length,y.Length];
        
        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < y.Length; j++)
            {
                ketqua[i, j] = Math.Min(Convert.ToDouble(x[i]),Convert.ToDouble(y[j])).ToString();
            }
        }
        return ketqua;
    }
    /// <summary>
    /// Tính B'A'=A'x Mab
    /// </summary>
    /// <param name="A">string[] A'</param>
    /// <param name="AB">string[,] AB</param>
    /// <returns>retun string[] B'A'</returns>
    public static string[] logicmo_AB(string[] A,string[,] AB)
        {
            string[] ketqua = new string[AB.GetLength(1)];
            for (int i = 0; i < AB.GetLength(1); i++)
            {
                double max = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    double x = Convert.ToDouble(A[j]);
                    double y = Convert.ToDouble(AB[j, i]);
                    if (Math.Min(x,y)>max)
                    {
                        max = Math.Min(x, y);
                    }
                }
                ketqua[i] = max.ToString();
            }
            return ketqua;
        
        }
    /// <summary>
    /// Logic mờ tính kết quả điều kiện and hoặc or
    /// </summary>
    /// <param name="A">mảng 1 </param>
    /// <param name="B">mảng 1</param>
    /// <param name="andor">and hoặc or</param>
    /// <returns>kết quả cuối</returns>
    public static string[] logicmo_andor(string[] A,string[] B,string andor)
        {
            string[] ketqua = new string[A.Length];
            if (andor=="and")
            {
                for (int i = 0; i < A.Length; i++)
                {
                    ketqua[i] = Math.Min(Convert.ToDouble(A[i]), Convert.ToDouble(B[i])).ToString();
                }
            }
            if (andor == "or")
            {
                for (int i = 0; i < A.Length; i++)
                {
                    ketqua[i] = Math.Max(Convert.ToDouble(A[i]), Convert.ToDouble(B[i])).ToString();
                }
            }
            return ketqua;
        }
    /// <summary>
    /// Tính tích cực đại của logic mờ VD tính Mac
    /// </summary>
    /// <param name="x">Nhập x</param>
    /// <param name="y">Nhập y</param>
    /// <returns>ma trận kết quả</returns>
    public static string[,] Logicmo_Tichxy(string[] x, string[] y)
    {
        string[,] ketqua = new string[x.Length, y.Length];

        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < y.Length; j++)
            {
                ketqua[i, j] = (Convert.ToDouble(x[i])*Convert.ToDouble(y[j])).ToString();
            }
        }
        return ketqua;
    }

}
