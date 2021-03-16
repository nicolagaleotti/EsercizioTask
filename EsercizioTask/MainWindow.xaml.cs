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

namespace EsercizioTask
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

        private void bntEsegui_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtA.Text);
            Task.Run(() => Multipli(a));
        }

        private void Multipli(int a)
        {
            int d = 200000000;
            for (int i = 0; i <= d; i++)
            {
                if ((i % a) == 0)
                {
                    lblMultipli.Content = $"{i / a}/{d}";
                }
                ProgressBar.Value = i / d;
            }
        }
    }
}
