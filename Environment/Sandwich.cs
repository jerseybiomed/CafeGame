using Cafe.Environment.Ingredients;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cafe.Environment.Deal;

namespace Cafe.Environment
{
    public class Sandwich
    {
        public Bread Bread { get; private set; }
        public Meat Meat { get; private set; }
        public Vegetable Vegetables { get; private set; }
        public Type Expected;
        private Dictionary<Type, Action<Ingredient>> AddIngredient { get; }
        private Dictionary<Type, Type> NextExpected { get; }

        public Sandwich()
        {
            Expected = typeof(Bread);
            AddIngredient = new Dictionary<Type, Action<Ingredient>>
            {
                { typeof(Bread), x => Bread = x as Bread },
                { typeof(Meat), x => Meat = x as Meat },
                { typeof(Vegetable), x => Vegetables = x as Vegetable }
            };
            NextExpected = new Dictionary<Type, Type>
            {
                { typeof(Bread), typeof(Meat) },
                { typeof(Meat), typeof(Vegetable) },
                { typeof(Vegetable), null }
            };
        }

        public void Add(Ingredient ingredient)
        {
            if (Expected?.IsInstanceOfType(ingredient) ?? false)
            {
                AddIngredient[Expected](ingredient);
                Expected = NextExpected[Expected];
            }
        }
    }
}
