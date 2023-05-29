using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PTA_Projekt
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int win_b = 0;
        public static int win_g = 0;
        
        public string rezim = "";
        public MainWindow()
        {
            InitializeComponent();
            
           
            

        }
        

        

        

        private void TTT_n_Click(object sender, RoutedEventArgs e)
        {
            rezim = "NoobBot";
            Hraci_pole h = new Hraci_pole(rezim);
            h.ShowDialog();
            

        }

        private void TTT_b_Click(object sender, RoutedEventArgs e)
        {
            rezim = "GoodBot";
            Hraci_pole h = new Hraci_pole(rezim);
            h.ShowDialog();

            
        }

        private void TTT_f_Click(object sender, RoutedEventArgs e)
        {
            rezim = "Friend";
            Hraci_pole h = new Hraci_pole(rezim);
            h.ShowDialog();
        }

        
    }
}
