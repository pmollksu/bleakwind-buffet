/*
 * Author: Patrick Moll
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to define properties of dragonborn waffle fries
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the size of the side using Size enum
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Returns the size and name of the side
        /// </summary>
        /// <returns>[Size] Dragonborn Waffle Fries</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
