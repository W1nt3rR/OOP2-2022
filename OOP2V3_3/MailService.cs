using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_3
{
    public class MailService
    {
        public void OnOrderProcessed(object source, OrderEventArgs args)
        {
            Console.WriteLine($"Sending mail to customer, product {args.Product.Description}");
        }
    }

    public class SMSService
    {
        public void OnOrderProcessed(object source, OrderEventArgs args)
        {
            Console.WriteLine($"Sending message to customer, product {args.Product.Description}");
        }
    }
}
