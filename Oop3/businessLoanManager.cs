using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class businessLoanManager : ICreditsManager
    {
        public void Calculete()
        {
            Console.WriteLine("Esnaf kredisi  hesaplandı");
        }

        public void SomeTing()
        {
            throw new NotImplementedException();
        }
    }
}
