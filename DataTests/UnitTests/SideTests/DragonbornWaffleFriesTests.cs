/*
 * Author: Patrick Moll
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeAssignabletoAbstractIOrderItemClass()
        {
            var wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(wf);
        }

        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(wf);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
            
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Small;
            });

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Size", () =>
            {
                wf.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Small;
            });

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Price", () =>
            {
                wf.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var wf = new DragonbornWaffleFries();

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Small;
            });

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Medium;
            });

            Assert.PropertyChanged(wf, "Calories", () =>
            {
                wf.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }
    }
}