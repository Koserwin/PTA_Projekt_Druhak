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
using System.Xml.Serialization;

namespace PTA_Projekt
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int win_b = 0;
        public static int win_g = 0;
        

        public string[] adresy = { "/OBR/1.png", "/OBR/2.png", "/OBR/3.jpg", "/OBR/4.png", "/OBR/5.jpg" };


        const string Path = "MyDB.xml";
        public int[] pole = new int[2];

        


        public string rezim = "";
        public MainWindow()
        {
            InitializeComponent();

            OBRAZ();

            this.Closed += (s, e) => SaveData();
            this.Loaded += (s, e) =>
            {
                LoadData();
                
            };
        }

        private void OBRAZ()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string path2 = path.Substring(0, path.Length - 26);
            path2 += adresy[Edit.obrazek_konecne];


            Uri iconUri = new Uri(path2, UriKind.RelativeOrAbsolute);
            IMG_M.Source = BitmapFrame.Create(iconUri);


        }

        private void SaveData()
        {
            pole[0] = win_b;
            pole[1] = win_g;
            


            try
            {
                XmlSerializer serializer = new XmlSerializer(pole.GetType());

                using (StreamWriter sw = new StreamWriter(Path))
                {
                    serializer.Serialize(sw, pole);
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show("Došlo k neočekávané chybě při ukládání!");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(Path))
                {
                    XmlSerializer serializer = new XmlSerializer(pole.GetType());
                    using (StreamReader sr = new StreamReader(Path))
                    {
                        pole = (int[])serializer.Deserialize(sr)!;
                        win_b = pole[0];
                        win_g = pole[1];
                        
                        
                    }
                }
                else
                    throw new Exception($"Soubor {Path} nenalezen!");
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Edit edit= new Edit();
            edit.ShowDialog();
            OBRAZ();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveData();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Nastaveni n = new Nastaveni();
            n.ShowDialog();
        }
    }
}
