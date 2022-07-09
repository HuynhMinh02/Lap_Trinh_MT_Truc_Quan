using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class QuanLi : Person
    {
        private String chucVu;
        private double bacLuong;
        private double soNgayCong;
        private double luongQL;

        public QuanLi()
        {

        }

        public QuanLi(string hoTen, int namSinh, string bangCap, string chucVu, double bacLuong, double soNgayCong) : base(hoTen, namSinh, bangCap)
        {
            this.chucVu = chucVu;
            this.bacLuong = bacLuong;
            this.soNgayCong = soNgayCong;
        }

        public override void Show()
        {
            Console.WriteLine($"{HoTen1} - {NamSinh1} - {BangCap1} - {chucVu} - {bacLuong} - {soNgayCong}", "Luong = " + luongQL);

        }

        public override void tinhLuong()
        {
            luongQL = soNgayCong * bacLuong;
        }
    }
}

