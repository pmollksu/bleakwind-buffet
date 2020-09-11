﻿/*
 * Author: Patrick Moll
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to define properties and preferences of a briarheart burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger: Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

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
        /// Gets the list of ingredients to hold
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Bun) instructions.Add("Hold bun");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name of the burger
        /// </summary>
        /// <returns> Briarheart Burger - name of the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }




    }
}
