using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectGroup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.Navigate(new HomePage());
        }

        private void Entry_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.Navigate(new EntryPage());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.Navigate(new AboutPage());
        }

        private void Design_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.Navigate(new Design());
        }
    }
}

