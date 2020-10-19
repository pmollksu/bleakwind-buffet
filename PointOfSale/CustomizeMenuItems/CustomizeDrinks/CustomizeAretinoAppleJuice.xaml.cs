/*
 * Author: Patrick Moll
 * Class name: CustomizeAretinoAppleJuice.xaml.cs
 * Purpose: Class used to set parent and return click event to main screen for particular menu item
 */
using BleakwindBuffet.Data;
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
        UserControl parent;

        public CustomizeAretinoAppleJuice(UserControl par, AretinoAppleJuice aj)
        {
            InitializeComponent();
            parent = par;
            DataContext = aj;
            AlignSizeCheckBox();
            
        }

        /// <summary>
        /// Aligns the size checkbox to the size of the item
        /// </summary>
        private void AlignSizeCheckBox()
        {
            if(DataContext is AretinoAppleJuice item)
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
            if(parent is OrderComponent oc)
            {
                oc.menuBorder.Child = new MenuComponent(oc);
            }
            if(parent is CustomizeCombo cc)
            {
                if(cc.ParentOrder is OrderComponent ordc)
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
