using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Environment
{
    public class Phone
    {
        private Storage Storage { get; }

        public Phone(Storage storage)
        {
            Storage = storage;
        }
    }
}
