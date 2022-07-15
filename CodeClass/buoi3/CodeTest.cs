using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    internal class CodeTest
    {
        public class Point
        {
            public int m_x;
            public int m_y;

            public Point()
            {

            }

            public Point(int xx, int yy)
            {
                m_x = xx;
                m_y = yy;
            }

            public static Point operator +(Point p1, Point p2)
            {
                Point p = new Point();
                p.m_x = p1.m_x + p2.m_x;
                p.m_y = p1.m_y + p2.m_y;
                return p;
            }



        }
        public class Tester
        {
            static void Main(string[] args)
            {
                Point op1 = new Point(2, 2);
                Point op2 = new Point(4, 4);

                Point obP = new Point();

                obP = op1 + op2;

                Console.WriteLine("The result is m_x = {0} and m_y = {1}", obP.m_x, obP.m_y);
            }
        }


    }
}
