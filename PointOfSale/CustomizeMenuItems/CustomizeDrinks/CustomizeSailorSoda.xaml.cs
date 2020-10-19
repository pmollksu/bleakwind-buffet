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
using BleakwindBuffet.Data;
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
        UserControl parent;
        public CustomizeSailorSoda(UserControl par, SailorSoda ss)
        {
            InitializeComponent();
            DataContext = ss;
            parent = par;
            AlignSizeCheckBox();
            AlignFlavorCheckBox();
        }

        /// <summary>
        /// Aligns the size checkbox to the size of the item
        /// </summary>
        private void AlignSizeCheckBox()
        {
            if (DataContext is SailorSoda item)
            {
                if (item.Size == Size.Small) SizeComboBox.SelectedIndex = 0;
                if (item.Size == Size.Medium) SizeComboBox.SelectedIndex = 1;
                if (item.Size == Size.Large) SizeComboBox.SelectedIndex = 2;
            }

        }

        /// <summary>
        /// Aligns the flavor checkbox to the flavor of the item
        /// </summary>
        private void AlignFlavorCheckBox()
        {
            if (DataContext is SailorSoda item)
            {
                if (item.Flavor == SodaFlavor.Cherry) FlavorComboBox.SelectedIndex = 0;
                if (item.Flavor == SodaFlavor.Blackberry) FlavorComboBox.SelectedIndex = 1;
                if (item.Flavor == SodaFlavor.Grapefruit) FlavorComboBox.SelectedIndex = 2;
                if (item.Flavor == SodaFlavor.Lemon) FlavorComboBox.SelectedIndex = 3;
                if (item.Flavor == SodaFlavor.Peach) FlavorComboBox.SelectedIndex = 4;
                if (item.Flavor == SodaFlavor.Watermelon) FlavorComboBox.SelectedIndex = 5;
            }

        }

        /// <summary>
        /// Returns to main item selection screen when the done button is selected
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        public void doneClick(object sender, RoutedEventArgs e)
        {
            if (parent is OrderComponent oc)
            {
                oc.menuBorder.Child = new MenuComponent(oc);
            }
            if (parent is CustomizeCombo cc)
            {
                if (cc.ParentOrder is OrderComponent ordc)
                {
                    Combo cmb = (Combo)parent.DataContext;
                    cmb.Drink = (Drink)this.DataContext;
                    ordc.menuBorder.Child = this.parent;
                }

            }
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
