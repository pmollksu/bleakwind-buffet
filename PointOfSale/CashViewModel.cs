/*
 * Author: Patrick Moll
 * Class name: CashViewModel.cs
 * Purpose: The ViewModel class to be used for binding for CashPaymentComponent
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Printing;
using System.Text;
using System.Transactions;
using System.Windows.Automation.Provider;
using System.Xml.Schema;

namespace PointOfSale
{
    public class CashViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Order curOrder;
        public CashViewModel(Order ord)
        {
            curOrder = ord;
        }

        private int ones = 0;
        /// <summary>
        /// Amount of ones tendered from customer
        /// </summary>
        public int Ones
        {
            get => ones;
            set
            {
                if(ones != value)
                {
                    ones = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }


        /// <summary>
        /// Amount of ones owed to customer
        /// </summary>
        public int OnesOwed { get; set; }


        private int twos = 0;
        /// <summary>
        /// Amount of twos tendered from customer
        /// </summary>
        public int Twos
        {
            get => twos;
            set
            {
                if (twos != value)
                {
                    twos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Twos owed to customer
        /// </summary>
        public int TwosOwed { get; set; }


        private int fives = 0;
        /// <summary>
        /// Amount of Fives tendered from customer
        /// </summary>
        public int Fives
        {
            get => fives;
            set
            {
                if (fives != value)
                {
                    fives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Fives owed to customer
        /// </summary>
        public int FivesOwed { get; set; }

        private int tens = 0;
        /// <summary>
        /// Amount of tens tendered from customer
        /// </summary>
        public int Tens
        {
            get => tens;
            set
            {
                if (tens != value)
                {
                    tens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Tens owed to customer
        /// </summary>
        public int TensOwed { get; set; }

        private int twenties = 0;
        /// <summary>
        /// Amount of of twenties tendered from customer
        /// </summary>
        public int Twenties
        {
            get => twenties;
            set
            {
                if (twenties != value)
                {
                    twenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Twenties owed to customer
        /// </summary>
        public int TwentiesOwed { get; set; }


        private int fifties = 0;
        /// <summary>
        /// Amount of fifties tendered from customer
        /// </summary>
        public int Fifties
        {
            get => fifties;
            set
            {
                if (fifties != value)
                {
                    fifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Fifties owed to customer
        /// </summary>
        public int FiftiesOwed { get; set; }

        private int hundreds = 0;
        /// <summary>
        /// Amount of hundreds tendered from customer
        /// </summary>
        public int Hundreds
        {
            get => hundreds;
            set
            {
                if (hundreds != value)
                {
                    hundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Hundreds owed to customer
        /// </summary>
        public int HundredsOwed { get; set; }


        private int dollars = 0;
        /// <summary>
        /// Amount of Dollars tendered from customer
        /// </summary>
        public int Dollars
        {
            get => dollars;
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Dollars owed to customer
        /// </summary>
        public int DollarsOwed { get; set; }



        private int halfdollars = 0;
        /// <summary>
        /// Amount of HalfDollars tendered from customer
        /// </summary>
        public int HalfDollars
        {
            get => halfdollars;
            set
            {
                if (halfdollars != value)
                {
                    halfdollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of HalfDollars owed to customer
        /// </summary>
        public int HalfDollarsOwed { get; set; }



        private int quarters = 0;
        /// <summary>
        /// Amount of Quarters tendered from customer
        /// </summary>
        public int Quarters
        {
            get => quarters;
            set
            {
                if (quarters != value)
                {
                    quarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Quarters owed to customer
        /// </summary>
        public int QuartersOwed { get; set; }


        private int dimes = 0;
        /// <summary>
        /// Amount of Dimes tendered from customer
        /// </summary>
        public int Dimes
        {
            get => dimes;
            set
            {
                if (dimes != value)
                {
                    dimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Dimes owed to customer
        /// </summary>
        public int DimesOwed { get; set; }


        private int nickels = 0;
        /// <summary>
        /// Amount of Nickels tendered from customer
        /// </summary>
        public int Nickels
        {
            get => nickels;
            set
            {
                if (nickels != value)
                {
                    nickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Nickels owed to customer
        /// </summary>
        public int NickelsOwed { get; set; }


        private int pennies = 0;
        /// <summary>
        /// Amount of Pennies tendered from customer
        /// </summary>
        public int Pennies
        {
            get => pennies;
            set
            {
                if (pennies != value)
                {
                    pennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTendered"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwed"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    CalculateChange();
                    NotifyOwedProperties();
                }
            }
        }

        /// <summary>
        /// Amount of Pennies owed to customer
        /// </summary>
        public int PenniesOwed { get; set; }


        /// <summary>
        /// Updates all bills and coins owed for change
        /// </summary>
        public void CalculateChange()
        {
            decimal amtOwned = (decimal)AmountOwed;
            HundredsOwed = (int)(amtOwned / 100);
            amtOwned %= 100;
            FiftiesOwed = (int)(amtOwned / 50);
            amtOwned %= 50;
            TwentiesOwed = (int)(amtOwned / 20);
            amtOwned %= 20;
            TensOwed = (int)(amtOwned / 10);
            amtOwned %= 10;
            FivesOwed = (int)(amtOwned / 5);
            amtOwned %= 5;
            OnesOwed = (int)(amtOwned / 1);
            amtOwned %= 1;
            HalfDollarsOwed = (int)(amtOwned / .5m);
            amtOwned %= .5m;
            QuartersOwed = (int)(amtOwned / .25m);
            amtOwned %= .25m;
            DimesOwed = (int)(amtOwned / .10m);
            amtOwned %= .10m;
            NickelsOwed = (int)(amtOwned / .05m);
            amtOwned %= .05m;
            PenniesOwed = (int)(amtOwned / .01m);
            amtOwned %= .01m;


        }

        public void NotifyOwedProperties()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesOwed"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsOwed"));
        }

        /// <summary>
        /// Amount given by customer
        /// </summary>
        public double AmountTendered
        {
            get => (Ones) + (Twos * 2) + (Fives * 5) + (Tens * 10) + (Twenties * 20) + (Fifties * 50) + (Hundreds * 100) +
                (Dollars) + (HalfDollars * .5) + (Quarters * .25) + (Dimes * .1) + (Nickels * .05) + (Pennies * .01); 
        }

        /// <summary>
        /// Total price of the order
        /// </summary>
        public double Total
        {
            get => curOrder.Total;
        }

        /// <summary>
        /// Amount owed to the customer
        /// </summary>
        public double AmountOwed
        {
            get
            {
                if (AmountTendered >= Total)
                {
                    return AmountTendered - Total;
                }
                else return 0.0;
            }
        }

        /// <summary>
        /// Amount due from the customer
        /// </summary>
        public double AmountDue
        {
            get
            {
                if (Total > AmountTendered)
                {
                    return Total - AmountTendered;
                }
                else return 0.0;
            }
        }


        /// <summary>
        /// Adds and removes bills and coins from register to finalize sale
        /// </summary>
        /// <returns>whether or not the sale could be finalized</returns>
        public bool FinalizeSale()
        {
            if (AmountDue == 0.0)
            {
                CashDrawer.OpenDrawer();
                CashDrawer.Hundreds += Hundreds;
                CashDrawer.Hundreds -= HundredsOwed;
                CashDrawer.Fifties += Fifties;
                CashDrawer.Fifties -= FiftiesOwed;
                CashDrawer.Twenties += Twenties;
                CashDrawer.Twenties -= TwentiesOwed;
                CashDrawer.Tens += Tens;
                CashDrawer.Tens -= TensOwed;
                CashDrawer.Fives += Fives;
                CashDrawer.Fives -= FivesOwed;
                CashDrawer.Ones += Ones;
                CashDrawer.Ones -= OnesOwed;
                CashDrawer.Dollars += Dollars;
                CashDrawer.Dollars -= DollarsOwed;
                CashDrawer.HalfDollars += HalfDollars;
                CashDrawer.HalfDollars -= HalfDollarsOwed;
                CashDrawer.Quarters += Quarters;
                CashDrawer.Quarters -= QuartersOwed;
                CashDrawer.Dimes += Dimes;
                CashDrawer.Dimes -= DimesOwed;
                CashDrawer.Nickels += Nickels;
                CashDrawer.Nickels -= NickelsOwed;
                CashDrawer.Pennies += Pennies;
                CashDrawer.Pennies -= PenniesOwed;
                return true;
            }
            return false;

        }

        /// <summary>
        /// Prints out the Receipt for the current order when Cash is approved
        /// </summary>
        public void PrintCashReceipt()
        {

            RecieptPrinter.PrintLine("Order Number " + curOrder.Number.ToString());
            RecieptPrinter.PrintLine(DateTime.Now.ToString());
            foreach (IOrderItem item in curOrder)
            {
                RecieptPrinter.PrintLine(item.ToString());
                RecieptPrinter.PrintLine("    " + item.Price.ToString("C", CultureInfo.CurrentCulture));
                foreach (String instr in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("    " + instr);
                }

            }
            RecieptPrinter.PrintLine("Subtotal: " + curOrder.Subtotal.ToString("C", CultureInfo.CurrentCulture));
            RecieptPrinter.PrintLine("Tax: " + curOrder.Tax.ToString("C", CultureInfo.CurrentCulture));
            RecieptPrinter.PrintLine("Total: " + curOrder.Total.ToString("C", CultureInfo.CurrentCulture));
            RecieptPrinter.PrintLine("Payment Method: Cash");
            RecieptPrinter.PrintLine("Change Owed: " + AmountOwed.ToString("C",CultureInfo.CurrentCulture));
            RecieptPrinter.CutTape();


        }
    }
}
