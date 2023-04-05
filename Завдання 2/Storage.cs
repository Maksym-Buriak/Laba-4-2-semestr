using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    internal class StoragePhone
    {
        private List<Phone> phones = new List<Phone>();

        public void AddPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public void RemovePhone(Phone phone)
        {
            phones.Remove(phone);
        }

        public int PrintTotalPhonesCount() 
        {
            return phones.Count;
        }

        public List<Phone> PrintAllPhones()
        {
            return phones;
        }
    }

    internal class StorageSmartphone
    {
        private List<Smartphone> smartphones = new List<Smartphone>();

        public void AddSmartphone(Smartphone smartphone)
        {
            smartphones.Add(smartphone);
        }

        public void RemoveSmartphone(Smartphone smartphone)
        {
            smartphones.Remove(smartphone);
        }

        public int PrintTotalSmartphonesCount()
        {
            return smartphones.Count;
        }

        public List<Smartphone> PrintAllSmartphones()
        {
            return smartphones;
        }
    }
}
