using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class NhanVien : Person
    {
        private double luongThang = 3000;

        public NhanVien()
        {

        }

        public NhanVien(string hoTen, int namSinh, string bangCap, double luongThang) : base(hoTen, namSinh, bangCap)
        {
            this.luongThang = luongThang;
        }

        public override void Show()
        {
            Console.WriteLine($"{HoTen1} - {NamSinh1} - {BangCap1} - {luongThang} ");
        }

        public override void tinhLuong()
        {

        }
    }
}

