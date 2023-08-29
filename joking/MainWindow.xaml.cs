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

namespace joking
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

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("أعرف بدون أن تجاوب هههههه");
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            double marginValue = RandomMargin();
            btnNo.Margin = new Thickness(marginValue, marginValue, 0, 0);
        }

        private void BtnDeny_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("أنا أعترف بدون أن تجاوب!");
        }

        private int RandomMargin()
        {
            Random random = new Random();
            return random.Next(0, 250);
        }
    }
}