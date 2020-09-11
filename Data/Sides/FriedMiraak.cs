/*
 * Author: Patrick Moll
 * Class name: FriedMiraak.cs
 * Purpose: Class used to define properties of a fried miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak: Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

       
        /// <summary>
        /// Gets the list of ingredients to hold(empty because no special instructions)
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>[Size] Fried Miraak</returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
