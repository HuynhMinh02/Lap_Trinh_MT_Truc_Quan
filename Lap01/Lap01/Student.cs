using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lap1a
{
    internal class Student : Person
    {
        private String Khoa;
        private float diemTB;

        public Student()
        {
        }

        public Student(string sID, string tenSV, string khoa, float diemTb) : base(sID, tenSV)
        {
            Khoa = khoa;
            diemTB = diemTb;
        }

        public string KHOA
        {
            get => Khoa;
            set => Khoa = value;
        }

        public float DiemTb
        {
            get => diemTB;
            set => diemTB = value;
        }

        public override void Show()
        {
            Console.WriteLine($"{SID1}  |  {TenSV1}  --  {KHOA}  -- {DiemTb}");
        }
    }

}

