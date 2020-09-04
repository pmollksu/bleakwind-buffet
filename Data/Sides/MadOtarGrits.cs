/*
 * Author: Patrick Moll
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to define properties of mad otar grits
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the size of the side using Size enum
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the list of ingredients to hold(empty because no special instructions)
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the size and name of the side
        /// </summary>
        /// <returns>[Size] Mad Otar Grits</returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}
