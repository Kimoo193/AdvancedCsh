using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return ID.CompareTo(other.ID);
        }
    }

}
