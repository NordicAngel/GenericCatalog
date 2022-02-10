using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCatalog
{
    class Catalog<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _catalog;

        public Catalog()
        {
            _catalog = new Dictionary<TKey, TValue>();
        }

        public List<TValue> All => _catalog.Values.ToList();
        public int Count => _catalog.Count;

        public void Insert(TKey uniqueIdentifier, TValue item)
        {
            if (!_catalog.ContainsKey(uniqueIdentifier))
            {
                _catalog.Add(uniqueIdentifier, item);
            }
        }

        public void Delete(TKey uniqueIdentifier)
        {
            _catalog.Remove(uniqueIdentifier);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join("\n",_catalog.Values));
        }
    }
}
