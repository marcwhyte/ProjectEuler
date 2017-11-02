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
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            IProblem problem = (IProblem)this.DataContext;
            MyAnswer_TextBox.Text = problem.GetAnswer().ToString();
        }

        private void Problem_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = Problem_ComboBox.SelectedValue;
        }
    }
}
