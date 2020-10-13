using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyCollectionChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }


        [Fact]
        public void AddingItemsShouldupdateSubTotal()
        {
            var order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            SailorSoda ss = new SailorSoda();

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(bb);

            });
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(ss);

            });
            double expectedSubtotal = bb.Price + ss.Price;
            Assert.Equal(expectedSubtotal, order.Subtotal);

        }

        [Fact]
        public void RemovingItemShouldupdateSubTotal()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            order.Add(fm);
            order.Add(ss);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(fm);
            });

            Assert.Equal(ss.Price, order.Subtotal);

        }

        [Fact]
        public void AddingItemsShouldupdateTax()
        {
            var order = new Order();
            DoubleDraugr dd = new DoubleDraugr();
            MadOtarGrits mad = new MadOtarGrits();

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(dd);
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(mad);
            });

            double expectedTax = Math.Round((dd.Price + mad.Price) * order.SalesTaxRate, 2);
            Assert.Equal(expectedTax, order.Tax);

        }

        [Fact]
        public void RemovingItemsShouldupdateTax()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            PhillyPoacher pp = new PhillyPoacher();
            order.Add(fm);
            order.Add(pp);


            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(fm);
            });

            double expectedTax = Math.Round(pp.Price * order.SalesTaxRate, 2);
            Assert.Equal(expectedTax, order.Tax);
        }

        [Fact]
        public void AddingItemsShouldupdateTotal()
        {
            var order = new Order();
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(vs);
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(gorc);
            });

            double expectedTotal = Math.Round(((gorc.Price + vs.Price) * order.SalesTaxRate) + (gorc.Price + vs.Price), 2);
            Assert.Equal(expectedTotal, order.Total);

        }

        [Fact]
        public void RemovingItemsShouldupdateTotal()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            PhillyPoacher pp = new PhillyPoacher();
            order.Add(fm);
            order.Add(pp);


            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(fm);
            });

            double expectedTotal = Math.Round(((pp.Price) * order.SalesTaxRate) + (pp.Price), 2);
            Assert.Equal(expectedTotal, order.Total);
        }

        [Fact]
        public void AddingItemsShouldupdateCalories()
        {
            var order = new Order();
            GardenOrcOmelette gorc = new GardenOrcOmelette();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(vs);
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(gorc);
            });


        }

        [Fact]
        public void RemovingItemsShouldNotifyCalories()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            PhillyPoacher pp = new PhillyPoacher();
            order.Add(fm);
            order.Add(pp);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(fm);
            });

        }

        [Fact]
        public void ClearingItemsShouldNotifyOrder()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            PhillyPoacher pp = new PhillyPoacher();
            order.Add(fm);
            order.Add(pp);

            Assert.PropertyChanged(order, "Calories", () =>
           {
               order.Clear();
           });
            order.Add(fm);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Clear();
            });
            order.Add(pp);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Clear();
            });
            order.Add(fm);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Clear();
            });

            Assert.Empty(order);

        }

        [Fact]
        public void AddingItemsShouldNotifyCollection()
        {
            var order = new Order();
            ThalmorTriple tt = new ThalmorTriple();
            order.Add(tt);
            Assert.Collection(order, item => Assert.Contains("Thalmor Triple", tt.ToString()));
        }

        [Fact]

        public void OrderShouldContainItemAdded()
        {
            var order = new Order();
            ThugsTBone tb = new ThugsTBone();
            order.Add(tb);
            Assert.Contains(tb, order);
        }

        [Fact]

        public void OrderShouldReturnItemCount()
        {
            var order = new Order();
            ThugsTBone tb = new ThugsTBone();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            order.Add(tb);
            order.Add(ss);
            Assert.Equal(2, order.Count);
        }       

        [Fact]
        public void ShouldBeAbleToSetSalesTax()
        {
            var order = new Order();
            order.SalesTaxRate = .15;
            Assert.Equal(.15, order.SalesTaxRate);
        }

        [Fact]
        public void ChangingPriceNotifiesProperties()
        {
            var order = new Order();
            FriedMiraak fm = new FriedMiraak();
            order.Add(fm);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                fm.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                fm.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                fm.Size = Size.Small;
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                fm.Size = Size.Medium;
            });
            Assert.PropertyChanged(fm, "Calories", () =>
            {
                fm.Size = Size.Medium;
            });
        }








    }
}
