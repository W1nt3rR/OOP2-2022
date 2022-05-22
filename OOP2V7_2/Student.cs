using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V7_2
{
    public class Student : INotifyPropertyChanged
    {
        private int godinaStudija;
        private string ime, prezime, telefon;
        public string Ime 
        { 
            get
            {
                return ime;
            }
            set
            {
                ime = value;
                OnPropertyChanged();
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
                OnPropertyChanged();
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
                OnPropertyChanged();
            }
        }
        public int GodinaStudija 
        {
            get
            {
                return godinaStudija;
            } 
            set
            {
                godinaStudija = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //? proverava da li je null
        }
    }
}
