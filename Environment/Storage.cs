﻿using Cafe.Environment.Ingredients;
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

        public Phone Button { get; set; }

        public Storage(Ingredient ingredient, int count)
        {
            Ingredient = ingredient;
            Count = count;
            Button = new Phone(this);
        }

        public Ingredient GetIngredient()
        {
            if (Count > 0)
            {
                --Count;
                return Ingredient;
            }
            return null;
        }
    }
}
