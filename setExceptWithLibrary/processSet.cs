using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setExceptWithLibrary
{
    public class ProcessSet
    {
        public ProcessSet()
        {

        }

        public HashSet<int> except(HashSet<int> first, HashSet<int> second)
        {
            first.ExceptWith(second);
            return first;
        }

        public HashSet<int> union(HashSet<int> first, HashSet<int> second)
        {
            first.UnionWith(second);
            return first;
        }
    }
}
