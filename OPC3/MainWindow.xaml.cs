using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OPC3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            double left = _random.NextDouble() * (ActualWidth - button.ActualWidth);
            double top = _random.NextDouble() * (ActualHeight - button.ActualHeight);
            button.Margin = new Thickness(left, top, 0, 0);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }



    }
}

