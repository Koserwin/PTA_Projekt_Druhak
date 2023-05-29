using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interakční logika pro Hraci_pole.xaml
    /// </summary>
    public partial class Hraci_pole : Window
    {
        private int kolo = 1;
        private int player = 1;
        private int p1_win = 0;
        private int p2_win = 0;
        private bool F1 = false;
        private bool F2 = false;
        private bool F3 = false;
        private bool F4 = false;
        private bool F5 = false;
        private bool F6 = false;
        private bool F7 = false;
        private bool F8 = false;
        private bool F9 = false;
        private string P1 = "f";
        private string P2 = "f";
        private string P3 = "f";
        private string P4 = "f";
        private string P5 = "f";
        private string P6 = "f";
        private string P7 = "f";
        private string P8 = "f";
        private string P9 = "f";
        private bool win = false;
        private string rezim_;
        private int pocet_poli = 0;
        private string znak = "O";
        private string znak_oponent = "X";
        public int win_ba = 0;
        public int win_go = 0;
        
        


        public Hraci_pole(string rezim)
        {

            rezim_ = rezim;
            
            InitializeComponent();

            if (rezim_ == "Friend")
            {
                Protivnik_img.Visibility = Visibility.Collapsed;
                Protivnik_img2.Visibility = Visibility.Visible;
                
                
            }
                znak_L_H.Foreground = Brushes.Red;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!F1)
            {
                
                if (player == 1)
                {
                    B1_p.Content = znak_oponent;
                    B1_p.IsHitTestVisible = false;

                }
                else
                {
                    B1_p.Content = znak;
                    B1_p.IsHitTestVisible = false;

                }
                F1 = true;
                
            }

            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!F2)
            {
                if (player == 1)
                {
                    B2_p.Content = znak_oponent;
                    B2_p.IsHitTestVisible = false;

                }
                else
                {
                    B2_p.Content = znak;
                    B2_p.IsHitTestVisible = false;

                }
                F2 = true;

            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!F3)
            {
                if (player == 1)
                {
                    B3_p.Content = znak_oponent;
                    B3_p.IsHitTestVisible = false;

                }
                else
                {
                    B3_p.Content = znak;
                    B3_p.IsHitTestVisible = false;


                }
                F3 = true;            
            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!F4)
            {
                if (player == 1)
                {
                    B4_p.Content = znak_oponent;
                    B4_p.IsHitTestVisible = false;

                }
                else
                {
                    B4_p.Content = znak;
                    B4_p.IsHitTestVisible = false;

                }
                F4 = true;
            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!F5)
            {
                if (player == 1)
                {
                    B5_p.Content = znak_oponent;
                    B5_p.IsHitTestVisible = false;

                }
                else
                {
                    B5_p.Content = znak;
                    B5_p.IsHitTestVisible = false;

                }
                F5 = true;
            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            if (!F6)
            {
                if (player == 1)
                {
                    B6_p.Content = znak_oponent;
                    B6_p.IsHitTestVisible = false;

                }
                else
                {
                    B6_p.Content = znak;
                    B6_p.IsHitTestVisible = false;

                }
                F6 = true;
            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!F7)
            {
                if (player == 1)
                {
                    B7_p.Content = znak_oponent;
                    B7_p.IsHitTestVisible = false;

                }
                else
                {
                    B7_p.Content = znak;
                    B7_p.IsHitTestVisible = false;

                }
                F7 = true;
            }
            Kontrola();
            Hrac(); 
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!F8)
            {
                if (player == 1)
                {
                    B8_p.Content = znak_oponent;
                    B8_p.IsHitTestVisible = false;

                }
                else
                {
                    B8_p.Content = znak;
                    B8_p.IsHitTestVisible = false;

                }
                F8 = true;
            }
            Kontrola();

            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (!F9)
            {
                if (player == 1)
                {
                    B9_p.Content = znak_oponent;
                    B9_p.IsHitTestVisible = false;
                }
                else
                {
                    B9_p.Content = znak;
                    B9_p.IsHitTestVisible = false;

                }
                F9 = true;
            }
            Kontrola();
            Hrac();
            if (win)
            {

                Kontrola_t();
            }
        }

        private void Hrac()
        {
            if (player == 1)
            {
                player = 2;
                znak_L_H.Foreground = Brushes.Black;
                znak_L_O.Foreground = Brushes.Red;
                nBot();
                gBot();
                

            }
            else
            {
                player = 1;
                znak_L_H.Foreground = Brushes.Red;
                znak_L_O.Foreground = Brushes.Black;
            }

        }
        

        private void New_game_Click(object sender, RoutedEventArgs e)
        {
            
            F1 = false;
            F2 = false;
            F3 = false;
            F4 = false;
            F5 = false;
            F6 = false;
            F7 = false;
            F8 = false;
            F9 = false;
            B1_p.Content = "";
            B2_p.Content = "";
            B3_p.Content = "";
            B4_p.Content = "";
            B5_p.Content = "";
            B6_p.Content = "";
            B7_p.Content = "";
            B8_p.Content = "";
            B9_p.Content = "";
            C_123.Visibility = Visibility.Collapsed;
            C_456.Visibility = Visibility.Collapsed;
            C_789.Visibility = Visibility.Collapsed;
            C_147.Visibility = Visibility.Collapsed;
            C_258.Visibility = Visibility.Collapsed;
            C_369.Visibility = Visibility.Collapsed;
            C_159.Visibility = Visibility.Collapsed;
            C_357.Visibility = Visibility.Collapsed;
            win = false;
            B1_p.IsHitTestVisible = true;
            B2_p.IsHitTestVisible = true;
            B3_p.IsHitTestVisible = true;
            B4_p.IsHitTestVisible = true;
            B5_p.IsHitTestVisible = true;
            B6_p.IsHitTestVisible = true;
            B7_p.IsHitTestVisible = true;
            B8_p.IsHitTestVisible = true;
            B9_p.IsHitTestVisible = true;
            kolo++;
            pocet_poli = 0;
            Change_ornament.IsEnabled = true;
            B1_p.Foreground = Brushes.Black;
            B2_p.Foreground = Brushes.Black;
            B3_p.Foreground = Brushes.Black;
            B4_p.Foreground = Brushes.Black;
            B5_p.Foreground = Brushes.Black;
            B6_p.Foreground = Brushes.Black;
            B7_p.Foreground = Brushes.Black;
            B8_p.Foreground = Brushes.Black;
            B9_p.Foreground = Brushes.Black;



            if (kolo % 2 == 0)
            {
                player = 2;
                znak_L_H.Foreground = Brushes.Black;
                znak_L_O.Foreground = Brushes.Red;
                nBot();
                gBot();
                


            }
            if (kolo % 2 != 0)
            {
                player = 1;
                znak_L_H.Foreground = Brushes.Red;
                znak_L_O.Foreground = Brushes.Black;

            }

        }

        private void Quit_game_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure want quit the game, your actual progres will be lost", "Warning!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }

            
        }

        private void Kontrola_t()
        {
            znak_L_H.Foreground = Brushes.Black;
            znak_L_O.Foreground = Brushes.Black;

        }
        private void Kontrola()
        {
            Change_ornament.IsEnabled = false;
            pocet_poli++;

            P1 = Convert.ToString(B1_p.Content);
            P2 = Convert.ToString(B2_p.Content);
            P3 = Convert.ToString(B3_p.Content);
            P4 = Convert.ToString(B4_p.Content);
            P5 = Convert.ToString(B5_p.Content);
            P6 = Convert.ToString(B6_p.Content);
            P7 = Convert.ToString(B7_p.Content);
            P8 = Convert.ToString(B8_p.Content);
            P9 = Convert.ToString(B9_p.Content);


            if (P1 == "X" && P2 == "X" && P3 == "X" || P1 == "O" && P2 == "O" && P3 == "O")
            {
                B1_p.Foreground = Brushes.Green;
                B2_p.Foreground = Brushes.Green;
                B3_p.Foreground = Brushes.Green;

                win = true;
            }else if ((P4 == "X" && P5 == "X" && P6 == "X") || (P4 == "O" && P5 == "O" && P6 == "O"))
            {
                win = true;
                B4_p.Foreground = Brushes.Green;
                B5_p.Foreground = Brushes.Green;
                B6_p.Foreground = Brushes.Green;
            }
            else if(P7 == "X" && P8 == "X" && P9 == "X" || P7 == "O" && P8 == "O" && P9 == "O")
            {
                win = true;
                B7_p.Foreground = Brushes.Green;
                B8_p.Foreground = Brushes.Green;
                B9_p.Foreground = Brushes.Green;
            }
            else if(P1 == "X" && P4 == "X" && P7 == "X" || P1 == "O" && P4 == "O" && P7 == "O")
            {
                win = true;
                B1_p.Foreground = Brushes.Green;
                B4_p.Foreground = Brushes.Green;
                B7_p.Foreground = Brushes.Green;
            }
            else if(P2 == "X" && P5 == "X" && P8 == "X" || P2 == "O" && P5 == "O" && P8 == "O")
            {
                win = true;
                B2_p.Foreground = Brushes.Green;
                B5_p.Foreground = Brushes.Green;
                B8_p.Foreground = Brushes.Green;
            }
            else if(P3 == "X" && P6 == "X" && P9 == "X" || P3 == "O" && P6 == "O" && P9 == "O")
            {
                win = true;
                B3_p.Foreground = Brushes.Green;
                B6_p.Foreground = Brushes.Green;
                B9_p.Foreground = Brushes.Green;
            }
            else if(P1 == "X" && P5 == "X" && P9 == "X" || P1 == "O" && P5 == "O" && P9 == "O")
            {
                win = true;
                B1_p.Foreground = Brushes.Green;
                B5_p.Foreground = Brushes.Green;
                B9_p.Foreground = Brushes.Green;
            }
            else if(P3 == "X" && P5 == "X" && P7 == "X" || P3 == "O" && P5 == "O" && P7 == "O")
            {
                win = true;
                B3_p.Foreground = Brushes.Green;
                B5_p.Foreground = Brushes.Green;
                B7_p.Foreground = Brushes.Green;
            }


            if (win)
            {
                Change_ornament.IsEnabled = true;

                znak_L_H.Foreground = Brushes.Black;
                znak_L_O.Foreground = Brushes.Black;

                F1 = true;
                F2 = true;
                F3 = true;
                F4 = true;
                F5 = true;
                F6 = true;
                F7 = true;
                F8 = true;
                F9 = true;
                
                B1_p.IsHitTestVisible= false;
                B2_p.IsHitTestVisible = false;
                B3_p.IsHitTestVisible = false;
                B4_p.IsHitTestVisible = false;
                B5_p.IsHitTestVisible = false;
                B6_p.IsHitTestVisible = false;
                B7_p.IsHitTestVisible = false;
                B8_p.IsHitTestVisible = false;
                B9_p.IsHitTestVisible = false;

                if (player == 1)
                {
                    p1_win++;

                    if (rezim_ == "NoobBot")
                    {
                        win_ba++;
                        

                    }
                    if (rezim_ == "GoodBot")
                    {

                        win_go++;

                        


                    }


                }
                else
                {
                    p2_win++;
                    

                }

                Score.Content = $"P1  {p1_win} : {p2_win}  P2";

                

            }

            
            
            if (pocet_poli == 9)
            {

                Change_ornament.IsEnabled = true;
                znak_L_H.Foreground = Brushes.Black;
                znak_L_O.Foreground = Brushes.Black;

            }















        }

        Random r = new Random();
        private void nBot()
        {




            if (rezim_ == "NoobBot" && win == false && pocet_poli != 9)
            {
                bool nbot_pole = false;


                znak_L_H.Foreground = Brushes.Red;
                znak_L_O.Foreground = Brushes.Black;


                do
                {
                    int nbot_vyber = r.Next(1, 10);

                    switch (nbot_vyber)
                    {

                        case 1:
                            if (F1 == false) { B1_p.Content = znak; nbot_pole = true; F1 = true; B1_p.IsHitTestVisible = false; }
                            break;
                        case 2:
                            if (F2 == false) { B2_p.Content = znak; nbot_pole = true; F2 = true; B2_p.IsHitTestVisible = false; }
                            break;
                        case 3:
                            if (F3 == false) { B3_p.Content = znak; nbot_pole = true; F3 = true; B3_p.IsHitTestVisible = false; }
                            break;
                        case 4:
                            if (F4 == false) { B4_p.Content = znak; nbot_pole = true; F4 = true; B4_p.IsHitTestVisible = false; }
                            break;
                        case 5:
                            if (F5 == false) { B5_p.Content = znak; nbot_pole = true; F5 = true; B5_p.IsHitTestVisible = false; }
                            break;
                        case 6:
                            if (F6 == false) { B6_p.Content = znak; nbot_pole = true; F6 = true; B6_p.IsHitTestVisible = false; }
                            break;
                        case 7:
                            if (F7 == false) { B7_p.Content = znak; nbot_pole = true; F7 = true; B7_p.IsHitTestVisible = false; }
                            break;
                        case 8:
                            if (F8 == false) { B8_p.Content = znak; nbot_pole = true; F8 = true; B8_p.IsHitTestVisible = false; }
                            break;
                        case 9:
                            if (F9 == false) { B9_p.Content = znak; nbot_pole = true; F9 = true; B9_p.IsHitTestVisible = false; }
                            break;

                    }



                } while (nbot_pole == false);





                Kontrola();

                player = 1;



            }
        }

        private bool gbot_vyber;
        private int l;
        private int n;
        private void gBot()
        {

            if (rezim_ == "GoodBot" && win == false && pocet_poli != 9)
            {
                znak_L_H.Foreground = Brushes.Red;
                znak_L_O.Foreground = Brushes.Black;

                gbot_vyber = false;
                P1 = Convert.ToString(B1_p.Content);
                P2 = Convert.ToString(B2_p.Content);
                P3 = Convert.ToString(B3_p.Content);
                P4 = Convert.ToString(B4_p.Content);
                P5 = Convert.ToString(B5_p.Content);
                P6 = Convert.ToString(B6_p.Content);
                P7 = Convert.ToString(B7_p.Content);
                P8 = Convert.ToString(B8_p.Content);
                P9 = Convert.ToString(B9_p.Content);
                string[,] pole = new string[5, 5] { { ".", ".", ".", ".", ".", }, { ".", P1, P2, P3, ".", }, { ".", P4, P5, P6, ".", }, { ".", P7, P8, P9, ".", }, { ".", ".", ".", ".", ".", } };

                //pole[0, 0] = P1;
                //pole[1, 0] = P2;
                //pole[2, 0] = P3;
                //pole[0, 1] = P4;
                //pole[1, 1] = P5;
                //pole[2, 1] = P6;
                //pole[0, 2] = P7;
                //pole[1, 2] = P8;
                //pole[2, 2] = P9;

               

                    for (int j = 1; j < 4; j++)
                    {

                        for (int k = 1; k < 4; k++)
                        {
                            if (pole[j, k] == znak && gbot_vyber == false)
                            {

                                #region prodtrední pole
                                //if (j == 2 && k == 2 && P5 == znak)
                                //{

                                //    if (pole[j, k + 1] == znak)
                                //    {
                                //        if (pole[j, k - 1] == "")
                                //        {
                                //            l = j;
                                //            n = k - 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j + 1, k + 1] == znak)
                                //    {
                                //        if (pole[j - 1, k - 1] == "")
                                //        {
                                //            l = j - 1;
                                //            n = k - 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j + 1, k] == znak)
                                //    {
                                //        if (pole[j - 1, k] == "")
                                //        {
                                //            l = j - 1;
                                //            n = k;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j + 1, k - 1] == znak)
                                //    {
                                //        if (pole[j - 1, k + 1] == "")
                                //        {
                                //            l = j - 1;
                                //            n = k + 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j, k - 1] == znak)
                                //    {
                                //        if (pole[j, k + 1] == "")
                                //        {
                                //            l = j;
                                //            n = k + 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j - 1, k - 1] == znak)
                                //    {
                                //        if (pole[j + 1, k + 1] == "")
                                //        {
                                //            l = j + 1;
                                //            n = k + 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j - 1, k] == znak)
                                //    {
                                //        if (pole[j + 1, k] == "")
                                //        {
                                //            l = j + 1;
                                //            n = k;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }
                                //    if (pole[j - 1, k + 1] == znak)
                                //    {
                                //        if (pole[j + 1, k - 1] == "")
                                //        {
                                //            l = j + 1;
                                //            n = k - 1;
                                //            gbot_vyber = true;
                                //            Tlacitko_3(l, n);
                                //        }

                                //    }




                                //}
                                //else
                                //{

                                #endregion



                                if (pole[j, k + 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j, k + 2] == "")
                                    {
                                        l = j;
                                        n = k + 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j + 1, k + 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j + 2, k + 2] == "")
                                    {
                                        l = j + 2;
                                        n = k + 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j + 1, k] == znak && gbot_vyber == false)
                                {
                                    if (pole[j + 2, k] == "")
                                    {
                                        l = j + 2;
                                        n = k;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j + 1, k - 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j + 2, k - 2] == "")
                                    {
                                        l = j + 2;
                                        n = k - 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j, k - 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j, k - 2] == "")
                                    {
                                        l = j;
                                        n = k - 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j - 1, k - 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j - 2, k - 2] == "")
                                    {
                                        l = j - 2;
                                        n = k - 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j - 1, k] == znak && gbot_vyber == false)
                                {
                                    if (pole[j - 2, k] == "")
                                    {
                                        l = j - 2;
                                        n = k;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }
                                else if (pole[j - 1, k + 1] == znak && gbot_vyber == false)
                                {
                                    if (pole[j - 2, k + 2] == "")
                                    {
                                        l = j - 2;
                                        n = k + 2;
                                        gbot_vyber = true;
                                        Tlacitko_3(l, n);
                                    }

                                }



                                //}


                            }




                        }




                    }
















                    if (gbot_vyber == false)
                    {
                        for (int j = 1; j < 4; j++)
                        {

                            for (int k = 1; k < 4; k++)
                            {
                                if (pole[j, k] == znak_oponent && gbot_vyber == false)
                                {
                                    #region prostedni pole
                                    //if (j == 2 && k ==2 && P5 == znak_oponent)
                                    //{

                                    //    if (pole[j, k + 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j, k - 1] == "")
                                    //        {
                                    //            l = j;
                                    //            n = k - 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l , n);
                                    //        }

                                    //    }
                                    //    if (pole[j + 1, k + 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j - 1, k - 1] == "")
                                    //        {
                                    //            l = j - 1;
                                    //            n = k - 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j + 1, k] == znak_oponent)
                                    //    {
                                    //        if (pole[j - 1, k] == "")
                                    //        {
                                    //            l = j - 1;
                                    //            n = k;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j + 1, k - 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j - 1, k + 1] == "")
                                    //        {
                                    //            l = j - 1;
                                    //            n = k + 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j, k - 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j, k + 1] == "")
                                    //        {
                                    //            l = j;
                                    //            n = k + 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j - 1, k - 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j + 1, k + 1] == "")
                                    //        {
                                    //            l = j + 1;
                                    //            n = k + 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j - 1, k] == znak_oponent)
                                    //    {
                                    //        if (pole[j + 1, k] == "")
                                    //        {
                                    //            l = j + 1;
                                    //            n = k;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }
                                    //    if (pole[j - 1, k + 1] == znak_oponent)
                                    //    {
                                    //        if (pole[j + 1, k - 1] == "")
                                    //        {
                                    //            l = j + 1;
                                    //            n = k - 1;
                                    //            gbot_vyber = true;
                                    //            Tlacitko_3(l, n);
                                    //        }

                                    //    }




                                    //}
                                    //else
                                    //{

                                    #endregion

                                    if (pole[j, k + 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j, k + 2] == "")
                                        {
                                            l = j;
                                            n = k + 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j + 1, k + 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j + 2, k + 2] == "")
                                        {
                                            l = j + 2;
                                            n = k + 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j + 1, k] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j + 2, k] == "")
                                        {
                                            l = j + 2;
                                            n = k;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j + 1, k - 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j + 2, k - 2] == "")
                                        {
                                            l = j + 2;
                                            n = k - 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j, k - 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j, k - 2] == "")
                                        {
                                            l = j;
                                            n = k - 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j - 1, k - 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j - 2, k - 2] == "")
                                        {
                                            l = j - 2;
                                            n = k - 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j - 1, k] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j - 2, k] == "")
                                        {
                                            l = j - 2;
                                            n = k;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }
                                    if (pole[j - 1, k + 1] == znak_oponent && gbot_vyber == false)
                                    {
                                        if (pole[j - 2, k + 2] == "")
                                        {
                                            l = j - 2;
                                            n = k + 2;
                                            gbot_vyber = true;
                                            Tlacitko_3(l, n);
                                        }

                                    }



                                    //}


                                }




                            }




                        }
                    }

                    if (gbot_vyber == false)
                    {



                        do
                        {

                            int gbot_pokus = r.Next(1, 10);

                            switch (gbot_pokus)
                            {

                                case 1:
                                    if (F1 == false) { B1_p.Content = znak; gbot_vyber = true; F1 = true; B1_p.IsHitTestVisible = false; }
                                    break;
                                case 2:
                                    if (F2 == false) { B2_p.Content = znak; gbot_vyber = true; F2 = true; B2_p.IsHitTestVisible = false; }
                                    break;
                                case 3:
                                    if (F3 == false) { B3_p.Content = znak; gbot_vyber = true; F3 = true; B3_p.IsHitTestVisible = false; }
                                    break;
                                case 4:
                                    if (F4 == false) { B4_p.Content = znak; gbot_vyber = true; F4 = true; B4_p.IsHitTestVisible = false; }
                                    break;
                                case 5:
                                    if (F5 == false) { B5_p.Content = znak; gbot_vyber = true; F5 = true; B5_p.IsHitTestVisible = false; }
                                    break;
                                case 6:
                                    if (F6 == false) { B6_p.Content = znak; gbot_vyber = true; F6 = true; B6_p.IsHitTestVisible = false; }
                                    break;
                                case 7:
                                    if (F7 == false) { B7_p.Content = znak; gbot_vyber = true; F7 = true; B7_p.IsHitTestVisible = false; }
                                    break;
                                case 8:
                                    if (F8 == false) { B8_p.Content = znak; gbot_vyber = true; F8 = true; B8_p.IsHitTestVisible = false; }
                                    break;
                                case 9:
                                    if (F9 == false) { B9_p.Content = znak; gbot_vyber = true; F9 = true; B9_p.IsHitTestVisible = false; }
                                    break;

                            }


                        } while (!gbot_vyber);

                    }








                    Kontrola();
                    player = 1;

                    

                



            }

        }

        private void Tlacitko_3(int l, int n)
        {
            

            
            if (l == 1 && n == 1 && F1 == false)
            {
                B1_p.Content = znak;
                F1 = true;
                B1_p.IsHitTestVisible = false;
            }
            else if (l == 1 && n == 2 && F2 == false)
            {
                F2 = true;
                B2_p.IsHitTestVisible = false;
            B2_p.Content = znak;
            }
            else if (l == 1 && n == 3 && F3 == false)
            {
                F3 = true;
                B3_p.IsHitTestVisible = false;
                B3_p.Content = znak;
            }
            else if (l == 2 && n == 1 && F4 == false)
            {
                F4 = true;
                B4_p.IsHitTestVisible = false;
                B4_p.Content = znak;
            }
            else if (l == 2 && n == 2 && F5== false)
            {
                F5 = true;
                B5_p.IsHitTestVisible = false;
                B5_p.Content = znak;
            }
            else if (l == 2 && n == 3 && F6== false)
            {
                F6 = true;
                B6_p.IsHitTestVisible = false;
                B6_p.Content = znak;
            }
            else if (l == 3 && n == 1 && F7 == false)
            {
                F7 = true;
                B7_p.IsHitTestVisible = false;
                B7_p.Content = znak;
            }
            else if (l == 3 && n == 2 && F8 == false)
            {
                F8 = true;
                B8_p.IsHitTestVisible = false;
                B8_p.Content = znak;
            }
            else if (l == 3 && n == 3 && F9 == false)
            {
                F9 = true;
                B9_p.IsHitTestVisible = false;
                B9_p.Content = znak;
            }


        }

        private void Change_ornament_Click(object sender, RoutedEventArgs e)
        {
            if (znak_oponent == "X")
            {
                znak_oponent = "O";
                znak = "X";
                znak_L_H.Content = znak_oponent;
                znak_L_O.Content = znak;
            }
            else
            {
                znak_oponent = "X";
                znak = "O";
                znak_L_H.Content = znak_oponent;
                znak_L_O.Content = znak;

            }
        }

        

    }
}
