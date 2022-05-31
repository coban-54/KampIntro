using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    //Miras inheritance
    class TuzelMusteri:Musteri
    {

        public string CompanyName { get; set; }// Şirket adı  müşteri  ile  alakalı  değildir hatalı
        public string TaxNumber { get; set; }
        //Bir nesnede bir değeri kullanmak zorunda değilsem o nesneye
        //ait değilse hata yaparız
    }
}
