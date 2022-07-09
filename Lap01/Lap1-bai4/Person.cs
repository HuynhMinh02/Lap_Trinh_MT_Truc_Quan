using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_bai4
{
    internal class Person
    {
        private String HoTen;
        private int NamSinh;
        private String BangCap;

        public Person()
        {

        }

        public Person(string hoTen, int namSinh, string bangCap)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
        }

        public string HoTen1
        {
            get => HoTen;
            set => HoTen = value;
        }

        public int NamSinh1
        {
            get => NamSinh;
            set => NamSinh = value;
        }

        public string BangCap1
        {
            get => BangCap;
            set => BangCap = value;
        }

        public virtual void Show()
        {

        }

        public virtual void tinhLuong()
        {

        }

    }
}
