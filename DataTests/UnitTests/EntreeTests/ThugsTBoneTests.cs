/*
 * Author: Patrick Moll
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAssignabletoAbstractIOrderItemClass()
        {
            var tbone = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tbone);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tbone);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal(6.44, tbone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal((uint)982, tbone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Empty(tbone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tbone.ToString());
        }
    }
}