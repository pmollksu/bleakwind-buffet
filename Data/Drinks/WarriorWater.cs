/*
 * Author: Patrick Moll
 * Class name: WarriorWater.cs
 * Purpose: Class used to define properties and preferences of a warrior water
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater: Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price => 0.00;

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories => 0;
        
        
        /// <summary>
        /// Getsthe customer ice preference
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the lemon preference 
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Adds drink instructions to a special instruction list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name and size of the drink
        /// </summary>
        /// <returns>[Size] Warrior Water</returns>
        public override string ToString()
        {
            return Size +  " Warrior Water";
        }
    }
}
