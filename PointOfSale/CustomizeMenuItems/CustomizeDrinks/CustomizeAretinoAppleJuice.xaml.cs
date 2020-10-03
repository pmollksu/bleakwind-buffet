/*
 * Author: Patrick Moll
 * Class name: CustomizeAretinoAppleJuice.xaml.cs
 * Purpose: Class used to set parent and return click event to main screen for particular menu item
 */
using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizeMenuItems.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomzeAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomizeAretinoAppleJuice : UserControl
    {
        Order parent;
        public CustomizeAretinoAppleJuice(Order ord)
        {
            InitializeComponent();
            parent = ord;
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DataContext = aj;
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
            if(DataContext is AretinoAppleJuice aj)
            {
                foreach(ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") aj.Size = Size.Small;
                    if (s.Name == "Medium") aj.Size = Size.Medium;
                    if (s.Name == "Large") aj.Size = Size.Large;
                }
            }
        }
    }
}
