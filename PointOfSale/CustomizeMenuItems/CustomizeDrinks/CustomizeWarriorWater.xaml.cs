/*
 * Author: Patrick Moll
 * Class name: CustomizeWarriorWater.xaml.cs
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
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizeMenuItems.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeWarriorWater.xaml
    /// </summary>
    public partial class CustomizeWarriorWater : UserControl
    {
        OrderComponent parent;
        public CustomizeWarriorWater(OrderComponent ord, WarriorWater ww)
        {
            InitializeComponent();
            DataContext = ww;
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

        private void Size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is WarriorWater ww)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ww.Size = Size.Small;
                    if (s.Name == "Medium") ww.Size = Size.Medium;
                    if (s.Name == "Large") ww.Size = Size.Large;
                }
            }
        }
    }
}
