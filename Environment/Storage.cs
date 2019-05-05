using Cafe.Environment.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Environment
{
    public class Storage
    {
        public class Phone
        {
            private Storage Storage { get; }

            public Phone(Storage storage)
            {
                Storage = storage;
            }

            public void Replenish() =>
                Storage.Count = Storage.Ingredient.MaxCountOnStorage;
        }

        public Ingredient Ingredient { get; private set; }
        public int Count { get; private set; }

        public Storage(out Phone phone)
        {
            phone = new Phone(this);
        }
    }
}
