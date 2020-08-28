/*
 * Author: Patrick Moll
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to define properties and preferences of a philly poacher
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {

        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets the sirloin preference
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets the onion preference
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets the roll preference
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Gets the list of ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name of the sandwich
        /// </summary>
        /// <returns> Philly Poacher - the name of the sandwich</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
