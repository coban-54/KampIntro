using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int ,decimal,float,enum,boolean,value types=değer tip
            ////Değer tiplerde atama yapınca sadece atar bağlantı kalmaz
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;
            //// sayi1 = 20
            //Console.WriteLine("Sayi 1 :" + sayi1);

            ////Arrays,Class interface ...reference type
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            ////Stack     Heap adres  değerler
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            ////sayilar1[0] = 1000; çünkü Arayler referans tip
            ////sayilar1 in adresini sayilar2 olarak değiştirdik o sebepten
            ////Artık sayilar1 Arrayi sayilar2'nin adresini gösterir

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Hüseyin";
            person2 = person1;
            person1.FirstName = "Ahmet";

            //Console.WriteLine(person2.FirstName);//Ahmet
            //person1'in adresini atadığımız için artık person1 de ne yaparsak person2'yi etkiler

            Customer customer =new Customer();
            customer.FirstName = "Salih";
            customer.CreditsCardNumber = "123456";
            Person person3 = customer;
            customer.FirstName = "Ahmet";

            //Console.WriteLine(((Customer)person3).CreditsCardNumber);
            //Bu şekilde persondan customer özelliğine erişilir
            
            //Console.WriteLine(person3.FirstName);
            //salih çıktısını verir

            Employee employee = new Employee();
            employee.FirstName = "Veli";
            // custumer = employe yapılmaz farklı tipler
            PersonManager personManager = new PersonManager();
            // Fonksiyon çağırıldığında şuan veli verir çünkü person.Firstname direk employee.FirstName'i verir
            personManager.Add(employee);


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person//Person burda Baseclass 
    {
        public string CreditsCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void  Add(Person person)
        {
            //Person baseClass olduğu için dğerlerini fonksiyona bağlarız
            Console.WriteLine(person.FirstName);
        }
    }
}