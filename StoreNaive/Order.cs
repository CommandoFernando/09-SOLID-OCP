using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNaive
{
    public class Order
    {
        private int id;
        private String item;
        private double amount;
        private bool paid;

        public Order(int id, String item, double amount)
        {
            this.id = id;
            this.item = item;
            this.amount = amount;
            paid = false;
        }

        public void ProcessOrder(int method)
        {
            // 1- Get founds from payment method
            switch (method)
            {
                case 1:
                    Console.WriteLine("Processing payment with Cash (Naive)");
                    break;
                case 2:
                    Console.WriteLine("Processing payment with Credit Card (Naive)");
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted (Naive)");
                    break;
            }

            //2- If enough founds, mark order as paid
            paid = true;

        }

    }
}
