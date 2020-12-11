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
        private List<Student> students = new List<Student>();
        public University()
        {
            students.Add(new Student("Oleg", "POIT"));
            students.Add(new Student("Igor", "ISIT"));
            students.Add(new Student("Max", "POIT"));
            students.Add(new Student("Kasimir", "ISIT"));
            students.Add(new Student("Nikita", "POIT"));
        }

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
