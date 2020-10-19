/*
 * Author: Patrick Moll
 * Class name: CustomizeCombo.xaml.cs
 * Purpose: Class used to define and display the combo selection screen
 */
using PointOfSale.CustomizeMenuItems.CustomizeEntrees;
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using PointOfSale.CustomizeMenuItems.CustomizeSides;
using PointOfSale.CustomizeMenuItems.CustomizeDrinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : UserControl
    {
        /// <summary>
        /// The parent OrderComponent
        /// </summary>
        private OrderComponent parentOrder;
        public OrderComponent ParentOrder
        {
            get => parentOrder;
        }
        public CustomizeCombo(OrderComponent ord, Combo cmb)
        {
            
            InitializeComponent();
            parentOrder = ord;
            DataContext = cmb;
            AlignSideComboBox();
            AlignDrinkComboBox();
            AlignEntreeComboBox();

        }

        /// <summary>
        /// Initially Aligns the entree combo box to the combos entree 
        /// </summary>
        private void AlignEntreeComboBox()
        {
            if(DataContext is Combo cmb)
            {
                if (cmb.Entree is BriarheartBurger) EntreeComboBox.SelectedIndex = 0;
                if (cmb.Entree is DoubleDraugr) EntreeComboBox.SelectedIndex = 1;
                if (cmb.Entree is GardenOrcOmelette) EntreeComboBox.SelectedIndex = 2;
                if (cmb.Entree is PhillyPoacher) EntreeComboBox.SelectedIndex = 3;
                if (cmb.Entree is SmokehouseSkeleton) EntreeComboBox.SelectedIndex = 4;
                if (cmb.Entree is ThalmorTriple) EntreeComboBox.SelectedIndex = 5;
                if (cmb.Entree is ThugsTBone) EntreeComboBox.SelectedIndex = 6;

            }
        }

        /// <summary>
        /// Initially Aligns the side combo box to the combos side 
        /// </summary>
        private void AlignSideComboBox()
        {
            if (DataContext is Combo cmb)
            {
                if (cmb.Side is DragonbornWaffleFries) SideComboBox.SelectedIndex = 0;
                if (cmb.Side is FriedMiraak) SideComboBox.SelectedIndex = 1;
                if (cmb.Side is MadOtarGrits) SideComboBox.SelectedIndex = 2;
                if (cmb.Side is VokunSalad) SideComboBox.SelectedIndex = 3;

            }
        }

        /// <summary>
        /// Initially Aligns the Drink combo box to the combos Drink 
        /// </summary>
        private void AlignDrinkComboBox()
        {
            if (DataContext is Combo cmb)
            {
                if (cmb.Drink is AretinoAppleJuice) DrinkComboBox.SelectedIndex = 0;
                if (cmb.Drink is CandlehearthCoffee) DrinkComboBox.SelectedIndex = 1;
                if (cmb.Drink is MarkarthMilk) DrinkComboBox.SelectedIndex = 2;
                if (cmb.Drink is SailorSoda) DrinkComboBox.SelectedIndex = 3;
                if (cmb.Drink is WarriorWater) DrinkComboBox.SelectedIndex = 4;

            }
        }



        /// <summary>
        /// Creates a new entree item when user changes entree in combo box
        /// </summary>
        /// <param name="sender">used for event</param>
        /// <param name="e">used for event</param>
        private void SideComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DataContext is Combo cmb)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "DragonbornWaffleFries" && !(cmb.Side is DragonbornWaffleFries)) cmb.Side = new DragonbornWaffleFries();
                    if (s.Name == "FriedMiraak" && !(cmb.Side is FriedMiraak)) cmb.Side = new FriedMiraak();
                    if (s.Name == "MadOtarGrits" && !(cmb.Side is MadOtarGrits)) cmb.Side = new MadOtarGrits();
                    if (s.Name == "VokunSalad" && !(cmb.Side is VokunSalad)) cmb.Side = new VokunSalad();
                }
            }
        }

        /// <summary>
        /// Creates a new srink item when user changes drink in combo box
        /// </summary>
        /// <param name="sender">used for event</param>
        /// <param name="e">used for event</param>
        private void DrinkComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is Combo cmb)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "AretinoAppleJuice" && !(cmb.Drink is AretinoAppleJuice)) cmb.Drink = new AretinoAppleJuice();
                    if (s.Name == "CandlehearthCoffee" && !(cmb.Drink is CandlehearthCoffee)) cmb.Drink = new CandlehearthCoffee();
                    if (s.Name == "SailorSoda" && !(cmb.Drink is SailorSoda)) cmb.Drink = new SailorSoda();
                    if (s.Name == "MarkarthMilk" && !(cmb.Drink is MarkarthMilk)) cmb.Drink = new MarkarthMilk();
                    if (s.Name == "WarriorWater" && !(cmb.Drink is WarriorWater)) cmb.Drink = new WarriorWater();
                }
            }
        }

        /// <summary>
        /// Creates a new side item when user changes side in combo box
        /// </summary>
        /// <param name="sender">used for event</param>
        /// <param name="e">used for event</param>
        private void EntreeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is Combo cmb)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "BriarheartBurger" && !(cmb.Entree is BriarheartBurger)) cmb.Entree = new BriarheartBurger();
                    if (s.Name == "DoubleDraugr" && !(cmb.Entree is BriarheartBurger)) cmb.Entree = new DoubleDraugr();
                    if (s.Name == "GardenOrcOmelette" && !(cmb.Entree is GardenOrcOmelette)) cmb.Entree = new GardenOrcOmelette();
                    if (s.Name == "PhillyPoacher" && !(cmb.Entree is PhillyPoacher)) cmb.Entree = new PhillyPoacher();
                    if (s.Name == "SmokehouseSkeleton" && !(cmb.Entree is SmokehouseSkeleton)) cmb.Entree = new SmokehouseSkeleton();
                    if (s.Name == "ThalmorTriple" && !(cmb.Entree is ThalmorTriple)) cmb.Entree = new ThalmorTriple();
                    if (s.Name == "ThugsTBone" && !(cmb.Entree is ThugsTBone)) cmb.Entree = new ThugsTBone();

                }
            }
        }

        /// <summary>
        /// Returns back to main menu selection screen
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            ParentOrder.menuBorder.Child = new MenuComponent(ParentOrder);
        }


        /// <summary>
        /// Enters specific entree selection screen when clicked
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void CustomizeEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            Combo cmb;
            cmb = (Combo)DataContext;
            if (cmb.Entree is BriarheartBurger bb)
            {
                CustomizeBriarheartBurger cbb = new CustomizeBriarheartBurger(this, bb);
                ParentOrder.menuBorder.Child = cbb;
            }
            if (cmb.Entree is DoubleDraugr dd)
            {
                CustomizeDoubleDraugr cdd = new CustomizeDoubleDraugr(this, dd);
                cmb.Entree = (Entree)cdd.DataContext;
                ParentOrder.menuBorder.Child = cdd;
            }
            if (cmb.Entree is GardenOrcOmelette gorc)
            {
                CustomizeGardenOrcOmelette cgorc = new CustomizeGardenOrcOmelette(this, gorc);
                ParentOrder.menuBorder.Child = cgorc;
            }
            if (cmb.Entree is PhillyPoacher pp)
            {
                CustomizePhillyPoacher cpp = new CustomizePhillyPoacher(this, pp);
                ParentOrder.menuBorder.Child = cpp;
            }
            if (cmb.Entree is SmokehouseSkeleton ss)
            {
                CustomizeSmokehouseSkeleton css = new CustomizeSmokehouseSkeleton(this, ss);
                ParentOrder.menuBorder.Child = css;
            }
            if (cmb.Entree is ThalmorTriple tt)
            {
                CustomizeThalmorTriple ctt = new CustomizeThalmorTriple(this, tt);
                ParentOrder.menuBorder.Child = ctt;
            }
            if (cmb.Entree is ThugsTBone thug)
            {
                CustomizeThugsTBone cthug = new CustomizeThugsTBone(this, thug);
                ParentOrder.menuBorder.Child = cthug;
            }
        }

        /// <summary>
        /// Enters specific side selection screen when clicked
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void CustomizeSideButton_Click(object sender, RoutedEventArgs e)
        {
            Combo cmb;
            cmb = (Combo)DataContext;
            if (cmb.Side is DragonbornWaffleFries wf)
            {
                CustomizeDragonbornWaffleFries cwf = new CustomizeDragonbornWaffleFries(this, wf);
                ParentOrder.menuBorder.Child = cwf;
            }
            if (cmb.Side is FriedMiraak fm)
            {
                CustomizeFriedMiraak cfm = new CustomizeFriedMiraak(this, fm);
                cmb.Side = (Side)cfm.DataContext;
                ParentOrder.menuBorder.Child = cfm;
            }
            if (cmb.Side is MadOtarGrits mad)
            {
                CustomizeMadOtarGrits cmad = new CustomizeMadOtarGrits(this, mad);
                ParentOrder.menuBorder.Child = cmad;
            }
            if (cmb.Side is VokunSalad vs)
            {
                CustomizeVokunSalad cvs = new CustomizeVokunSalad(this, vs);
                ParentOrder.menuBorder.Child = cvs;
            }
        }

        /// <summary>
        /// Enters specific drink selection screen when clicked
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void CustomizeDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            Combo cmb;
            cmb = (Combo)DataContext;
            if(cmb.Drink is AretinoAppleJuice aj)
            {
                CustomizeAretinoAppleJuice caj = new CustomizeAretinoAppleJuice(this, aj);
                ParentOrder.menuBorder.Child = caj;
            }
            if (cmb.Drink is CandlehearthCoffee cc)
            {
                CustomizeCandlehearthCoffee ccc = new CustomizeCandlehearthCoffee(this, cc);
                cmb.Drink = (Drink)ccc.DataContext;
                ParentOrder.menuBorder.Child = ccc;
            }
            if (cmb.Drink is MarkarthMilk mm)
            {
                CustomizeMarkarthMilk cmm = new CustomizeMarkarthMilk(this, mm);
                ParentOrder.menuBorder.Child = cmm;
            }
            if (cmb.Drink is SailorSoda ss)
            {
                CustomizeSailorSoda css = new CustomizeSailorSoda(this, ss);
                ParentOrder.menuBorder.Child = css;
            }
            if (cmb.Drink is WarriorWater ww)
            {
                CustomizeWarriorWater cww = new CustomizeWarriorWater(this, ww);
                ParentOrder.menuBorder.Child = cww;
            }

        }
    }
}
