using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class ServiceVienKhoaHoc
    {
        private ArrayList listperson = new ArrayList();
        private Person p = new Person();
        private ConsoleInputing input = new ConsoleInputing();

        public ServiceVienKhoaHoc()
        {
            listperson = new ArrayList()
            {

                new NhaKhoaHoc("Nguyen Van A" , 1980 , "Cu Nhan" , "null" ,20 , 30.5 , 1000 ),
                new QuanLi("Le Thi B" , 1982 , "Thac Si" , "null" ,500 , 30 ),
                new NhanVien("Tran Van C" , 1992 , "Cu Nhan" , 2000 ),
                new NhaKhoaHoc("Pham Nhat Vuong" , 1985 , "Cu Nhan" , "null" ,20 , 30 , 1000 )
            };

        }

        public void add()
        {


            Console.Write("Nhap so luong nguoi trong vien muon them: ");
            String n = Console.ReadLine();

            for (int i = 0; i < Convert.ToInt32(n); i++)
            {
                p = new Person();
                input.Input();
                listperson.Add(p);
            }

        }

        public void addNKH()
        {
            int nkh;
            Console.WriteLine("Nhap so Nha Khoa Hoc Ban Muon Them: ");
            nkh = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Convert.ToInt32(nkh); i++)
            {
                p = new Person();
                input.Input();
                listperson.Add(p);
            }

        }

        public void addQL()
        {
            int ql;
            Console.WriteLine("Nhap so Nha Quan Li Ban Muon Them: ");
            ql = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Convert.ToInt32(ql); i++)
            {
                p = new Person();
                input.Input();
                listperson.Add(p);
            }

        }
        public void addNV()
        {
            int nv;
            Console.WriteLine("Nhap so Nhan Vien Phong Thi Nghiem Ban Muon Them: ");
            nv = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Convert.ToInt32(nv); i++)
            {
                p = new Person();
                input.Input();
                listperson.Add(p);
            }

        }

        public void Output()
        {
            foreach (Person p in listperson)
            {
                Console.WriteLine(p);
            }
        }

    }
}
