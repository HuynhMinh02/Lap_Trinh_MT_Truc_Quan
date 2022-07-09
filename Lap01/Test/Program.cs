using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace Test

{

    public class VienKhoaHoc

    {

        protected string HoTen, BangCap;

        protected int NamSinh;

        public VienKhoaHoc()

        {

            HoTen = ""; BangCap = ""; NamSinh = 0;

        }

        public VienKhoaHoc(string HoTen, int NamSinh, string BangCap)

        {

            this.HoTen = HoTen; this.NamSinh = NamSinh; this.BangCap = BangCap;

        }

        public void Nhap()

        {

            Console.Write("Nhap Ho ten: "); HoTen = Console.ReadLine();

            Console.Write("Nhap Nam sinh: "); NamSinh = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap Bang Cap: "); BangCap = Console.ReadLine();

        }

        public void Xuat()

        {

            Console.WriteLine("Ho ten: {0} ; Nam Sinh: {1} ; Bang Cap: {2} ", HoTen, NamSinh, BangCap);

        }

    }

    public class KhoaHoc : VienKhoaHoc

    {

        string ChucVu;

        int BaiBao;

        double BacLuong, NgayCong;

        public KhoaHoc() : base()

        {

            ChucVu = ""; BaiBao = 0; NgayCong = 0; BacLuong = 0;

        }

        public KhoaHoc(string HoTen, int NamSinh, string BangCap, string ChucVu, int BaiBao, double NgayCong, double BacLuong) : base(HoTen, NamSinh, BangCap)

        {

            this.ChucVu = ChucVu; this.BaiBao = BaiBao; this.NgayCong = NgayCong; this.BacLuong = BacLuong;

        }

        public new void Nhap()

        {

            base.Nhap();

            Console.Write("Nhap Chuc Vu: "); ChucVu = Console.ReadLine();

            Console.Write("Nhap so Bai Bao da duoc cong bo: "); BaiBao = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so Ngay Cong trong thang: "); NgayCong = Double.Parse(Console.ReadLine());

            Console.Write("Nhap Bac Luong : "); BacLuong = Double.Parse(Console.ReadLine());

        }

        public new void Xuat()

        {

            base.Xuat();

            Console.WriteLine("So Bai Bao da duoc cong bo: {0} , So ngay cong trong thang: {1} , Bac Luong: {2}", BaiBao, NgayCong, BacLuong);

            Console.WriteLine();

        }

        public double TongKH()

        {

            double Luong;

            Luong = (NgayCong * BacLuong);

            return (Luong);

        }

    }

    public class QuanLy : VienKhoaHoc

    {

        string ChucVu;

        double BacLuong, NgayCong;

        public QuanLy() : base()

        {

            ChucVu = ""; BacLuong = 0; NgayCong = 0;

        }

        public QuanLy(string HoTen, int NamSinh, string BangCap, string ChucVu, double NgayCong, double BacLuong) : base(HoTen, NamSinh, BangCap)

        {

            this.ChucVu = ChucVu; this.NgayCong = NgayCong; this.BacLuong = BacLuong;

        }

        public new void Nhap()

        {

            base.Nhap();

            Console.Write("Nhap Chuc Vu: "); ChucVu = Console.ReadLine();

            Console.Write("Nhap so ngay cong trong thang: "); NgayCong = Double.Parse(Console.ReadLine());

            Console.Write("Nhap Bac Luong: "); BacLuong = Double.Parse(Console.ReadLine());

        }

        public new void Xuat()

        {

            base.Xuat();

            Console.WriteLine("Chuc vu: {0} , So ngay cong trong thang: {1} , Bac Luong: {2}", ChucVu, NgayCong, BacLuong);

            Console.WriteLine();

        }

        public double TongQL()

        {

            double Luong;

            Luong = (NgayCong * BacLuong);

            return (Luong);

        }

    }

    public class NhanVienPTN : VienKhoaHoc

    {

        double LuongThang;

        public NhanVienPTN() : base()

        {

            LuongThang = 0;

        }

        public NhanVienPTN(string HoTen, int NamSinh, string BangCap, double LuongThang) : base(HoTen, NamSinh, BangCap)

        {

            this.LuongThang = LuongThang;

        }

        public new void Nhap()

        {

            base.Nhap();

            Console.Write("Nhap Luong Thang : "); LuongThang = Double.Parse(Console.ReadLine());

        }

        public new void Xuat()

        {

            base.Xuat();

            Console.WriteLine("Luong Thang: {0}", LuongThang);

            Console.WriteLine();

        }

        public double TongPTN()

        {

            return (LuongThang);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            int n, p, r;

            Console.Write("Nhap so luong Nha Khoa Hoc: "); n = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so luong Nha Quan Ly: "); p = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so luong Nhan Vien Phong Thi Nghiem: "); r = Int32.Parse(Console.ReadLine());

            KhoaHoc[] kh = new KhoaHoc[n];

            {

                Console.WriteLine("Nhap du lieu cho cac Nha Khoa Hoc");

                for (int i = 0; i < n; i++)

                {

                    kh[i] = new KhoaHoc();

                    kh[i].Nhap();

                    Console.WriteLine();

                }

            }

            QuanLy[] ql = new QuanLy[p];

            {

                Console.WriteLine("Nhap du lieu cho cac Nha Quan Ly");

                for (int j = 0; j < p; j++)

                {

                    ql[j] = new QuanLy();

                    ql[j].Nhap();

                    Console.WriteLine();

                }

            }

            NhanVienPTN[] nv = new NhanVienPTN[r];

            {

                Console.WriteLine("Nhap du lieu cho Nhan Vien Phong Thi Nghiem");

                for (int k = 0; k < r; k++)

                {

                    nv[k] = new NhanVienPTN();

                    nv[k].Nhap();

                    Console.WriteLine();

                }

            }

            Console.Clear();

            for (int i = 0; i < n; i++) kh[i].Xuat();

            for (int j = 0; j < p; j++) ql[j].Xuat();

            for (int k = 0; k < r; k++) nv[k].Xuat();

            double m, q, s;

            m = 0; q = 0; s = 0;

            for (int i = 0; i < n; i++) m = m + kh[i].TongKH();

            for (int j = 0; j < p; j++) q = q + ql[j].TongQL();

            for (int k = 0; k < r; k++) s = s + nv[k].TongPTN();

            Console.WriteLine("Tong luong cua cac Nha Khoa Hoc la: {0}", m);

            Console.WriteLine("Tong luong cua cac Nha Quan Ly la: {0}", q);

            Console.WriteLine("Tong luong cua cac Nhan Vien Phong Thi Nghiem la: {0}", s);

            Console.ReadKey();

        }

    }

}