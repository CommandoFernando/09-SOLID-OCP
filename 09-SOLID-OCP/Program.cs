using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SOLID_OCP
{
    public delegate bool PaymentMethod(double amount);

    class Program
    {
        static void Main(string[] args)
        {
            OrderOCP orderOCP = new OrderOCP(1, "Headphones", 35.99);

            Console.WriteLine("*** Open Close Principle ***");
            Console.WriteLine();
            Console.WriteLine("  Select Methos of Payment");
            Console.WriteLine("  1- Cash");
            Console.WriteLine("  2- Credit Card");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    orderOCP.ProcessOrder(CashPayment.processPayment);
                    break;
                case 2:
                    orderOCP.ProcessOrder(new VisaPayment().processPayment);
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted");
                    break;
            }

            Console.ReadLine();
        }
    }
}
