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

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class that provides methods to retrieve all menu items
    /// </summary>
    public static class Menu
    {
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
        
        


    }
}
