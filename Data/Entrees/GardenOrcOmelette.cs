/*
 * Author: Patrick Moll
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to define properties and preferences of a garden orc omelette
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Gets the broccoli preference
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets the mushrooms preference
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets the tomato preference
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets the cheddar preference
        /// </summary>
        public bool Cheddar { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the omelette
        /// </summary>
        /// <returns> Garden Orc Omelette - the name of the omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
