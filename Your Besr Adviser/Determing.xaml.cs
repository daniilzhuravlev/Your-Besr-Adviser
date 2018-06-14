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
using System.Windows.Shapes;
using YBA.Classes;
using Your_Besr_Adviser;

namespace Your_Besr_Adviser
{
    /// <summary>
    /// Логика взаимодействия для Determing.xaml
    /// </summary>
    public partial class Determing : Window
    {
        public double DostupnostUch { get; private set; }
        public double ProfUchitelya { get; private set; }
        public double Ekz { get; private set; }
        public double Nakop { get; private set; }

        public Determing()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            Hide();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {

            double RepUch = 0.7 * ProfUchitelya + 0.3 * DostupnostUch;
            double RepOcenok = 0.5 * Ekz + 0.5 * Nakop;
            double itog = 0.4 * RepUch + 0.6 * RepOcenok;
        }
    }
}
