/*
 * Author: Patrick Moll
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void AllEntreesReturnedByEntreeMethod()
        {
            IEnumerable<IOrderItem> e = Menu.Entrees();
            List<IOrderItem> entrees = (List<IOrderItem>)e;

            Assert.Collection(entrees, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                 item => Assert.Contains("Double Draugr", item.ToString()),
                                 item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                 item => Assert.Contains("Philly Poacher", item.ToString()),
                                 item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                 item => Assert.Contains("Thalmor Triple", item.ToString()),
                                 item => Assert.Contains("Thugs T-Bone", item.ToString()));

            Assert.Equal(7, entrees.Count);
        }

        [Fact]
        public void AllSidesReturnedByEntreeMethod()
        {
            IEnumerable<IOrderItem> s = Menu.Sides();
            List<IOrderItem> sides = (List<IOrderItem>)s;

            Assert.Collection(sides, item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Small Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Small Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Large Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Large Vokun Salad", item.ToString()));
            Assert.Equal(12, sides.Count);
        }

        [Fact]
        public void AllDrinksReturnedByDrinkMethod()
        {
            IEnumerable<IOrderItem> d = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)d;

            Assert.Collection(drinks, item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Warrior Water", item.ToString()),
                                 item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                 item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Warrior Water", item.ToString()));
            Assert.Equal(33, drinks.Count);
        }

        [Fact]

        public void AllMenuItemsReturnedByFullMenuMethod()
        {
            IEnumerable<IOrderItem> m = Menu.FullMenu();
            List<IOrderItem> menu = (List<IOrderItem>)m;

            Assert.Collection(menu, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                 item => Assert.Contains("Double Draugr", item.ToString()),
                                 item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                 item => Assert.Contains("Philly Poacher", item.ToString()),
                                 item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                 item => Assert.Contains("Thalmor Triple", item.ToString()),
                                 item => Assert.Contains("Thugs T-Bone", item.ToString()),
                                 item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Small Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Small Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Large Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Large Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Warrior Water", item.ToString()),
                                 item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                 item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Warrior Water", item.ToString())
                                );
            Assert.Equal(52, menu.Count);
        }

        [Fact]
        public void FilteringByStringShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> m =  Menu.Search("Cherry");
            List<IOrderItem> menu = (List<IOrderItem>)m;
            Assert.Collection(menu, item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()));
            Assert.Equal(3, menu.Count);

        }

        [Fact]
        public void FilteringByCategoryShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            string[] category = { "Side", "Entree" };
            menu = Menu.FilterByCategory(menu, category);
            Assert.Collection(menu, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                 item => Assert.Contains("Double Draugr", item.ToString()),
                                 item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                 item => Assert.Contains("Philly Poacher", item.ToString()),
                                 item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                 item => Assert.Contains("Thalmor Triple", item.ToString()),
                                 item => Assert.Contains("Thugs T-Bone", item.ToString()),
                                 item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Small Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Small Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Large Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Large Vokun Salad", item.ToString()));

            Assert.Equal(19, menu.Count());

        }


        [Fact]
        public void FilteringByCaloriesShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByCalories(menu, 200, 410);
            Assert.Collection(menu, item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                    item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                                    item => Assert.Contains("Large Fried Miraak", item.ToString()),
                                    item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString())
                                    );
            Assert.Equal(9, menu.Count());
        }

        [Fact]
        public void FilteringByCaloriesNoMinShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByCalories(menu, null, 10);
            Assert.Collection(menu, item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                                    item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                                    item => Assert.Contains("Small Warrior Water", item.ToString()),
                                    item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                                    item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                                    item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                    item => Assert.Contains("Large Warrior Water", item.ToString()));
            Assert.Equal(7, menu.Count());
        }

        [Fact]
        public void FilteringByCaloriesNoMaxShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByCalories(menu, 930, null);
            Assert.Collection(menu, item => Assert.Contains("Thalmor Triple", item.ToString()),
                                    item => Assert.Contains("Thugs T-Bone", item.ToString())
                                   );
            Assert.Equal(2, menu.Count());

        }

        [Fact]
        public void FilteringByPriceShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByPrice(menu, 5.50, 8.25);
            Assert.Collection(menu, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                item => Assert.Contains("Double Draugr", item.ToString()),
                                item => Assert.Contains("Philly Poacher", item.ToString()),
                                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                item => Assert.Contains("Thugs T-Bone", item.ToString()));
            Assert.Equal(5, menu.Count());

        }

        [Fact]
        public void FilteringByPriceNoMinShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByPrice(menu, null, .10);
            Assert.Collection(menu, item => Assert.Contains("Small Warrior Water", item.ToString()),
                                    item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                    item => Assert.Contains("Large Warrior Water", item.ToString()));

            Assert.Equal(3, menu.Count());
        }

        [Fact]
        public void FilteringByPriceNoMaxShouldReturnCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.FilterByPrice(menu, 8.00, null);
            Assert.Collection(menu, item => Assert.Contains("Thalmor Triple", item.ToString()));
        }

        [Fact]
        public void NullFilterResultsShouldNotChangeFilterResults()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            menu = Menu.Search(null);
            menu = Menu.FilterByCategory(menu, null);
            menu = Menu.FilterByCalories(menu,null,null);
            menu = Menu.FilterByPrice(menu, null,null);
            Assert.Equal(52, menu.Count());

        }
    }
}
