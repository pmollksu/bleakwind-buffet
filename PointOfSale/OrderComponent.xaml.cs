/*
 * Author: Patrick Moll
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to define and display the components of the order
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.CustomizeMenuItems.CustomizeDrinks;
using PointOfSale.CustomizeMenuItems.CustomizeEntrees;
using PointOfSale.CustomizeMenuItems.CustomizeSides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        MenuComponent menu;
        public OrderComponent()
        {
            InitializeComponent();
            menu = new MenuComponent(this);
            menuBorder.Child = menu;
            DataContext = new Order();
        }

        /// <summary>
        /// Cancels the selected item from the order
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void cancelItem_Click(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)DataContext;
            ord.Remove((IOrderItem)itemsListView.SelectedItem);
            menuBorder.Child = new MenuComponent(this);
        }

     
        /// <summary>
        /// Used to reopen customization screen for any type of IOrderItem 
        /// </summary>
        /// <param name="sender">used for selection event</param>
        /// <param name="e">used for selection event</param>
        private void itemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem curItem = (IOrderItem)itemsListView.SelectedItem;
            if(curItem is BriarheartBurger bb)
            {
                CustomizeBriarheartBurger cbb = new CustomizeBriarheartBurger(this, bb);
                menuBorder.Child = cbb;
            }
            else if (curItem is DoubleDraugr dd)
            {
                CustomizeDoubleDraugr cdd = new CustomizeDoubleDraugr(this, dd);
                menuBorder.Child = cdd;
            }
            else if (curItem is GardenOrcOmelette gorc)
            {
                CustomizeGardenOrcOmelette cgorc = new CustomizeGardenOrcOmelette(this, gorc);
                menuBorder.Child = cgorc;
            }
            else if (curItem is PhillyPoacher pp)
            {
                CustomizePhillyPoacher cpp = new CustomizePhillyPoacher(this, pp);
                menuBorder.Child = cpp;
            }
            else if (curItem is SmokehouseSkeleton ss)
            {
                CustomizeSmokehouseSkeleton css = new CustomizeSmokehouseSkeleton(this, ss);
                menuBorder.Child = css;
            }
            else if (curItem is ThalmorTriple tt)
            {
                CustomizeThalmorTriple ctt = new CustomizeThalmorTriple(this, tt);
                menuBorder.Child = ctt;
            }
            else if (curItem is ThugsTBone thugst)
            {
                CustomizeThugsTBone cthugst = new CustomizeThugsTBone(this, thugst);
                menuBorder.Child = cthugst;
            }
            else if (curItem is AretinoAppleJuice aj)
            {
                CustomizeAretinoAppleJuice caj = new CustomizeAretinoAppleJuice(this, aj);
                menuBorder.Child = caj;
            }
            else if (curItem is CandlehearthCoffee cc)
            {
                CustomizeCandlehearthCoffee ccc = new CustomizeCandlehearthCoffee(this, cc);
                menuBorder.Child = ccc;
            }
            else if (curItem is MarkarthMilk mm)
            {
                CustomizeMarkarthMilk cmm = new CustomizeMarkarthMilk(this, mm);
                menuBorder.Child = cmm;
            }
            else if (curItem is SailorSoda sails)
            {
                CustomizeSailorSoda csails = new CustomizeSailorSoda(this, sails);
                menuBorder.Child = csails;
            }
            else if (curItem is WarriorWater ww)
            {
                CustomizeWarriorWater cww = new CustomizeWarriorWater(this,ww);
                menuBorder.Child = cww;
            }
            else if (curItem is DragonbornWaffleFries wf)
            {
                CustomizeDragonbornWaffleFries cwf = new CustomizeDragonbornWaffleFries(this, wf);
                menuBorder.Child = cwf;
            }
            else if (curItem is FriedMiraak fm)
            {
                CustomizeFriedMiraak cfm = new CustomizeFriedMiraak(this, fm);
                menuBorder.Child = cfm;
            }
            else if (curItem is MadOtarGrits mad)
            {
                CustomizeMadOtarGrits cmad = new CustomizeMadOtarGrits(this, mad);
                menuBorder.Child = cmad;
            }
            else if (curItem is VokunSalad vs)
            {
                CustomizeVokunSalad cvs = new CustomizeVokunSalad(this, vs);
                menuBorder.Child = cvs;
            }

        }

    }
}
