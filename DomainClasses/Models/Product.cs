using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DomainClasses.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [DisplayName("گروه محصول")]
        public int ProductCategoryId { get; set; }
        [Required]
        [DisplayName("نام محصول")]
        public string Name { get; set; }
        [Required]
        [DisplayName("تصویر محصول")]
        public string Imege { get; set; }
        [DisplayName("توضیحات")]
        [Required(ErrorMessage = "متن مطلب وارد نشده است")]
        [AllowHtml]
        public string Describtion { get; set; }
        public virtual ICollection<Price> Price { get; set; }
        public virtual Form Form { get; set; }

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
