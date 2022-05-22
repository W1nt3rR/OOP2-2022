using Microsoft.Win32;
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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for Glavna.xaml
    /// </summary>
    public partial class Glavna : Window
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.ShowDialog();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Tekstualne datoteke (*.txt)|*.txt";
                of.ShowDialog();
                var putanjaDoFajla = of.FileName;
                MainWindow window = new MainWindow(putanjaDoFajla, 'O');
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Tekstualne datoteke (*.txt)|*.txt";
                sf.ShowDialog();
                var putanjaDoFajla = sf.FileName;
                MainWindow window = new MainWindow(putanjaDoFajla, 'S');
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
