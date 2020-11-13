/*
 * Author: Patrick Moll
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to define properties and preferences of a garden orc omelette
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette: Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <summary>
        /// Gets the broccoli preference
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                InvokePropertyChanged("Broccoli");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// Gets the mushrooms preference
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                InvokePropertyChanged("Mushrooms");
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

        private bool cheddar = true;
        /// <summary>
        /// Gets the cheddar preference
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                InvokePropertyChanged("Cheddar");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the omelette
        /// </summary>
        /// <returns> Garden Orc Omelette - the name of the omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        /// <summary>
        /// Description of the entree
        /// </summary>
        public string Description
        {
            get => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
        }
    }
}
