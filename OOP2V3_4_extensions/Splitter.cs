using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Danas ucimo mnogo novih oblasti iz C#, 5 -> Danas ucimo mnogo novih oblasti...
// Danas ucimo, 5 -> Danas ucimo
// Danas ucimo mnogo, -1 -> izbaciti gresku

namespace OOP2V3_4_extensions
{
    public static class Splitter
    {
        public static string Shorter(this string text, int numberOfWords)
        {
            if (numberOfWords <= 0)
                throw new Exception();

            var words = text.Split(' ');
            int count = words.Length;

            if (count <= 5)
                return text;

            // I resenje
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < numberOfWords; i++)
            //{
            //    sb.Append(words[i]);
            //    sb.Append(' ');
            //}

            //sb.Append("...");



            // II resenje
            return String.Join(" ", (words.Take(numberOfWords))) + "...";
        }
    }
}
