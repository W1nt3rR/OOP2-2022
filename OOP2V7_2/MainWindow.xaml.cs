using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
//using System.Collections.ObjectModel;
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

namespace OOP2V7_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Student Student { get; set; }
        public DB baza;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //? proverava da li je null
        }

        public ObservableCollection<Student> ListaStudenata { get; set; }
        public MainWindow()
        {
            baza = new DB();
            //ListaStudenata = new ObservableCollection<Student>
            //{
            //    new Student { Ime = "Ramiz", Prezime = "Sabovic", Telefon = "065456654", GodinaStudija = 2 },
            //    new Student { Ime = "Elma", Prezime = "Mujovic", Telefon = "065156165", GodinaStudija = 2 },
            //    new Student { Ime = "Ramiz", Prezime = "Sabovic", Telefon = "065456654", GodinaStudija = 2 }
            //};

            Student = new Student
            {
                Ime = "",
                Prezime = "",
                Telefon = "",
                GodinaStudija = 1
            };

            ucitajStudente();
            InitializeComponent();
        }

        private void ucitajStudente()
        {
            DataTable dt = baza.Read();
            ListaStudenata = new ObservableCollection<Student>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Student temp = new Student()
                {
                    Ime = dt.Rows[i][0].ToString(),
                    Prezime = dt.Rows[i][1].ToString(),
                    Telefon = dt.Rows[i][2].ToString(),
                    GodinaStudija = int.Parse( dt.Rows[i][3].ToString() ),
                };
                ListaStudenata.Add(temp);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Student.GodinaStudija = 
            //    (Student.GodinaStudija) < 4 
            //    ? Student.GodinaStudija + 1 
            //    : Student.GodinaStudija;
            if (!string.IsNullOrEmpty(Student.Ime) && !string.IsNullOrEmpty(Student.Prezime) && !string.IsNullOrEmpty(Student.Telefon))
            {
                var result = baza.Create(Student);
                if(result == true)
                {
                    ListaStudenata.Add(new Student { Ime = Student.Ime, Prezime = Student.Prezime, Telefon = Student.Telefon, GodinaStudija = Student.GodinaStudija });
                    Student.Ime = "";
                    Student.Prezime = "";
                    Student.Telefon = "";
                    Student.GodinaStudija = 1;
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom dodavanja u bazu");
                }
                
            }

        }
    }
}
