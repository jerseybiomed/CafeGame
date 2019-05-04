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
        public Ingredient Ingredient { get; private set; }
        public int Count { get; private set; }

        public Storage(out Phone phon)
        {
            phon = new Phone(this);
        }
    }
}
