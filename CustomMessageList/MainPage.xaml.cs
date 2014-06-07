using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CustomMessageList.Resources;
using System.Windows.Media;
using System.Diagnostics;

namespace CustomMessageList
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void openMessage(object sender, RoutedEventArgs e)
        {

            List<string> list = new List<string>();

            for (int i = 0; i < 16; i++)
            {
                list.Add("Teste " + i);
            }

            LongListSelector longList = new LongListSelector();
            longList.ItemTemplate = (DataTemplate)Application.Current.Resources["listContent"];
            longList.ItemsSource = list;

            CustomMessageBox customMessageBox = new CustomMessageBox()
            {
                Title = "Hotel Urbano",
                Background = new SolidColorBrush(Colors.White),
                Foreground = new SolidColorBrush(Colors.Black),
                Content = longList,                
                LeftButtonContent = "Fechar"

            };
            customMessageBox.Show();

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