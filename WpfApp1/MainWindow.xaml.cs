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
using System.Media;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Random r = new System.Random();
            for (int i = 0; i < 2; i++)
            {
                Random rm = new Random();
                int flag = rm.Next(1, 10);

                if (flag > 6) {
                    SystemSounds.Hand.Play();
                }
                else {
                    SystemSounds.Exclamation.Play(); 
                }
                
                MainWindow win = new MainWindow(); 
                win.Left = r.Next(0,800);
                win.Top = r.Next(0,600);
                win.Show();

            }
            
            this.Close();

        }
    }
}
