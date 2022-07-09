using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1a
{
    internal class StudentService
    {
        private List<Student> listStudent;
        private Student student;
        private String input;

        public StudentService()
        {
            listStudent = new List<Student>
            {
                new Student("1", "Nguyen Van A", "CNTT", (float)9.5),
                new Student("2", "Le Van B", "CNTT", (float)8.2),
                new Student("3", "Tran Thi C", "CNTT", (float)6.5),
                new Student("4", "Huynh Thi D", "CNTT", (float)5.0)
            };
        }

        public void Nhap1SV()
        {
            Console.Write("MSSV: ");
            student.SID1 = Console.ReadLine();
            Console.Write("TEN SV: ");
            student.TenSV1 = Console.ReadLine();
            Console.Write("KHOA: ");
            student.KHOA = Console.ReadLine();
            Console.Write("DIEM TB: ");
            student.DiemTb = Convert.ToSingle(Console.ReadLine());
        }

        public void NhapDSSV()
        {
            Console.Write("Nhap so luong sinh vien muon them: ");
            input = Console.ReadLine();

            for (int i = 0; i < Convert.ToInt32(input); i++)
            {
                student = new Student();
                Nhap1SV();
                listStudent.Add(student);
            }
        }

        public void XUATDS()
        {
            foreach (var x in listStudent)
            {
                x.Show();
            }
        }
    }
}
