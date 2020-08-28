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
                if (Size == Size.Small)
                    return 0.42;
                else if (Size == Size.Medium)
                    return 0.76;
                else
                    return 0.96;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 77;
                else if (Size == Size.Medium)
                    return 89;
                else
                    return 100;
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
