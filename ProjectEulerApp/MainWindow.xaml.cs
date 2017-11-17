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
using ProjectEulerApp.Problems;
using System.Collections;

namespace ProjectEulerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Problem_ComboBox.SelectedIndex = 0;
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            IProblem problem = (IProblem)this.DataContext;
            MyAnswer_TextBox.Text = problem.GetAnswer().ToString();

            if (MyAnswer_TextBox.Text != RequiredAnswer_TextBox.Text)
            {
                MyAnswer_TextBox.BorderBrush = Brushes.Red; // TODO: change back when correct!
            }
        }

        private void Problem_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Problem_ComboBox.SelectedIndex;
            this.DataContext = Problem_ComboBox.SelectedValue;
            Problem_ComboBox.SelectedIndex = index;
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            Problem_ComboBox.SelectedIndex += 1;
        }

        private void Previous_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Problem_ComboBox.SelectedIndex > 0)
            {
                Problem_ComboBox.SelectedIndex -= 1;
            }            
        }
    }
}
