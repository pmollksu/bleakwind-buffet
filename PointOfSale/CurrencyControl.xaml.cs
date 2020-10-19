/*
 * Author: Patrick Moll
 * Class name: CurrencyControl.xaml.cs
 * Purpose: Defines a control to see how many bills/coins are given/recieved in an order
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl, INotifyPropertyChanged
    {

        public CurrencyControl()
        {
            InitializeComponent();
            Increment.Click += HandleButtonClick;
            Decrement.Click += HandleButtonClick;
            
        }

        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Identifies the CurrencyControl.StepProperty XAML attached property
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CurrencyControl), new PropertyMetadata(1));

        /// <summary>
        /// Identifies the CurrencyControl.MoneyString XAML attached property
        /// </summary>
        public static DependencyProperty MoneyStringProperty = DependencyProperty.Register("MoneyString", typeof(string), typeof(CurrencyControl), new PropertyMetadata(""));

        /// <summary>
        /// Identifies the CurrencyControl.ChangeQuantity XAML attached property
        /// </summary>
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));

        /// <summary>
        /// Identifies the CurrencyControl.CustomerQuantity XAML attached property
        /// </summary>
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));

        /// <summary>
        /// The amount each increment or decrement operation should change the value by
        /// </summary>
        public string MoneyString
        {
            get { return (string)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }


        /// <summary>
        /// The amount each increment or decrement operation should change the value by
        /// </summary>
        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        /// <summary>
        /// The CurrencyControl's displayed CustomerQuantity
        /// </summary>
        public int CustomerQuantity
        {
            get { return (int)GetValue(CustomerQuantityProperty); }
            set { SetValue(CustomerQuantityProperty, value); }
        }

        /// <summary>
        /// The CurrencyControl's displayed CustomerQuantity
        /// </summary>
        public int ChangeQuantity
        {
            get { return (int)GetValue(ChangeQuantityProperty); }
            set { SetValue(ChangeQuantityProperty, value); }
        }


        /// <summary>
        /// Handles the click of the increment or decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        CustomerQuantity += Step;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuantity"));
                        break;
                    case "Decrement":
                        CustomerQuantity -= Step;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuantity"));
                        break;
                }
            }
            e.Handled = true;
        }

        /// <summary>
        /// Identifies the CurrencyControl.GivenCustomerQuantityClamped event
        /// </summary>
        public static readonly RoutedEvent GivenCustomerQuantityClampedEvent = EventManager.RegisterRoutedEvent("GivenCustomerQuantityClamped", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CurrencyControl));

        /// <summary>
        /// Event that is triggered when the value of this NumberBox changes
        /// </summary>
        public event RoutedEventHandler GivenCustomerQuantityClamped
        {
            add { AddHandler(GivenCustomerQuantityClampedEvent, value); }
            remove { RemoveHandler(GivenCustomerQuantityClampedEvent, value); }
        }

        /// <summary>
        /// Callback for the CustomerQuantityProperty, which clamps the Value to the range 
        /// defined by MinValue(0) and MaxValue(10)
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name == "CustomerQuantity" && sender is CurrencyControl box)
            {
                if (box.CustomerQuantity <= 0)
                {
                    box.CustomerQuantity = 0;
                    box.RaiseEvent(new RoutedEventArgs(GivenCustomerQuantityClampedEvent));
                }
                if (box.CustomerQuantity >= 10)
                {
                    box.CustomerQuantity = 10;
                    box.RaiseEvent(new RoutedEventArgs(GivenCustomerQuantityClampedEvent));
                }
            }
        }



    }
}
