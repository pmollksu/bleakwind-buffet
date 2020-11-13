/*
 * Author: Patrick Moll
 * Class name: MarkartMilk.cs
 * Purpose: Class used to define properties and preferences of a markart milk
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk: Drink, IOrderItem, INotifyPropertyChanged
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
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
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
        /// <returns>[Size] Markarth Milk</returns>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }

        /// <summary>
        /// Description of the drink
        /// </summary>
        public string Description
        {
            get => "Hormone-free organic 2% milk.";
        }
    }
}
