using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi18_7
{
    internal class KhachHang
    {

        public virtual void ThongTin()
        {
            Console.WriteLine("Day la khach hang");
        }

    }
    class KhachhangTre : KhachHang
    {
        public override void ThongTin()
        {
            Console.WriteLine("Day la khach hang tre");
        }
    }
    class KhachHangGia : KhachHang
    {
        public override void ThongTin()
        {
            Console.WriteLine("day la khach hang gia");
        }
    }
}
