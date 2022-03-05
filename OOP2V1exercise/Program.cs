using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V1exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOverflowPost post1 = new StackOverflowPost();
            post1.Upvote();
            Console.WriteLine(post1.ToString());
            post1.Upvote();
            Console.WriteLine(post1.ToString());
            post1.Downvote();
            post1.Downvote();
            Console.WriteLine(post1.ToString());

            Console.ReadLine();
        }
    }
}
