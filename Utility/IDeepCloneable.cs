using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Utility
{
    public interface IDeepCloneable<T>
    {
        T CreateClone();
    }
}
