using System;

namespace Constructor
    //Constructor sınıfı ilk kez newleyince çalışan block
{
    class Program
    {
        private const string V = "sdasa";

        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //2.Tanımlama
            Customer customer1 = new Customer {Id=1,CustomerName="Hüseyin",CustomerLastName="Çoban",City="Sakarya"};
            //3.Tanımlama
            Customer customer2 = new Customer(2, "Ahmet", "dfsd", V);
            
        }
   
    }
    class Customer
    {
        public Customer() //default Constructor
        {
            Console.WriteLine("Yapıcı block çalıştı");
        }
        public Customer(int ıd, string customerName, string customerLastName, string city)
        {
            //3.Tanımın ctor'u overloadig
            Id = ıd;
            CustomerName = customerName;
            CustomerLastName = customerLastName;
            City = city;
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string City { get; set; }

    }
}