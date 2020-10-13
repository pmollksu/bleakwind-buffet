/*
 * Author: Patrick Moll
 * Class name: Combo.cs
 * Purpose: Class used to define properties and methods for creating a combo
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event triggered when a property changes
        /// </summary>
        public  event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Drink to be used in the combo
        /// </summary>
        private Drink drink = null;
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                Drink.PropertyChanged += ItemPropertyChangedListener;


            }

        }

        /// <summary>
        /// Side to be used in the combo
        /// </summary>
        private Side side = null;
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                Side.PropertyChanged += ItemPropertyChangedListener;
            }
        }

        /// <summary>
        /// Entree to be used in the combo
        /// </summary>
        private Entree entree = null;
        public Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                Entree.PropertyChanged += ItemPropertyChangedListener;

            }
        }

        /// <summary>
        /// Price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0.0;
                price = Entree.Price + Side.Price + Drink.Price - 1;
                return Math.Round(price, 2);
            }
        }

       
        /// <summary>
        /// Calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                calories = Entree.Calories + Side.Calories + Drink.Calories; 
                return calories;
            }

        }

        /// <summary>
        /// SpecialInstructions of all items in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialinstructions = new List<string>();
                specialinstructions.Add(Entree.ToString());
                specialinstructions.AddRange(Entree.SpecialInstructions);
                specialinstructions.Add(Side.ToString());
                specialinstructions.AddRange(Side.SpecialInstructions);
                specialinstructions.Add(Drink.ToString());
                specialinstructions.AddRange(Drink.SpecialInstructions);              
                return specialinstructions;

            }

        }

        /// <summary>
        /// Event listener when combo item changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Drink")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
            }
            if(e.PropertyName =="Side")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
            }
            if (e.PropertyName == "Entree")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
            }
        }
           
    }
}
