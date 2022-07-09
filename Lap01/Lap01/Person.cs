using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1a
{
    class Person
    {
        private String SID;
        private String TenSV;

        public Person()
        {
        }

        public Person(string sID, string tenSV)
        {
            SID = sID;
            TenSV = tenSV;
        }

        public string SID1
        {
            get => SID;
            set => SID = value;
        }

        public string TenSV1
        {
            get => TenSV;
            set => TenSV = value;
        }

        public virtual void Show()
        {

        }

    }
}
