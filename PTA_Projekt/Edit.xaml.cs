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
    /// Interakční logika pro Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {

        public string[] adresy = {"/OBR/1.png", "/OBR/2.png", "/OBR/3.jpg", "/OBR/4.png", "/OBR/5.jpg"};
        
        public static int obrazek = 0;
        public static int obrazek_konecne = 0;


        public Edit()
        {
            InitializeComponent();

            refresh();

            OBRA();








        }
        private void refresh()
        {
            WIN_B.Content = $"Win easy bot: {MainWindow.win_b}";
            WIN_G.Content = $"Win good bot: {MainWindow.win_g}";
            
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            switch(obrazek)
            {
                case 0:
                    obrazek_konecne = 0;
                    break;
                case 1:
                    if (MainWindow.win_b >= 70) { obrazek_konecne = 1 ;} else { MessageBox.Show("You need Win easy bot: 70"); }
                    break;
                case 2:
                    if (MainWindow.win_b >= 200) { obrazek_konecne = 2; } else { MessageBox.Show("You need Win easy bot: 200"); }
                    break;
                case 3:
                    if (MainWindow.win_g >= 500) { obrazek_konecne = 3; } else { MessageBox.Show("You need Win good bot: 500"); }
                    break;
                case 4:
                    if (MainWindow.win_g >= 1500) { obrazek_konecne = 4; } else { MessageBox.Show("You need Win good bot: 1500"); }
                    break;

            }







        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (obrazek - 1 == -1)
            {
                obrazek = 4;
            }
            else
            {

                obrazek -= 1;
            }
            OBRA();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (obrazek+1 == 5)
            {
                obrazek = 0;
            }
            else
            {

                obrazek+=1;
            }
            OBRA();

        }

        private void OBRA()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string path2 = path.Substring(0, path.Length - 26);
            path2 += adresy[obrazek];


            Uri iconUri = new Uri(path2, UriKind.RelativeOrAbsolute);
            IMG_E.Source = BitmapFrame.Create(iconUri);



        }
    }
}
