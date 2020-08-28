/*
 * Author: Patrick Moll
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to define properties and preferences of a smokehouse skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Gets the Sausage Link preference
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets the egg preference
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets the hashbrowns preference
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Gets the pancake preference
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Gets the list of ingredients to hold
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name of the breakfast combo
        /// </summary>
        /// <returns> Smokehouse Skeleton - the name of the breakfast combo</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
