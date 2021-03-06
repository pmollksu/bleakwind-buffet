﻿/*
 * Author: Patrick Moll
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            var mad = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mad);
        }

        [Fact]
        public void ShouldBeAssignabletoAbstractIOrderItemClass()
        {
            var mad = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mad);
        }

        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mad = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mad);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mad = new MadOtarGrits();
            Assert.Equal(Size.Small, mad.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mad = new MadOtarGrits();
            mad.Size = Size.Large;
            Assert.Equal(Size.Large, mad.Size);
            mad.Size = Size.Medium;
            Assert.Equal(Size.Medium, mad.Size);
            mad.Size = Size.Small;
            Assert.Equal(Size.Small, mad.Size);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mad = new MadOtarGrits();

            Assert.PropertyChanged(mad, "Size", () =>
            {
                mad.Size = Size.Small;
            });

            Assert.PropertyChanged(mad, "Size", () =>
            {
                mad.Size = Size.Medium;
            });

            Assert.PropertyChanged(mad, "Size", () =>
            {
                mad.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mad = new MadOtarGrits();
            Assert.Empty(mad.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mad = new MadOtarGrits();
            mad.Size = size;
            Assert.Equal(price, mad.Price);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var mad = new MadOtarGrits();

            Assert.PropertyChanged(mad, "Price", () =>
            {
                mad.Size = Size.Small;
            });

            Assert.PropertyChanged(mad, "Price", () =>
            {
                mad.Size = Size.Medium;
            });

            Assert.PropertyChanged(mad, "Price", () =>
            {
                mad.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mad = new MadOtarGrits();
            mad.Size = size;
            Assert.Equal(calories, mad.Calories);
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var mad = new MadOtarGrits();

            Assert.PropertyChanged(mad, "Calories", () =>
            {
                mad.Size = Size.Small;
            });

            Assert.PropertyChanged(mad, "Calories", () =>
            {
                mad.Size = Size.Medium;
            });

            Assert.PropertyChanged(mad, "Calories", () =>
            {
                mad.Size = Size.Large;
            });
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mad = new MadOtarGrits();
            mad.Size = size;
            Assert.Equal(name, mad.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            var mad = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", mad.Description);
        }
    }
}