using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class XorArray : IArray
    {
        private List<int> elements;

        public XorArray(IEnumerable<int> elements)
        {
            this.elements = elements.ToList();
        }

        public void Add(IArray other)
        {
            if (other is XorArray otherXorArray)
            {
                var maxLength = Math.Max(elements.Count, otherXorArray.Elements.Count);
                var extendedElements = elements.Concat(Enumerable.Repeat(0, maxLength - elements.Count)).ToList();
                var extendedOtherElements = otherXorArray.Elements.Concat(Enumerable.Repeat(0, maxLength - otherXorArray.Elements.Count)).ToList();

                elements = extendedElements.Zip(extendedOtherElements, (a, b) => a ^ b).ToList();
            }
        }

        public void Foreach()
        {
            elements = elements.Select(e => (int)Math.Sqrt(e)).ToList();
        }

        public List<int> Elements => elements;
    }
}

