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

namespace OOP2P1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> studenti;
        public MainWindow()
        {
            InitializeComponent();
            
            studenti = new List<Student>();
           // listBox.ItemsSource = studenti;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window forma1 = new Window();
            forma1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.Ime = tbIme.Text;
            student.Prezime = tbPrezime.Text;
            student.BrojIndeksa = tbIndex.Text;
            student.Prosek = double.Parse(tbProsek.Text);

            studenti.Sort((x, y) => -x.Prosek.CompareTo(y.Prosek));
            studenti.Add(student);

            //listBox.ItemsSource = studenti;
            //foreach(var st in studenti)
                listBox.Items.Add(student.ToString());

            tbIme.Text = tbPrezime.Text = tbProsek.Text = tbIndex.Text = "";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
