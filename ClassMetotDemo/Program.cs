using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1542;
            customer1.CustomerName = "Asya";
            customer1.CustomerSurname = "DEMİR";

            Customer customer2 = new Customer();
            customer2.Id = 5461;
            customer2.CustomerName = "Nesli";
            customer2.CustomerSurname = "YILMAZ";

            Customer customer3 = new Customer();
            customer3.Id = 2154;
            customer3.CustomerName = "Yağız";
            customer3.CustomerSurname = "ERDOĞAN";

            Customer customer4 = new Customer();
            customer4.Id = 6521;
            customer4.CustomerName = "Mihri";
            customer4.CustomerSurname = "AKINCI";

            Console.WriteLine("Müşteri Listesi-------------------------");
            Customer[] customer = new Customer[] {customer1,customer2,customer3 };
            foreach (Customer customerr in customer)
            {
                Console.WriteLine(customerr.Id+" / "+ customerr.CustomerName + "  " +customerr.CustomerSurname);
            }
            Console.WriteLine("----------------------------------------------------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.List(customer2);
            customerManager.Add(customer4);
            customerManager.Delete(customer1);


            

        }
    }
}
