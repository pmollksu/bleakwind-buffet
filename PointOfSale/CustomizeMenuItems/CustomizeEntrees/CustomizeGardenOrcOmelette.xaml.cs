/*
 * Author: Patrick Moll
 * Class name: CustomizeGardenOrcOmelette.xaml.cs
 * Purpose: Class used to set parent and return click event to main screen for particular menu item
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.CustomizeMenuItems.CustomizeEntrees
{
    /// <summary>
    /// Interaction logic for CustomizeGardenOrcOmelette.xaml
    /// </summary>
    public partial class CustomizeGardenOrcOmelette : UserControl
    {
        OrderComponent parent;
        public CustomizeGardenOrcOmelette(OrderComponent ord, GardenOrcOmelette gorc)
        {
            InitializeComponent();
            DataContext = gorc;
            parent = ord;
        }

        /// <summary>
        /// Returns to main item selection screen when the done button is selected
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        public void doneClick(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new MenuComponent(parent);
        }
    }
}
