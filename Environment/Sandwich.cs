using Cafe.Environment.Ingredients;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cafe.Environment
{
    public class Sandwich
    {
        public Bread Bread { get; private set; }
        public Meat Meat { get; private set; }
        public Vegetables Vegetables { get; private set; }
        private Type Expected;
        private Dictionary<Type, Action<Ingredient>> AddIngredient { get; }
        private Dictionary<Type, Type> NextExpected { get; }

        public Sandwich()
        {
            Expected = typeof(Bread);
            AddIngredient = new Dictionary<Type, Action<Ingredient>>
            {
                { typeof(Bread), x => Bread = x as Bread },
                { typeof(Meat), x => Meat = x as Meat },
                { typeof(Vegetables), x => Vegetables = x as Vegetables }
            };
            NextExpected = new Dictionary<Type, Type>
            {
                { typeof(Bread), typeof(Meat) },
                { typeof(Meat), typeof(Vegetables) },
                { typeof(Vegetables), null }
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

        public bool Equals(Sandwich sandwich)
        {
            return !(sandwich is null)
                && Bread.GetType() == sandwich.Bread.GetType()
                && Meat.GetType() == sandwich.Meat.GetType()
                && Vegetables.GetType() == sandwich.Vegetables.GetType();
        }
    }
}
