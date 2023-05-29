using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PTA_Projekt
{
    /// <summary>
    /// Interakční logika pro Nastaveni.xaml
    /// </summary>
    public partial class Nastaveni : Window
    {
        public Nastaveni()
        {
            

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            MessageBoxResult result = MessageBox.Show("Are you sure want reset account, your progres will be lost", "Warning!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow.win_b = 0;
                MainWindow.win_g = 0;
                C1 = false;
                C2 = false;
                C3 = false;
                C4 = false;
                Edit.obrazek_konecne = 0;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private string[] cody = { "IWin100BB_kj54fDgd", "IWin100GB_554fejgGHG", "IWIN2000BB_g46F4f4", "IWIN2000GB_hjg466bGV" };
        private bool C1 = false;
        private bool C2 = false;
        private bool C3 = false;
        private bool C4= false;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (Code_S.Text == cody[0] && !C1)
            {
                C1 = true;
                MainWindow.win_b += 100;
                MessageBox.Show("Code was applied");
                Code_S.Text = "";
            }
            else if (Code_S.Text == cody[1] && !C2)
            {
                C1 = true;

                MessageBox.Show("Code was applied");
                Code_S.Text = "";
                MainWindow.win_g += 100;
            }
            else if (Code_S.Text == cody[2] && !C3)
            {
                C1 = true;

                MessageBox.Show("Code was applied");
                Code_S.Text = "";
                MainWindow.win_b += 2000;
            }
            else if (Code_S.Text == cody[3] && !C4)
            {
                C1 = true;

                MessageBox.Show("Code was applied");
                Code_S.Text = "";
                MainWindow.win_g += 2000;
            }
            else
                MessageBox.Show("Code dont exist");


        }
    }
}
