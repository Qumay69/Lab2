using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class SortArray : IArray
    {
        private List<int> elements;

        public SortArray(IEnumerable<int> elements)
        {
            this.elements = elements.ToList();
        }

        public void Add(IArray other)
        {
            if (other is SortArray otherSortArray)
            {
                elements = elements.Union(otherSortArray.Elements).ToList();
            }
        }

        public void Foreach()
        {
            elements.Sort();
        }

        public List<int> Elements => elements;
    }
}
