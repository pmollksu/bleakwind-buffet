using BleakwindBuffet.Data;
using RoundRegister;
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        OrderComponent parentOrder;
        public PaymentOptions(OrderComponent par)
        {
            InitializeComponent();
            parentOrder = par;
        }

        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            parentOrder.menuBorder.Child = new CashPaymentComponent(this.parentOrder);
        }

        private void CreditDebbitButton_Click(object sender, RoutedEventArgs e)
        {
            Order ord = (Order)parentOrder.DataContext;
            CardTransactionResult resultTransaction = CardReader.RunCard(ord.Total);
            switch(resultTransaction)
            {
                case CardTransactionResult.Approved:
                    MessageBox.Show("Approved");
                    PrintDebitCreditReceipt();
                    ord.Clear();
                    parentOrder.DataContext = new Order();
                    parentOrder.ColumnToHide.Width = parentOrder.ReferenceColumn.Width;
                    parentOrder.menuBorder.Child = new MenuComponent(parentOrder);
                    break;
                case CardTransactionResult.Declined:
                    MessageBox.Show("Card Declined");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect Pin");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Insufficient Funds");
                    break;

            }
        }

        /// <summary>
        /// Prints out the Receipt for the current order when Credit/Debbit is approved
        /// </summary>
        private void PrintDebitCreditReceipt()
        {
            if(parentOrder is OrderComponent oc)
            {
                if(oc.DataContext is Order ord)
                {
                    RecieptPrinter.PrintLine("Order Number " + ord.Number.ToString());
                    RecieptPrinter.PrintLine(DateTime.Now.ToString());
                    foreach(IOrderItem item in ord)
                    {
                        RecieptPrinter.PrintLine(item.ToString());
                        RecieptPrinter.PrintLine("    " + item.Price.ToString("C", CultureInfo.CurrentCulture));
                        foreach(String instr in item.SpecialInstructions)
                        {
                            RecieptPrinter.PrintLine("    " + instr);
                        }
                        
                    }
                    RecieptPrinter.PrintLine("Subtotal: " + ord.Subtotal.ToString("C", CultureInfo.CurrentCulture));
                    RecieptPrinter.PrintLine("Tax: " + ord.Tax.ToString("C", CultureInfo.CurrentCulture));
                    RecieptPrinter.PrintLine("Total: " + ord.Total.ToString("C", CultureInfo.CurrentCulture));
                    RecieptPrinter.PrintLine("Payment Method: Credit/Debit");
                    RecieptPrinter.PrintLine("Change Owed: $ 0.00");
                    RecieptPrinter.CutTape();
                }                                 
            }           
        }

        /// <summary>
        /// Resturns to current order and adds back in width to order column
        /// </summary>
        /// <param name="sender">used for click event</param>
        /// <param name="e">used for click event</param>
        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            
            parentOrder.ColumnToHide.Width = parentOrder.ReferenceColumn.Width;
            parentOrder.menuBorder.Child = new MenuComponent(parentOrder);
        }
    }
}
