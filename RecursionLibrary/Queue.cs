using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionLibrary
{
    public class Queue
    {
        public object current;
        public Queue next;

        public Queue(object link)
        {
            current = link;
        }

        public void add(object link)
        {
            if (next == null) next = new Queue(link);
            else next.add(link);
        }
    }
}
