﻿/*
 * Author: Patrick Moll
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to define properties of dragonborn waffle fries
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries: Side, IOrderItem, INotifyPropertyChanged
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
        public override uint Calories
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
        /// <returns>[Size] Dragonborn Waffle Fries</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }

        /// <summary>
        /// Description of the side
        /// </summary>
        public string Description
        {
            get => "Crispy fried potato waffle fries.";
        }
    }
}
