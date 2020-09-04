﻿/*
 * Author: Patrick Moll 
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.True(gorc.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Broccoli = false;
            Assert.False(gorc.Broccoli);
            gorc.Broccoli = true;
            Assert.True(gorc.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Mushrooms = false;
            Assert.False(gorc.Mushrooms);
            gorc.Mushrooms = true;
            Assert.True(gorc.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Tomato = false;
            Assert.False(gorc.Tomato);
            gorc.Tomato = true;
            Assert.True(gorc.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Cheddar = false;
            Assert.False(gorc.Cheddar);
            gorc.Cheddar = true;
            Assert.True(gorc.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.Equal(4.57, gorc.Price);
             
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.Equal((uint)404, gorc.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            gorc.Broccoli = includeBroccoli;
            gorc.Mushrooms = includeMushrooms;
            gorc.Tomato = includeTomato;
            gorc.Cheddar = includeCheddar;

            if (!gorc.Broccoli) Assert.Contains("Hold broccoli", gorc.SpecialInstructions);
            if (!gorc.Mushrooms) Assert.Contains("Hold mushrooms", gorc.SpecialInstructions);
            if (!gorc.Tomato) Assert.Contains("Hold tomato", gorc.SpecialInstructions);
            if (!gorc.Cheddar) Assert.Contains("Hold cheddar", gorc.SpecialInstructions);
            if (gorc.Cheddar && gorc.Mushrooms && gorc.Tomato && gorc.Cheddar) Assert.Empty(gorc.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", gorc.ToString());
        }
    }
}