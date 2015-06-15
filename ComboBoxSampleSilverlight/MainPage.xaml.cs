using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ComboBoxSampleSilverlight.Resources;
using System.Diagnostics;

namespace ComboBoxSampleSilverlight
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            List<string> Alphabets = new List<string>();
            Alphabets.Add("A");
            Alphabets.Add("B");
            Alphabets.Add("C");
            Alphabets.Add("D");
            Alphabets.Add("E");
            Alphabets.Add("F");


            ComboBox.ItemsSource = Alphabets;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                var itemValue = ComboBox.SelectedItem as string;//TaggedLocations;
                Debug.WriteLine(itemValue);
                //LocationForTask = sel.Location;
                //todoDone.IsEnabled = true;
                //MessageBox.Show(LocationForTask);

            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}