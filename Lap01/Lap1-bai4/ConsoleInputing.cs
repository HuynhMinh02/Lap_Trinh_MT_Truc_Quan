using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class ConsoleInputing
    {

        public Person Input()
        {
            Person person = null;
            try
            {
                Console.WriteLine("Ho Ten: ");
                String Hoten = Console.ReadLine();
                Console.WriteLine("Nam Sinh: ");
                int NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bang cap: ");
                String BangCap = Console.ReadLine();
                Console.WriteLine("WHO ARE YOU ? 1 - Nha Khoa Hoc,  2 - Quan Li, 3 - Nhan Vien ");
                int key = Convert.ToInt32(Console.ReadLine());

                if (key == 1)
                {
                    Console.WriteLine("Chuc vu: ");
                    String chucVu = Console.ReadLine();
                    Console.WriteLine("So Bai Bao Da Cong Bo: ");
                    int soBaiBao = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bac Luowg: ");
                    double bacLuong = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("So Ngay Cong Trong Thang: ");
                    double soNgayCong = Convert.ToSingle(Console.ReadLine());

                    person = new NhaKhoaHoc(Hoten, NamSinh, BangCap, chucVu, soBaiBao, bacLuong, soNgayCong);
                }

                else if (key == 2)
                {
                    Console.WriteLine("Chuc vu: ");
                    String chucVu = Console.ReadLine();
                    Console.WriteLine("Bac Luowg: ");
                    double bacLuong = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("So Ngay Cong Trong Thang: ");
                    double soNgayCong = Convert.ToSingle(Console.ReadLine());

                    person = new QuanLi(Hoten, NamSinh, BangCap, chucVu, bacLuong, soNgayCong);
                }
                else if (key == 3)
                {
                    Console.WriteLine("Luong Thang: ");
                    double luongThang = Convert.ToSingle(Console.ReadLine());

                    person = new NhanVien(Hoten, NamSinh, BangCap, luongThang);
                }
                else
                {
                    Console.WriteLine("Nhap sai roi ban oi!!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }
            return person;
        }
    }
}
