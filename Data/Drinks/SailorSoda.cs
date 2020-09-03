﻿/*
 * Author: Patrick Moll
 * Class name: SailorSoda.cs
 * Purpose: Class used to define properties and preferences of a sailor soda
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price 
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
        public uint Calories
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

        /// <summary>
        /// Gets the size of the drink using Size enum
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the customer ice preference
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the flavor of Sailor Soda customer wants
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <summary>
        /// Adds ice to hold if customer doesn't want ice.
        /// </summary>
        public List<string> SpecialInstructions
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

    }
}
