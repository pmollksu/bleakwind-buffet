/*
 * Author: Patrick Moll
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to define properties and preferences of an aretino apple juice
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.62;
                else if (Size == Size.Medium)
                    return 0.87;
                else
                    return 1.01;
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
                    return 44;
                else if (Size == Size.Medium)
                    return 88;
                else
                    return 132;
            }
        }

        /// <summary>
        /// Gets the size of the drink using Size enum
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the customer ice preference
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Adds ice to list if customer wants ice
        /// </summary>
        public List<string> SpecialInstructions
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
            return Size + " Arentino Apple Juice";
        }
    }
}
