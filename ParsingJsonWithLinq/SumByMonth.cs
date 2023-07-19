using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingJsonWithLinq
{
    public record SumByMonth(int Month, int Sum)
    {
        public override string ToString()
        {
            return $"{Month}: {Sum}";
        }
    }
}
