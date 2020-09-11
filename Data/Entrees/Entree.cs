/*
 * Author: Patrick Moll
 * Class name: Entree.cs
 * Purpose: A base class used to define common properties among entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// An abstract base class that defines common properties for entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
