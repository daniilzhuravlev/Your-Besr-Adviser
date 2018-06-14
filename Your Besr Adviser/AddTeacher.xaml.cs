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
    /// Логика взаимодействия для AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : Window
    {
        public Teachers newTeacher { get; set; }
        public AddTeacher(Teachers ts)
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


        
        private void Add(object sender, RoutedEventArgs e)
        {
            newTeacher.NameTeachers = NameTeacher.Text;
            newTeacher.ProfUchitelya = int.Parse(ProfUchitelya.Text);
            newTeacher.DostupnostUch = int.Parse(DostupnostUch.Text);
            DialogResult = true;
            

        }
    }
}
