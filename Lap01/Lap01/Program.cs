using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lap1a;

namespace Lap01
{

    class Tester
    {
        public static void Main()
        {
            StudentService studentService = new StudentService();

            do
            {
                Console.WriteLine("<<<<<<<<<<<<<<<<QUAN LI SINH VIEN >>>>>>>>>>>>>>");
                Console.WriteLine(" 1>>  THEM SINH VIEN  ");
                Console.WriteLine(" 2>>  XUAT DANH SACH SINH VIEN ");
                Console.WriteLine(" 3>>  THOAT ! CAM ON DA SU DUNG CHUONG TRINH");
                Console.WriteLine("  Moi ban chon chuc nang !!!!");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        studentService.NhapDSSV();
                        break;
                    case 2:
                        studentService.XUATDS();
                        break;
                    default:
                        break;
                }
            } while (true);

        }

    }
}