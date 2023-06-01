using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoShop.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } //nazwa
        public decimal Price { get; set; } //cena
        public DateTime CreatedDate { get; set; } //data wystawienia produktu
        public DateTime ProductMadeDate { get; set; } //data wytworzenia produktu
        public DateTime ProductBestBeforeDate { get; set; } // data "najlepiej spozyc przed"  
        public bool GMO { get; set; }
        public bool Certification { get; set; }

    }
}
