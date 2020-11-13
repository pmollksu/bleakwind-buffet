/*
 * Author: Patrick Moll
 * Class name: SailorSoda.cs
 * Purpose: Class used to define properties and preferences of a sailor soda
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda: Drink, IOrderItem, INotifyPropertyChanged

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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        private bool ice = true;
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

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Gets the flavor of Sailor Soda customer wants
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                InvokePropertyChanged("Flavor");
                InvokePropertyChanged("MockToString");
            }
        }

        /// <summary>
        /// Adds ice to hold if customer doesn't want ice.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name, size, and flavor of the drink
        /// </summary>
        /// <returns>[Size] [Flavor] Sailor Soda</returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }

        /// <summary>
        /// Description of the drink
        /// </summary>
        public string Description
        {
            get => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
        }

    }
}
