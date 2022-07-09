using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class NhaKhoaHoc : Person
    {
        private String chucVu;
        private int soBaiBao;
        private double soNgayCong, bacLuong;
        private double luongNKH;


        public NhaKhoaHoc()
        {

        }

        public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu, int soBaiBao, double soNgayCong, double bacLuong) : base(hoTen, namSinh, bangCap)
        {
            this.chucVu = chucVu;
            this.soBaiBao = soBaiBao;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }

        public override void Show()
        {
            Console.WriteLine($"{HoTen1} - {NamSinh1} - {BangCap1} - {chucVu} - {soBaiBao} - {bacLuong} - {soNgayCong} ", "Luong = " + luongNKH);
        }

        public override void tinhLuong()
        {
            luongNKH = soNgayCong * bacLuong;
        }
    }
}
