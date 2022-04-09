using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP2V3_3
{

    public class OrderEventArgs : EventArgs
    {
        public Product Product { get; set; }
    }
    internal class Order
    {
        public delegate void OrderHandlerEvent(object source, OrderEventArgs args);

        public event OrderHandlerEvent OrderProcesed;
        public void Process(Product product)
        {
            Console.WriteLine($"Product {product.Id} is processing");
            Thread.Sleep(5000);

            OnOrderProcessed(product);
        }

        public virtual void OnOrderProcessed(Product product)
        {
            if(OrderProcesed != null)
                OrderProcesed(this, new OrderEventArgs { Product = product});
        }
    }
}
