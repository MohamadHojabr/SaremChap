using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Price
    {
        [Key]
        public int PriceId { get; set; }
        [Required]
        [DisplayName("محصول")]
        public int ProductId { get; set; }
        [Required]
        [DisplayName("نوع")]
        public string Neme { get; set; }
        [Required]
        [DisplayName("مقدار")]

        public int Quantity { get; set; }
        [Required]
        [DisplayName("قیمت")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Value { get; set; }
        public virtual Product Product { get; set; }
    }
}
