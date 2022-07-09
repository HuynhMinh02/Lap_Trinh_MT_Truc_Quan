using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_b4
{
    internal class KhoaHoc : VienKhoaHoc
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
}
