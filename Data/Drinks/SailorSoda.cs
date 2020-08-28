/*
 * Author: Patrick Moll
 * Class name: SailorSoda.cs
 * Purpose: Class used to define properties and preferences of a sailor soda
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffetData.Drinks
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
                if (Size == Size.Small)
                    return 1.42;
                else if (Size == Size.Medium)
                    return 1.74;
                else
                    return 2.07;
            }
        }


        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 117;
                else if (Size == Size.Medium)
                    return 153;
                else
                    return 205;
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
