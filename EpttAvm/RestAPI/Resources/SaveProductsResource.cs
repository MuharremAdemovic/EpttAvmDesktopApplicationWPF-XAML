using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace RestAPI.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        public short QuantityInPackage { get; set; }
        [Required]
        public string UrunResmi { get; set; }
        [Required]
        public float Fiyat { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        [MaxLength(350)]
        public string Aciklama { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
