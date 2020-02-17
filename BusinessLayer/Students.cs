using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Students : ICollection<Student>
    {
        public List<Student> StuList = new List<Student>();


        public int Count
        {
            get { return StuList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Student item)
        {
            StuList.Add(item);
        }

        public void Clear()
        {
            StuList.Clear();
        }

        public bool Contains(Student item)
        {
           return StuList.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return StuList.GetEnumerator();
        }

        public bool Remove(Student item)
        {
            return StuList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
