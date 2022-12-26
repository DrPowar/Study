using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Test
{
    class Generic_test <T, K, P>
    {
        public T id;
        public K Name;
        public P isWorker;
        public static K Profession;
        public Generic_test(T id, K Name, P isWorker)
        {
            this.id = id;
            this.Name = Name;
            this.isWorker = isWorker;
        }
        public void Renumber(ref Generic_test<T, K, P> Person, T id)
        {
            Person.id = id;
        }
    }
}
