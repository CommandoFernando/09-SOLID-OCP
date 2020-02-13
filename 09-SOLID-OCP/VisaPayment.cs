using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SOLID_OCP
{
    class VisaPayment : IPaymentMethod
    {
        public bool processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Credit Card Visa");
            // 1- Request connection
            // 2- Process payment transaction
            // 3- If transaction successfull 
            return true;
        }
    }
}
