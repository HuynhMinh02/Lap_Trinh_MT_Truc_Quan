using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_b4
{
    internal class VienKhoaHoc
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
}
