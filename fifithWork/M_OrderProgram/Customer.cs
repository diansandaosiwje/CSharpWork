using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    class Customer               //照搬的customer类。。。
    {
        public uint Id { get; set; }       

        public string Name { get; set; }

        public Customer(uint id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"customer:{Id},CustomerName:{Name}";
        }

    }
}
