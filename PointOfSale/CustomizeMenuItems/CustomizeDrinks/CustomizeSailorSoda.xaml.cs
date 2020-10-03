/*
 * Author: Patrick Moll
 * Class name: CustomizeSailorSoda.xaml.cs
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
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace PointOfSale.CustomizeMenuItems.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeSailorSoda.xaml
    /// </summary>
    public partial class CustomizeSailorSoda : UserControl
    {
        Order parent;
        public CustomizeSailorSoda(Order ord)
        {
            InitializeComponent();
            SailorSoda ss = new SailorSoda();
            DataContext = ss;
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

        /// <summary>
        /// Binds the ComboBox items for size to the size enum
        /// </summary>
        /// <param name="sender">used for event</param>
        /// <param name="e">used for selection change event</param>
        private void Size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda ss)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ss.Size = Size.Small;
                    if (s.Name == "Medium") ss.Size = Size.Medium;
                    if (s.Name == "Large") ss.Size = Size.Large;
                }
            }
        }

        /// <summary>
        /// Binds the ComboBox items for size to the flavor enum
        /// </summary>
        /// <param name="sender">used for event</param>
        /// <param name="e">used for selection change event</param>
        private void Flavor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda ss)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Cherry") ss.Flavor = SodaFlavor.Cherry;
                    if (s.Name == "Blackberry") ss.Flavor = SodaFlavor.Blackberry;
                    if (s.Name == "Grapefruit") ss.Flavor = SodaFlavor.Grapefruit;
                    if (s.Name == "Lemon") ss.Flavor = SodaFlavor.Lemon;
                    if (s.Name == "Peach") ss.Flavor = SodaFlavor.Peach;
                    if (s.Name == "Watermelon") ss.Flavor = SodaFlavor.Watermelon;

                }
            }

        }
    }
}
