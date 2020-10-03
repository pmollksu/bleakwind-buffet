/*
 * Author: Patrick Moll
 * Class name: ThugsTBone.cs
 * Purpose: Class used to define properties and preferences of a thugs t-bone
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone: Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the TBone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the Tbone
        /// </summary>
        public override uint Calories => 982;

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
        /// Returns the name of the T-Bone
        /// </summary>
        /// <returns> Thugs T-Bone - name of the burger</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
