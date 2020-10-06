using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        private List<Constr> list = new List<Constr>();
       // public List<Constr> GetList()
      //  {
      //      return list;
      //  }
       public void AddAddress(Constr c)
       {
            list.Add(c);

       }
        public List<Constr> ViewAddressBook()
        {
            return list;
        }
    }
}