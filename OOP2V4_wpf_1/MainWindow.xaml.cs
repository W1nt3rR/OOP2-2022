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

namespace OOP2V4_wpf_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _cols = 1;
        private int _rows = 1;
        private Button[,] dugmici;

        public int Rows
        {
            get { return _rows; }
            set 
            { 
                _rows = value;
                PodesiDugmice();
            }

        }
        public int Cols
        {
            get { return _cols; }
            set
            { 
                _cols = value;
                PodesiDugmice();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            dugmici = new Button[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    dugmici[i, j] = new Button();
                    podloga.Children.Add(dugmici[i, j]);
                    dugmici[i, j].Click += KlikDogadjaj;
                }
            _rows = 8;
            Cols = 8;
        }

        private void KlikDogadjaj(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            //Button currentButton = sender as Button; // ne javlja gresku
            Button currentButton = (Button)sender;
            
            MessageBox.Show($"Kliknuli ste na polje {currentButton.Content}");
        }

        private void PodesiDugmice()
        {
            float sirina = 420 / _cols;
            float visina = 420 / _rows;
            for(int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                {
                    if(i < _rows && j < _cols)
                    {
                        // PODESI DUGME
                        //dugmici[i, j].Width = sirina;
                        //dugmici[i, j].Height = visina;

                        if((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                            dugmici[i, j].Background = Brushes.Gray;
                        else
                            dugmici[i, j].Background = Brushes.Red;

                        dugmici[i, j].Content = $"{(char)(72-i)}{j+1}";
                        Grid.SetRow(dugmici[i, j], i);
                        Grid.SetColumn(dugmici[i, j], j);

                        //dugmici[i, j].Visibility = Visibility.Visible;
                        //Canvas.SetLeft(dugmici[i, j], sirina * j);
                        //Canvas.SetTop(dugmici[i, j], visina * i);
                    }
                    else
                    {
                        // SAKRIJ
                        dugmici[i, j].Visibility = Visibility.Hidden;
                    }
                }
        }
    }
}
