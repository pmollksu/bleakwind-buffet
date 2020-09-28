/*
 * Author: Patrick Moll
 * Class name: MenuComponent.xaml.cs
 * Purpose: Class used to define and display the components of the menu items
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
using PointOfSale.CustomizeMenuItems.CustomizeEntrees;
using PointOfSale.CustomizeMenuItems.CustomizeSides;
using PointOfSale.CustomizeMenuItems.CustomizeDrinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    /// <remarks>Adjusted using the menuBorder of the Order component</remarks>
    public partial class MenuComponent : UserControl
    {
        Order parent;
        public MenuComponent(Order ord)
        {
            InitializeComponent();
            parent = ord;
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the Briarheart burger
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeBB(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeBriarheartBurger(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for double draugr
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeDD(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeDoubleDraugr(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the thalmor triple
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeTT(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeThalmorTriple(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the smokehouse skeleton
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeSS(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeSmokehouseSkeleton(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the philly poacher
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizePP(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizePhillyPoacher(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the garden orc omelette
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeGOC(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeGardenOrcOmelette(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the thugs t-bone
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeThugsT(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeThugsTBone(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the Vokun salad
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeVS(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeVokunSalad(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the fried miraak
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeFM(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeFriedMiraak(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the mad otar grits
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeMOG(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeMadOtarGrits(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the dragonborn waffle fries
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeDW(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeDragonbornWaffleFries(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the sailor soda
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeSailSoda(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeSailorSoda(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the markarth milk
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeMM(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeMarkarthMilk(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the aretino apple juice
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeAAJ(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeAretinoAppleJuice(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the candlehearth coffee
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeCC(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeCandlehearthCoffee(parent);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the Warrior Water
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeWW(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new CustomizeWarriorWater(parent);
        }


    }
}
