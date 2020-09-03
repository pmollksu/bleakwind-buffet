/*
 * Author: Patrick Moll
 * Class name: VokunSalad.cs
 * Purpose: Class used to define properties of a vokun salad
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
        /// <returns>[Size] Vokun Salad</returns>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }
    }
}
