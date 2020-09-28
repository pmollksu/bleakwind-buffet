/*
 * Author: Patrick Moll
 * Class name: Order.xaml.cs
 * Purpose: Class used to define and display the components of the order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
            var menu = new MenuComponent(this);
            menuBorder.Child = menu;
        }

   
    }
}
