using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using sdkTileSample.Resources;

namespace sdkTileSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();
        }

        private void applicationTileSetBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ApplicationTileSetPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void secondaryTileSetBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SecondaryTileSetPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}