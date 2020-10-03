/*
 * Author: Patrick Moll
 * Class name: Drink.cs
 * Purpose: A base class used to define common properties among drinks
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink: INotifyPropertyChanged
    {

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size 
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChanged("Size");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Helper method used by derived class to invoke property changed for all properties of drink items
        /// </summary>
        /// <param name="name">the name of the property</param>
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get;}

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get;}

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}
    }
}
