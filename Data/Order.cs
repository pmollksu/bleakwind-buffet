/*
 * Author: Patrick Moll
 * Class name: Order.cs
 * Purpose: Class used to define properties and methods for creating an order
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order:ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        /// <summary>
        /// List of IOrder Items in order
        /// </summary>
        List<IOrderItem> orderItems;
        public Order()
        {
            orderItems = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;
        }
        /// <summary>
        /// Number used to updated order number
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// CollectionChanged event
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        
        /// <summary>
        /// Count of items in list
        /// </summary>
        public int Count => ((ICollection<IOrderItem>)orderItems).Count;


        /// <summary>
        /// Read only property
        /// </summary>
        public bool IsReadOnly => ((ICollection<IOrderItem>)orderItems).IsReadOnly;


        /// <summary>
        /// Adds an IOrderItem to the Order and notifies property and collection changed
        /// </summary>
        /// <param name="item"> IOrderItem to be added</param>
        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            item.PropertyChanged += ItemEventChange;
        }

        /// <summary>
        /// Removes an IOrderItem from the Order
        /// </summary>
        /// <param name="item">IOrderItem to be removed</param>
        /// <returns>if the item could be removed</returns>
        public bool Remove(IOrderItem item)
        {
            
            if (item != null)
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, orderItems.IndexOf(item)));
                bool isRemoved = orderItems.Remove(item);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

                item.PropertyChanged -= ItemEventChange;
                return isRemoved;
            }
            return false;
        }

        /// <summary>
        /// Order number
        /// </summary>
        public int Number { get;}

        /// <summary>
        /// Rate of sales tax
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;


        /// <summary>
        /// Subtotal of order
        /// </summary>
        private double subtotal;
        public double Subtotal
        {
            get
            {
                subtotal = 0.00;
                foreach(IOrderItem item in orderItems)
                {
                    subtotal += item.Price;
                }
                return Math.Round(subtotal,2);
            }
        }

        /// <summary>
        /// Total of order
        /// </summary>
        private double total;
        public double Total
        {
            get
            {
                total = Subtotal + Tax;
                return Math.Round(total,2);
            }
        }

        /// <summary>
        /// Tax of the order
        /// </summary>
        private double tax;
        public double Tax
        {
            get
            {
                tax = Subtotal * SalesTaxRate;
                return Math.Round(tax, 2);
            }
        }

        /// <summary>
        /// Clears all items in order
        /// </summary>
        public void Clear()
        {
            ((ICollection<IOrderItem>)orderItems).Clear();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        /// <summary>
        /// Notifies properties when the price or calories change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemEventChange(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if(e.PropertyName =="Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        public bool Contains(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)orderItems).Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            ((ICollection<IOrderItem>)orderItems).CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)orderItems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)orderItems).GetEnumerator();
        }
    }
}
