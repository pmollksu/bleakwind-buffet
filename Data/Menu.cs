/*
 * Author: Patrick Moll
 * Class name: Menu.cs
 * Purpose: Static class used to define methods which return all possible menu items
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class that provides methods to retrieve all menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the possible Order Item types
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

        /// <summary>
        /// Adds all instances of entrees to a list
        /// </summary>
        /// <returns>An enumerable list of all entrees on the menu</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
            
        }


        /// <summary>
        /// Adds all instances of sides to a list
        /// </summary>
        /// <returns>An enumerable list of all sides on the menu</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach (Size siz in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries() { Size = siz });
                sides.Add(new FriedMiraak() { Size = siz });
                sides.Add(new MadOtarGrits() { Size = siz });
                sides.Add(new VokunSalad() { Size = siz });
            }
            return sides;

        }

        /// <summary>
        /// Adds all instances of drinks to a list
        /// </summary>
        /// <returns>An enumerable list of all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach(Size siz in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice() { Size = siz });
                drinks.Add(new CandlehearthCoffee() { Size = siz });
                drinks.Add(new CandlehearthCoffee() { Size = siz, Decaf = true });
                drinks.Add(new MarkarthMilk() { Size = siz });
                foreach(SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = siz, Flavor = sf });
                }          
                drinks.Add(new WarriorWater() { Size = siz });
            }
            return drinks;

        }

        /// <summary>
        /// Gets all the items in the menu
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }

        /// <summary>
        /// Adds all instances of all menu items to a list
        /// </summary>
        /// <returns>An enumerable list of all menu items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new BriarheartBurger());
            menu.Add(new DoubleDraugr());
            menu.Add(new GardenOrcOmelette());
            menu.Add(new PhillyPoacher());
            menu.Add(new SmokehouseSkeleton());
            menu.Add(new ThalmorTriple());
            menu.Add(new ThugsTBone());
            foreach (Size siz in Enum.GetValues(typeof(Size)))
            {
                menu.Add(new DragonbornWaffleFries() { Size = siz });
                menu.Add(new FriedMiraak() { Size = siz });
                menu.Add(new MadOtarGrits() { Size = siz });
                menu.Add(new VokunSalad() { Size = siz });
            }

            foreach (Size siz in Enum.GetValues(typeof(Size))) 
            {
                menu.Add(new AretinoAppleJuice() { Size = siz });
                menu.Add(new CandlehearthCoffee() { Size = siz });
                menu.Add(new CandlehearthCoffee() { Size = siz, Decaf = true });
                menu.Add(new MarkarthMilk() { Size = siz });
                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    menu.Add(new SailorSoda() { Size = siz, Flavor = sf });
                }
                menu.Add(new WarriorWater() { Size = siz });
            }
            

            return menu;
        }

        /// <summary>
        /// Searches the menu for search matches
        /// </summary>
        /// <param name="terms">Ther terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {

            List<IOrderItem> results = new List<IOrderItem>();

            // null check
            if (terms == null) return All;

            string lowerCaseTerms = terms.ToLower();

            string lowerCaseItem;
            foreach (IOrderItem item in All)
            {
                lowerCaseItem = item.MockToString.ToLower();
                // Add the IOrderItem if the title is a match
                if (lowerCaseItem.Contains(lowerCaseTerms))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="IOrderItems">The collection of menu items to filter</param>
        /// <param name="ratings">The item types to include</param>
        /// <returns>A collection containing only menu items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            // If no filter is specified, just return the provided collection
            if (types == null || types.Count() == 0) return items;

            // Filter the supplied collection of IOrderItems
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (item is Entree && types.Contains("Entree"))
                {
                    results.Add(item);
                }
                else if (item is Side && types.Contains("Side"))
                {
                    results.Add(item);
                }
                else if (item is Drink && types.Contains("Drink"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with prices falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with calories falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }







    }
}
