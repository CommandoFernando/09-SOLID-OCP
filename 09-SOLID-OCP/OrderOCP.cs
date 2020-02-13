using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SOLID_OCP
{
    class OrderOCP
    {
        private int id;
        private String item;
        private double amount;
        private bool paid;

        public OrderOCP(int id, String item, double amount)
        {
            this.id = id;
            this.item = item;
            this.amount = amount;
            paid = false;
        }

        public void ProcessOrder(PaymentMethod pm)
        {
            // 1- Get founds from payment method
            bool success = pm(amount);

            //2- If enough founds, mark order as paid
            paid = true;

        }
    }
}
