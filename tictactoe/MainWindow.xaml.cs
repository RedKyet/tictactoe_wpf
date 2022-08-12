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

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private short turns = 1;
        int[,] matrix = new int[3,3] { { 0, 0 , 0}, { 0, 0 , 0}, { 0, 0 , 0} };

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void button_clicked(object sender)
        {
            if(((Button)sender).Content == null)
            {
                int i = Grid.GetRow((Button)sender);
                int j = Grid.GetColumn((Button)sender);
                if (turns%2==1)
                {
                    ((Button)sender).Content = "X";
                    matrix[i , j] = 2;
                    if(checkwin(i, j))
                    {
                        MessageBox.Show("X won");
                        NewGame();
                        return;
                    }
                }
                else
                {
                    ((Button)sender).Content = "0";
                    matrix[i , j] = 1;
                    if (checkwin(i, j))
                    {
                        MessageBox.Show("0 won");
                        NewGame();
                        return;
                    }
                }
                if (turns == 9)
                {
                    MessageBox.Show("Draw");
                    NewGame();
                    return;
                }
                turns++;
            }
        }
        private void NewGame()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = 0;
            ClearButtons();
            turns = 1;
        }
        private bool checkwin(int i, int j)
        {
            if ((matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2]) || (matrix[0, j] == matrix[1, j] && matrix[1, j] == matrix[2, j]))
                return true;
            else if (i - j != 1 && j - i != 1 && matrix[1, 1] != 0 && (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2] || matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0]))
                return true;
            return false;
        }

        private void ClearButtons()
        {
            left_top.Content = null;
            center_top.Content = null;
            right_top.Content = null;
            left_center.Content = null;
            center_center.Content = null;
            right_center.Content = null;
            left_buttom.Content = null;
            center_buttom.Content = null;
            right_buttom.Content = null;
        }
        private void left_top_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void center_top_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void right_top_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void left_center_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void center_center_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void right_center_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void left_buttom_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void center_buttom_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

        private void right_buttom_Click(object sender, RoutedEventArgs e)
        {
            button_clicked(sender);
        }

    }
}
