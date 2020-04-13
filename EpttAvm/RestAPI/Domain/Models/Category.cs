using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UstKategoriId { get; set; }
        //public int AltKategoriId { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
