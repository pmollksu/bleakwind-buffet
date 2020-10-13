/*
 * Author: Patrick Moll
 * Class name: Side.cs
 * Purpose: A base class used to define common properties among sides
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
    {

        /// <summary>
        /// Event triggered when a property changes
        /// </summary>     
        public virtual event PropertyChangedEventHandler PropertyChanged;


        private Size size = Size.Small;
        /// <summary>
        /// The size of the side
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
                InvokePropertyChanged("MockToString");
            }
        }

        /// <summary>
        /// Helper method used by derived class to invoke property changed for all properties of side items
        /// </summary>
        /// <param name="name">the name of the property</param>
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets toString of side and is used to invoke property changed
        /// </summary>
        public virtual string MockToString
        {
           get
            {
                return this.ToString();
            }
        }

    }
}
