using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAssignabletoAbstractIOrderItemClass()
        {
            var combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            var combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

        [Fact]
        public void settingEntreeShouldNotifyProperties()
        {
            var combo = new Combo();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void settingDrinkShouldNotifyProperties()
        {
            var combo = new Combo();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new SailorSoda();
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = new WarriorWater();
            });
        }

        [Fact]
        public void settingSideShouldNotifyProperties()
        {
            var combo = new Combo();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new FriedMiraak();
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new VokunSalad();
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });

        }

        [Fact]
        public void priceShouldHaveDollarDiscount()
        {
            var combo = new Combo();
            combo.Drink = new AretinoAppleJuice();
            combo.Entree = new DoubleDraugr();
            combo.Side = new FriedMiraak();

            double expectedPrice = Math.Round(combo.Drink.Price + combo.Entree.Price + combo.Side.Price - 1.0, 2);
            Assert.Equal(expectedPrice, combo.Price);
        }

        [Fact]
        public void CaloriesShouldTotalAllItems()
        {
            var combo = new Combo();
            combo.Drink = new AretinoAppleJuice();
            combo.Entree = new DoubleDraugr();
            combo.Side = new FriedMiraak();

            uint expectedCal = combo.Drink.Calories + combo.Entree.Calories + combo.Side.Calories;
            Assert.Equal(expectedCal, combo.Calories);
        }

        [Fact]
        public void SpecialInstructionsShouldCombineItems()
        {
            var combo = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            combo.Drink = aj;
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            dd.Mayo = false;
            combo.Entree = dd;
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Medium;
            combo.Side = fm;

            List<string> expected = new List<string>();
            expected.Add(dd.ToString());
            expected.AddRange(dd.SpecialInstructions);
            expected.Add(fm.ToString());
            expected.AddRange(fm.SpecialInstructions);
            expected.Add(aj.ToString());
            expected.AddRange(aj.SpecialInstructions);

            Assert.Equal(expected, combo.SpecialInstructions);
        }
    }
}
