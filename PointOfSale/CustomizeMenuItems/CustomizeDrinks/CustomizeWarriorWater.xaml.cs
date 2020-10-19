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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizeMenuItems.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeWarriorWater.xaml
    /// </summary>
    public partial class CustomizeWarriorWater : UserControl
    {
        UserControl parent;
        public CustomizeWarriorWater(UserControl par, WarriorWater ww)
        {
            InitializeComponent();
            DataContext = ww;
            parent = par;
            AlignSizeCheckBox();
        }

        /// <summary>
        /// Aligns the size checkbox to the size of the item
        /// </summary>
        private void AlignSizeCheckBox()
        {
            if (DataContext is WarriorWater item)
            {
                if (item.Size == Size.Small) SizeComboBox.SelectedIndex = 0;
                if (item.Size == Size.Medium) SizeComboBox.SelectedIndex = 1;
                if (item.Size == Size.Large) SizeComboBox.SelectedIndex = 2;
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
