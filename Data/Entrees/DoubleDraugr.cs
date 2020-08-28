/*
 * Author: Patrick Moll
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to define properties and preferences of a double draugr
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 843;


        /// <summary>
        /// Gets the ketchup preference
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets the bun preference
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets the mustard preference
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets the cheese preference
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets the pickle preference
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets the tomato preference
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets the lettuce preference
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets the mayo preference
        /// </summary>
        public bool Mayo { get; set; } = true;


        /// <summary>
        /// Gets the list of ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Bun) instructions.Add("Hold bun");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name of the burger
        /// </summary>
        /// <returns> Double Draugr - name of the burger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
