using Core;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Shapes;

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
            LineVM.Lines.Add(line0);
            LineVM.Lines.Add(line1);
            LineVM.Lines.Add(line2);
            LineVM.Lines.Add(line3);
            LineVM.Lines.Add(line4);
            LineVM.Lines.Add(line5);
            LineVM.Lines.Add(line6);
            LineVM.Lines.Add(line7);
            LineVM.Lines.Add(line8);
            LineVM.Lines.Add(line9);
            LineVM.Lines.Add(line10);
            LineVM.Lines.Add(line11);
            LineVM.Lines.Add(line12);
            LineVM.Lines.Add(line13);
            LineVM.Lines.Add(line14);
            LineVM.Lines.Add(line15);
            LineVM.Lines.Add(line16);
            LineVM.Lines.Add(line17);
            LineVM.Lines.Add(line18);
            LineVM.Lines.Add(line19);
            LineVM.Lines.Add(line20);
            LineVM.Lines.Add(line21);
            LineVM.Lines.Add(line22);
            LineVM.Lines.Add(line23);
            LineVM.Lines.Add(line24);
            LineVM.Lines.Add(line25);
            LineVM.Lines.Add(line26);
            LineVM.Lines.Add(line27);
            LineVM.Lines.Add(line28);
            LineVM.Lines.Add(line29);
            LineVM.Lines.Add(line30);
            LineVM.Lines.Add(line31);
            LineVM.Lines.Add(line32);
            LineVM.Lines.Add(line33);
            LineVM.Lines.Add(line34);
            LineVM.Lines.Add(line35);
        }
    }
}