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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    /// <remarks>Adjusted using the menuBorder of the Order component</remarks>
    public partial class MenuComponent : UserControl
    {
       

        OrderComponent parent;
        public MenuComponent(OrderComponent ord)
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
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeBriarheartBurger cbb = new CustomizeBriarheartBurger(parent, new BriarheartBurger());
            parent.menuBorder.Child = cbb;
            ord.Add((IOrderItem)cbb.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for double draugr
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeDD(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeDoubleDraugr cdd = new CustomizeDoubleDraugr(parent, new DoubleDraugr());
            parent.menuBorder.Child = cdd;
            ord.Add((IOrderItem)cdd.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the thalmor triple
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeTT(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeThalmorTriple ctt = new CustomizeThalmorTriple(parent, new ThalmorTriple());
            parent.menuBorder.Child = ctt;
            ord.Add((IOrderItem)ctt.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the smokehouse skeleton
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeSS(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeSmokehouseSkeleton css = new CustomizeSmokehouseSkeleton(parent, new SmokehouseSkeleton());
            parent.menuBorder.Child = css;
            ord.Add((IOrderItem)css.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the philly poacher
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizePP(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizePhillyPoacher cpp = new CustomizePhillyPoacher(parent, new PhillyPoacher());
            parent.menuBorder.Child = cpp;
            ord.Add((IOrderItem)cpp.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the garden orc omelette
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeGOC(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeGardenOrcOmelette cgorc = new CustomizeGardenOrcOmelette(parent, new GardenOrcOmelette());
            parent.menuBorder.Child = cgorc;
            ord.Add((IOrderItem)cgorc.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the thugs t-bone
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeThugsT(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeThugsTBone cthugs = new CustomizeThugsTBone(parent, new ThugsTBone());
            parent.menuBorder.Child = cthugs;
            ord.Add((IOrderItem)cthugs.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the Vokun salad
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeVS(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeVokunSalad cvs = new CustomizeVokunSalad(parent, new VokunSalad());
            parent.menuBorder.Child = cvs;
            ord.Add((IOrderItem)cvs.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the fried miraak
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeFM(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeFriedMiraak cfm = new CustomizeFriedMiraak(parent, new FriedMiraak());
            parent.menuBorder.Child = cfm;
            ord.Add((IOrderItem)cfm.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the mad otar grits
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeMOG(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeMadOtarGrits cmog = new CustomizeMadOtarGrits(parent, new MadOtarGrits());
            parent.menuBorder.Child = cmog;
            ord.Add((IOrderItem)cmog.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the dragonborn waffle fries
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeDW(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeDragonbornWaffleFries cwf = new CustomizeDragonbornWaffleFries(parent, new DragonbornWaffleFries());
            parent.menuBorder.Child = cwf;
            ord.Add((IOrderItem)cwf.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the sailor soda
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeSailSoda(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeSailorSoda css = new CustomizeSailorSoda(parent, new SailorSoda());
            parent.menuBorder.Child = css;
            ord.Add((IOrderItem)css.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the markarth milk
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeMM(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeMarkarthMilk cmm = new CustomizeMarkarthMilk(parent, new MarkarthMilk());
            parent.menuBorder.Child = cmm;
            ord.Add((IOrderItem)cmm.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the aretino apple juice
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeAAJ(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeAretinoAppleJuice caj = new CustomizeAretinoAppleJuice(parent, new AretinoAppleJuice());
            parent.menuBorder.Child = caj;
            ord.Add((IOrderItem)caj.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the candlehearth coffee
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeCC(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeCandlehearthCoffee ccc = new CustomizeCandlehearthCoffee(parent, new CandlehearthCoffee());
            parent.menuBorder.Child = ccc;
            ord.Add((IOrderItem)ccc.DataContext);
        }

        /// <summary>
        /// Sets the menu pane to the custimization screen for the Warrior Water
        /// </summary>
        /// <param name="sender"> used for click event</param>
        /// <param name="e">used for click event</param>
        public void customizeWW(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeWarriorWater cww = new CustomizeWarriorWater(parent, new WarriorWater());
            parent.menuBorder.Child = cww;
            ord.Add((IOrderItem)cww.DataContext);
        }
     

        /// <summary>
        /// Cancels the current order by clearing all items in the list
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e"></param>
        private void cancelOrder_Click(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            ord.Clear();
            parent.DataContext = new Order();
        }

        private void comboButton_Click(object sender, RoutedEventArgs e)
        {
            Order ord;
            ord = (Order)parent.DataContext;
            CustomizeCombo custcombo = new CustomizeCombo(parent, new Combo());
            parent.menuBorder.Child = custcombo;
            ord.Add((IOrderItem)custcombo.DataContext);

        }
    }
}
