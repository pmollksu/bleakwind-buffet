/*
 * Author: Patrick Moll
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to define properties and preferences of a candlehearth coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 0.75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;
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
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;
            }
        }

        /// <summary>
        /// Gets the size of the drink using Size enum
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the customer ice preference
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// If the customer wants room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// If the customer wants decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Adds ice to list if customer wants ice
        /// </summary>
        public List<string> SpecialInstructions
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
