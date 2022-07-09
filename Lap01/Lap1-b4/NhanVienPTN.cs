using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_b4
{
    internal class NhanVienPTN : VienKhoaHoc
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
}
