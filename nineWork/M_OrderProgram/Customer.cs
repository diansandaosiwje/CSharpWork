using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M_OrderProgram
{
    public class Customer               //照搬的customer类。。。
    {
        public Customer(){}
        public uint Id { get; set; }       

        public string Name { get; set; }

        private ulong telNum;
        public ulong TelNumber
        {
            get
            {
                return telNum;
            }
            set
            {
                string pattern = "^1[34578][0-9]{9}$";
                if (Regex.IsMatch(value.ToString(), pattern))
                {
                    telNum = value;
                }
                else
                {
                    throw (new Exception("电话号不符合格式"));
                }
            }
        }

        public Customer(uint id,string name,ulong telNumber)
        {
            this.Id = id;
            this.Name = name;
            this.TelNumber = telNumber;
        }

        public override string ToString()
        {
            return $"NAME:{Name}" + $",TEL:{TelNumber}";
        }

    }
}
