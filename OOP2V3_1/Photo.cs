using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_1
{
    public class Photo
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Photo()
        {
            title = "Nature";
        }

        public static Photo Load(string url)
        {
            // TODO: Loading image from url
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Modified Photo has been saved!");
        }
    }
}
