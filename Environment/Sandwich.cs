using Cafe.Environment.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafe.Environment
{
    public class Sandwich
    {
        public Bread Bread { get; private set; }
        public Meat Meat { get; private set; }
        public Vegetables Vegetables { get; private set; }
        IEnumerator<Type> Expected
        {
            get
            {
                yield return typeof(Bread);
                yield return typeof(Meat);
                yield return typeof(Vegetables);
            }
        }
        Dictionary<Type, Ingredient> FindIngredient { get; }

        public Sandwich()
        {
            Expected.MoveNext();
            FindIngredient = new Ingredient[] { Bread, Meat, Vegetables }.ToDictionary(x => x.GetType());
        }

        public void Add(Ingredient ingredient)
        {
            if (Expected.Current != null)
                if (ingredient.GetType() == Expected.Current)
                {
                    FindIngredient[ingredient.GetType()] = ingredient;
                    Expected.MoveNext();
                }
        }
    }
}
