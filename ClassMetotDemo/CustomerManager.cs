using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void List(Customer customer)  
        {
            Console.WriteLine("Listelenen Müşteri: " + customer.Id+" "+customer.CustomerName+" "+customer.CustomerSurname);
        }

        public void Add(Customer customer) 
        {
            Console.WriteLine("Eklenen Müşteri: " + customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silinen Müşteri: " + customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname);
        }
    }
}
