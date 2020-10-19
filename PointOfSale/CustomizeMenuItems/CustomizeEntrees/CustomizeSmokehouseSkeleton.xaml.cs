/*
 * Author: Patrick Moll
 * Class name: CustomizeSmokehouseSkeleton.xaml.cs
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.CustomizeMenuItems.CustomizeEntrees
{
    /// <summary>
    /// Interaction logic for CustomizeSmokehouseSkeleton.xaml
    /// </summary>
    public partial class CustomizeSmokehouseSkeleton : UserControl
    {
        UserControl parent;
        public CustomizeSmokehouseSkeleton(UserControl par, SmokehouseSkeleton ss)
        {
            InitializeComponent();
            DataContext = ss;
            parent = par;
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
                    cmb.Entree = (Entree)this.DataContext;
                    ordc.menuBorder.Child = this.parent;
                }

            }
        }
    }
}
