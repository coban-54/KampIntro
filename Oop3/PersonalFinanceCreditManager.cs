using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class PersonalFinanceCreditManager : ICreditsManager
    {
        public void Calculete()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void SomeTing()
        {
            throw new NotImplementedException();
        }
    }
}
