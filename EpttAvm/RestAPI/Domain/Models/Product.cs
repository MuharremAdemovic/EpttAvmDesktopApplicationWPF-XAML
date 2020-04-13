using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Fiyat { get; set; }
        public string Marka { get; set; }
        public string Aciklama { get; set; }
        public short QuantityInPackage { get; set; }
        public string UrunResmi { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
