using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentComponent.xaml
    /// </summary>
    public partial class CashPaymentComponent : UserControl
    {
        OrderComponent parentOrder;
        public CashPaymentComponent(OrderComponent par)
        {
            InitializeComponent();
            var cvm = new CashViewModel((Order)par.DataContext);
            DataContext = cvm;
            parentOrder = par;
            OnesCoinsControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
            HalfDollarControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
            QuartersControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
            DimesControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
            NicklesControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
            PenniesControl.MoneyLabel.Background = new SolidColorBrush(Colors.Gold);
        }



        /// <summary>
        /// Returns to curent order
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void ReturnOrderButton_Click(object sender, RoutedEventArgs e)
        {
            parentOrder.ColumnToHide.Width = parentOrder.ReferenceColumn.Width;
            parentOrder.menuBorder.Child = new MenuComponent(parentOrder);
        }

        /// <summary>
        /// Used to finalize the order
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void FinalizeButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashViewModel cvm)
            {
                if(parentOrder.DataContext is Order ord)
                {
                    
                    if (cvm.FinalizeSale())
                    {
                        cvm.PrintCashReceipt();
                        ord.Clear();                       
                        parentOrder.DataContext = new Order();
                        parentOrder.ColumnToHide.Width = parentOrder.ReferenceColumn.Width;
                        parentOrder.menuBorder.Child = new MenuComponent(parentOrder);
                    }
                    else
                    {
                        MessageBox.Show("Amount Due is Still greater than $0.00!");
                    }
                }
                
            }
        }
    }
}
