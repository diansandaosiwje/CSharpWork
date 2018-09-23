using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModeFactoryOfGraph
{
    public abstract class BaseChart
    {
        public abstract double Area
        {
            get;
        }
        
        public virtual void Init() { }

    }

}
