using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class Customer
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public void DeleteAddress(int index)
        {
            Addresses.RemoveAt(index);
        }

        public void InsertAddress(int index, Address address)
        {
            Addresses.Insert(index, address);
        }
    }
}
