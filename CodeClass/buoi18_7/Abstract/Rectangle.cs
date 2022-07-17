using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {
            m_Height = 20;
            m_Width = 30;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area = {0}", m_Height * m_Width);
        }
        public override void CalculateCircumference()
        {
            Console.WriteLine("Circumference =  {0}", (m_Height + m_Width) * 2);
        }

    }
}
