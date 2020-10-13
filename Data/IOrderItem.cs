/*
 * Author: Patrick Moll
 * Class name: Menu.cs
 * Purpose: Class used to define interface for all order items
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface that is used to represent properties of all menu items
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the item
        /// </summary>
        List<string> SpecialInstructions { get; }


    }
}
