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

namespace Your_Besr_Adviser
{
    /// <summary>
    /// Логика взаимодействия для AddObject.xaml
    /// </summary>
    public partial class AddObject : Window
    {
        public Subjects newSubject { get; set; }
        public AddObject( Subjects SS)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            Hide();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddS(object sender, RoutedEventArgs e)
        {
            newSubject.NameSubject = NameObject.Text;
            newSubject.Nakop = int.Parse(Nakop.Text);
            newSubject.Ekz = int.Parse(Ekz.Text);

        }
        
    }
}
