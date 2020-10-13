/*
 * Author: Patrick Moll
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to define properties and preferences of a candlehearth coffee
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee: Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }


        private bool ice = false;
        /// <summary>
        /// Gets the customer ice preference
        /// </summary>
        public bool Ice 
        {
            get => ice;
            set 
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            } 
        }

        private bool roomforcream = false;
        /// <summary>
        /// If the customer wants room for cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomforcream;
            set
            {
                roomforcream = value;
                InvokePropertyChanged("RoomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }


        private bool decaf = false;
        /// <summary>
        /// If the customer wants decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                InvokePropertyChanged("Decaf");
                InvokePropertyChanged("SpecialInstructions");
                InvokePropertyChanged("MockToString");
            }
        }


        /// <summary>
        /// Adds ice to list if customer wants ice
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name, caffeination and size of the drink
        /// </summary>
        /// <returns>[Size] [Caffeination] Candlehearth Coffee</returns>
        public override string ToString()
        {
            if (Decaf)
                return Size + " Decaf Candlehearth Coffee";
            else
                return Size + " Candlehearth Coffee";
        }
    }
}
