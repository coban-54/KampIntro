using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class ApplicationManager
    {
        //Method  injection
        public void MakeApp(ICreditsManager creditsManager,ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            //
            //HousingLoanManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculete();//Kod konut kredisi üzerinden hesaplar
            //Yanlış
            creditsManager.Calculete();
            loggerService.Log();
        }
        
        //Kredileri listeleyip  hesaplama
        public void CreditInformation(List<ICreditsManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculete();
            }
        }
    }
}
