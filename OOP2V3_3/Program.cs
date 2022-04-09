using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_3
{
    internal class Program
    {
        //porudzbina obradjuje ....
        //email + sms da je zavrsena
        static void Main(string[] args)
        {
            Product product = new Product 
            { 
                Id = 1,
                Description = "Najlepse zelje 100g" 
            };

            Order order = new Order(); //publisher
            MailService mail = new MailService(); //subscriber
            SMSService sms = new SMSService(); //subscriber

            order.OrderProcesed += mail.OnOrderProcessed;
            order.OrderProcesed += sms.OnOrderProcessed;

            order.Process(product);

            Console.ReadLine();  
        }
    }
}
