using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Putanja { get; set; }
        //public string Title { get; set; }

        private bool promene;

        public bool Promene
        {
            get { return promene; }
            set 
            { 
                promene = value;
                this.Title = this.Title.Replace("*", "");
                this.Title += (promene == true) ? "*" : "";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string putanja, char mode)
        {
            InitializeComponent();
            Putanja = putanja;
            this.Title = putanja;
            Promene = false;
            if (mode == 'O')
                otvori();
            else
                sacuvaj();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            if (promene)
            {
                if (MessageBox.Show("Sadrzaj je promenjen, da li ste sigurni da hocete da otvorite novi dokument", "Potvrda", MessageBoxButton.YesNo) == MessageBoxResult.No)
                {
                    sacuvaj();
                }
            }
            txtSadrzaj.Text = string.Empty;
            Promene = false;
        }

        private void sacuvaj()
        {
            var sadrzaj = txtSadrzaj.Text;
            if(string.IsNullOrEmpty(this.Putanja))
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Tekstualne datoteke (*.txt)|*.txt";
                sf.ShowDialog();
                this.Putanja = sf.FileName;
                this.Title = this.Putanja;
            }

            try
            {
                File.WriteAllText(this.Putanja, sadrzaj);
                Promene = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void otvori()
        {
            if (string.IsNullOrEmpty(this.Putanja))
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Tekstualne datoteke (*.txt)|*.txt";
                of.ShowDialog();
                this.Putanja = of.FileName;
                this.Title = this.Putanja;
            }
            var sadrzaj = File.ReadAllText(this.Putanja);
            txtSadrzaj.Text = sadrzaj;
            Promene = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            sacuvaj();

        }

        private void cut_Click(object sender, RoutedEventArgs e)
        {
            string sadrzaj = txtSadrzaj.SelectedText;
            int index = txtSadrzaj.CaretIndex;
            txtSadrzaj.Text = txtSadrzaj.Text.Remove(index, sadrzaj.Length);
            txtSadrzaj.CaretIndex = index;
            postaviUClipboard(sadrzaj);
        }

        private void postaviUClipboard(string tekst)
        {
            Clipboard.SetText(tekst);
        }

        private string uzmiIzClipboard()
        {
            return Clipboard.GetText();
        }

        private void copy_Click(object sender, RoutedEventArgs e)
        {
            string sadrzaj = txtSadrzaj.SelectedText;
            if(!string.IsNullOrEmpty(sadrzaj))
            {
                postaviUClipboard(sadrzaj);
            }
        }

        private void paste_Click(object sender, RoutedEventArgs e)
        {
            string sadrzaj = uzmiIzClipboard();
            int index = txtSadrzaj.CaretIndex;
            txtSadrzaj.Text = txtSadrzaj.Text.Insert(index, sadrzaj);
            txtSadrzaj.CaretIndex = index + sadrzaj.Length;
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            helpText.Visibility = Visibility.Visible;
        }

        private void txtSadrzaj_TextChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
