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

namespace PointOfSale.CustomizeMenuItems.CustomizeSides
{
    /// <summary>
    /// Interaction logic for CustomizeVokunSalad.xaml
    /// </summary>
    public partial class CustomizeVokunSalad : UserControl
    {
        Order parent;
        public CustomizeVokunSalad(Order ord)
        {
            InitializeComponent();
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
