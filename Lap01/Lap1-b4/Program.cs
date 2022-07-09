using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_b4
{
    class Program

    {

        static void Main(string[] args)

        {

            int n, p, r;

            Console.Write("Nhap so luong Nha Khoa Hoc: "); n = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so luong Nha Quan Ly: "); p = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap so luong Nhan Vien Phong Thi Nghiem: "); r = Int32.Parse(Console.ReadLine());

            KhoaHoc[] kh = new KhoaHoc[n];

            {

                Console.WriteLine("Nhap du lieu cho cac Nha Khoa Hoc");

                for (int i = 0; i < n; i++)

                {

                    kh[i] = new KhoaHoc();

                    kh[i].Nhap();

                    Console.WriteLine();

                }

            }

            QuanLi[] ql = new QuanLi[p];

            {

                Console.WriteLine("Nhap du lieu cho cac Nha Quan Ly");

                for (int j = 0; j < p; j++)

                {

                    ql[j] = new QuanLi();

                    ql[j].Nhap();

                    Console.WriteLine();

                }

            }

            NhanVienPTN[] nv = new NhanVienPTN[r];

            {

                Console.WriteLine("Nhap du lieu cho Nhan Vien Phong Thi Nghiem");

                for (int k = 0; k < r; k++)

                {

                    nv[k] = new NhanVienPTN();

                    nv[k].Nhap();

                    Console.WriteLine();

                }

            }

            Console.Clear();

            for (int i = 0; i < n; i++) kh[i].Xuat();

            for (int j = 0; j < p; j++) ql[j].Xuat();

            for (int k = 0; k < r; k++) nv[k].Xuat();

            double m, q, s;

            m = 0; q = 0; s = 0;

            for (int i = 0; i < n; i++) m = m + kh[i].TongKH();

            for (int j = 0; j < p; j++) q = q + ql[j].TongQL();

            for (int k = 0; k < r; k++) s = s + nv[k].TongPTN();

            Console.WriteLine("Tong luong cua cac Nha Khoa Hoc la: {0}", m);

            Console.WriteLine("Tong luong cua cac Nha Quan Ly la: {0}", q);

            Console.WriteLine("Tong luong cua cac Nhan Vien Phong Thi Nghiem la: {0}", s);

            Console.ReadKey();

        }

    }
}
