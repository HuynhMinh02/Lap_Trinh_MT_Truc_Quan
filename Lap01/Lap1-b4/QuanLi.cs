using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_b4
{
    internal class QuanLi : VienKhoaHoc
    {
        string ChucVu;

        double BacLuong, NgayCong;

        public QuanLi() : base()

        {

            ChucVu = ""; BacLuong = 0; NgayCong = 0;

        }

        public QuanLi(string HoTen, int NamSinh, string BangCap, string ChucVu, double NgayCong, double BacLuong) : base(HoTen, NamSinh, BangCap)

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
}
