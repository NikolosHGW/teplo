using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Core;

namespace Teplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ButtonsVM();
        }
    }
}