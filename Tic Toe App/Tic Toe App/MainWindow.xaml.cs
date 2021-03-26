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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Toe_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int turn,round,pl1_pt,pl2_pt;
        public MainWindow()
        {
            InitializeComponent();
            turn = 1;
        }        
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(turn==1)
            {
                btn.Content = "X";
                p_turn.Content= "Player Turn: 2 (0)";
                turn = 2;
            }
            else if(turn==2)
            {
                btn.Content = "O";
                p_turn.Content = "Player Turn: 1 (O)";
                turn = 1;
            }
            round += 1;
            btn.IsEnabled = false;
            win(btn.Content.ToString());            
        }
        private void win(string btnContent)
        {
            if ((Button1.Content as string == btnContent & Button2.Content as string == btnContent & Button3.Content as string == btnContent)
               | (Button4.Content as string == btnContent & Button5.Content as string == btnContent & Button6.Content as string == btnContent)
               | (Button7.Content as string == btnContent & Button8.Content as string == btnContent & Button9.Content as string == btnContent)
               | (Button1.Content as string == btnContent & Button4.Content as string == btnContent & Button7.Content as string == btnContent)
               | (Button2.Content as string == btnContent & Button5.Content as string == btnContent & Button8.Content as string == btnContent)
               | (Button3.Content as string == btnContent & Button6.Content as string == btnContent & Button9.Content as string == btnContent)
               | (Button1.Content as string == btnContent & Button5.Content as string == btnContent & Button9.Content as string == btnContent)
               | (Button3.Content as string == btnContent & Button5.Content as string == btnContent & Button7.Content as string == btnContent))
            {
                if (btnContent == "X")
                {
                    disableButtons();
                    MessageBox.Show("Player 1 Wins");
                    Player1_lb.Content = "Player1(X)\n  " + (++pl1_pt);
                }
                else if (btnContent == "O")
                {
                    disableButtons();
                    MessageBox.Show("Player 2 Wins");
                    Player2_lb.Content = "Player2(O)\n   " + (++pl2_pt);
                }
                if (turn == 1)
                    turn = 2;
                else
                    turn = 1;
                Reset_All();
            }
            else if(round==9)
            {
                MessageBox.Show("Draw");
                Reset_All();
            }
        }
        private void disableButtons()
         {
            foreach(Button btn in WrapPanel1.Children)
            {
                btn.IsEnabled = false;
            }
         }
        
        private void Reset_All()
        {
            foreach (Button btn in WrapPanel1.Children)
            {                
                round = 0;
                p_turn.Content = "Player Turn: "+turn;
                btn.Content = "";
                btn.IsEnabled = true;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Reset_All();
        }
    }
}


