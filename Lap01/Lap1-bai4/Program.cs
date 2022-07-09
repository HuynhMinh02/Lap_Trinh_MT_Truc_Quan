using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lap1_bai4
{
    class MainVienKhoaHoc

    {
        public static void Main()
        {
            ServiceVienKhoaHoc serviceVienKhoaHoc = new ServiceVienKhoaHoc();

            do
            {
                Console.WriteLine("<<<<<<<<<<<<<<<<QUAN LI VIEN KHOA HOC >>>>>>>>>>>>>>");
                Console.WriteLine(" 1>>  THEM THONG TIN NGUOI TRONG VIEN  ");
                Console.WriteLine(" 2>  THEM THONG TIN NHA KHOA HOC  ");
                Console.WriteLine(" 3>  THEM THONG TIN NHA QUAN LI  ");
                Console.WriteLine(" 4>  THEM THONG TIN NHAN VIEN PHONG THI NGHIEM  ");
                Console.WriteLine(" 5>>  XUAT DANH SACH NGUOI TRONG VIEN ");
                Console.WriteLine(" 6>>  THOAT ! CAM ON DA SU DUNG CHUONG TRINH");
                Console.WriteLine("  Moi ban chon chuc nang !!!!");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        serviceVienKhoaHoc.add();
                        break;
                    case 2:
                        serviceVienKhoaHoc.addNKH();
                        break;
                    case 3:
                        serviceVienKhoaHoc.addQL();
                        break;
                    case 4:
                        serviceVienKhoaHoc.addNV();
                        break;
                    case 5:
                        serviceVienKhoaHoc.Output();
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
