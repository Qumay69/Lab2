using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IArray
    {
        void Add(IArray other);
        void Foreach();
        List<int> Elements { get; }
    }
}
