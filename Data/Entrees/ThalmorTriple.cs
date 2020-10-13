/*
 * Author: Patrick Moll
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to define properties and preferences of a thalmor triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple: Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;
        private bool ketchup = true;
        /// <summary>
        /// Gets the ketchup preference
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                InvokePropertyChanged("Ketchup");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool bun = true;
        /// <summary>
        /// Gets the bun preference
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                InvokePropertyChanged("Bun");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Gets the mustard preference
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                InvokePropertyChanged("Mustard");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// Gets the cheese preference
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                InvokePropertyChanged("Cheese");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Gets the pickle preference
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                InvokePropertyChanged("Pickle");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Gets the tomato preference
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                InvokePropertyChanged("Tomato");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// Gets the lettuce preference
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                InvokePropertyChanged("Lettuce");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Gets the mayo preference
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                InvokePropertyChanged("Mayo");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// Gets the bacon preference
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                InvokePropertyChanged("Bacon");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <summary>
        /// Gets the egg preference
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                InvokePropertyChanged("Egg");
                InvokePropertyChanged("SpecialInstructions");
            }
        }


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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;

            }
        }

        /// <summary>
        /// Returns the name of the burger
        /// </summary>
        /// <returns> Thalmor Triple - name of the burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
