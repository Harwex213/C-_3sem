using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class University : IEnumerable<Student>
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public University()
        {
            Students.Add(new Student("Oleg", "POIT"));
            Students.Add(new Student("Igor", "ISIT"));
            Students.Add(new Student("Max", "POIT"));
            Students.Add(new Student("Kasimir", "ISIT"));
            Students.Add(new Student("Nikita", "POIT"));
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return Students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Students.GetEnumerator();
        }
    }
}
