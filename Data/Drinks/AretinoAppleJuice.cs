/*
 * Author: Patrick Moll
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to define properties and preferences of an aretino apple juice
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        private bool ice = false;
        /// <summary>
        /// Gets the customer ice preference
        /// </summary>
        public bool Ice {
            get => ice;
            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
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
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name and size of the drink
        /// </summary>
        /// <returns>[Size] Arentino Apple Juice</returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
