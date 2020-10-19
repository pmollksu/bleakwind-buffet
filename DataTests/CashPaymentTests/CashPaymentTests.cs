/*
 * Author: Patrick Moll
 * Class: CashPaymentTests.cs
 * Purpose: Test functionality of Cash Payments
 */
using PointOfSale;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.CashPaymentTests
{
    public class CashPaymentTests
    {

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            CashDrawer.ResetDrawer();
            var cvm = new CashViewModel(new Order());
            CashDrawer.ResetDrawer();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cvm);
        }

        [Fact]
        public void AddingBillsDecreasesAmountDue()
        {
            CashDrawer.ResetDrawer();
            var ord = new Order();
            ord.Add(new BriarheartBurger());
            var cvm = new CashViewModel(ord);
            cvm.Ones += 4;
            double expected = Math.Round(ord.Total - 4.0,2);
            Assert.Equal(expected, cvm.AmountDue);

        }
        [Fact]
        public void AmountTenderedShouldBeCorrect()
        {
            CashDrawer.ResetDrawer();
            var cvm = new CashViewModel(new Order());
            cvm.Hundreds += 1;
            cvm.Twos += 2;
            cvm.Quarters += 1;
            cvm.Nickels += 1;
            cvm.Pennies += 4;
            Assert.Equal(104.34, cvm.AmountTendered);
        }

        [Fact]
        public void CorrectChangeShouldBeReturned()
        {
            CashDrawer.ResetDrawer();
            var ord = new Order();
            ord.Add(new DoubleDraugr());
            var cvm = new CashViewModel(ord);
            cvm.Twenties += 1;
            double expected = Math.Round(20.00 - ord.Total,2);
            Assert.Equal(expected, cvm.AmountOwed);
        }

        [Fact]
        public void FinalizingSaleShouldHaveCorrectBillAmounts()
        {
            CashDrawer.ResetDrawer();
            var ord = new Order();
            ord.Add(new SmokehouseSkeleton());
            var cvm = new CashViewModel(ord);
            int initalTwenties = CashDrawer.Twenties;
            int initalTens = CashDrawer.Tens;
            int initalOnes = CashDrawer.Ones;
            int initalHalfDollar = CashDrawer.HalfDollars;
            int initalDimes = CashDrawer.Dimes;
            int initalPennies = CashDrawer.Pennies;
            cvm.Twenties += 1;
            cvm.FinalizeSale();
            Assert.Equal(initalTwenties, CashDrawer.Twenties - 1);
            Assert.Equal(initalTens, CashDrawer.Tens + 1);
            Assert.Equal(initalOnes, CashDrawer.Ones + 3);
            Assert.Equal(initalHalfDollar, CashDrawer.HalfDollars + 1);
            Assert.Equal(initalDimes, CashDrawer.Dimes + 2);
            Assert.Equal(initalPennies, CashDrawer.Pennies + 1);


        }

        [Fact]
        public void SettingBillsShouldNotifyProperties()
        {
            CashDrawer.ResetDrawer();
            var ord = new Order();
            ord.Add(new PhillyPoacher());
            var cvm = new CashViewModel(ord);
            Assert.PropertyChanged(cvm, "Pennies", () =>
            {
                cvm.Pennies += 1;
            });
            Assert.PropertyChanged(cvm, "AmountTendered", () =>
            {
                cvm.Ones += 1;
            });
            Assert.PropertyChanged(cvm, "AmountDue", () =>
            {
                cvm.Nickels += 1;
            });
            Assert.PropertyChanged(cvm, "AmountOwed", () =>
            {
                cvm.Twenties += 1;
            });
            Assert.PropertyChanged(cvm, "FiftiesOwed", () =>
            {
                cvm.Fifties += 1;
            });

        }
    }
}
