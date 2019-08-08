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

namespace Demo
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

        private void LionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lion");
        }

        private void PandaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panda");
        }

        private void MeerkatButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Meerkat");
        }

        private void GiraffeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Giraffe");
        }

        private void ElephantButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Elephant");
        }

        private void ZebraButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zebra");
        }
    }
}
