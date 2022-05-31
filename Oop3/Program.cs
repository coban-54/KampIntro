using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface  aynı baseClass gibi referans tutabilir.
            //Şubede ki  arkadaşın  ekranı
            ICreditsManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculete();

            ICreditsManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculete();

            ICreditsManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculete();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLogerServise = new FileLoggerService();



            //başvuru yapacak
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApp(housingLoanManager, databaseloggerService);
            //Başvuru yap konut kredisine  göre ve veri tabanına yapacak şekilde

            applicationManager.MakeApp(new businessLoanManager, new SmsLoggerService());
            //Yeni bir esnaf kredisi oluşturup yeni sms  yollama logg'ı tanımladım
           

            //applicationManager.MakeApp(personalFinanceCreditManager);
            //Başvuru manager bütün  hesaplamalara bağlıdır çağırabilir.

            List<ICreditsManager> credits = new List<ICreditsManager>() {personalFinanceCreditManager,transportCreditManager};

            //applicationManager.CreditInformation(credits);
        }
    }
}
