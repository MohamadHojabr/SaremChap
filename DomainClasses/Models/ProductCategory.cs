using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DomainClasses.Enums;

namespace DomainClasses.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }
        [Required]
        [DisplayName("نام گروه")]
        public string Name { get; set; }
        [Required]
        [DisplayName("تصویر")]
        public string Imege { get; set; }
        [DisplayName("توضیحات")]
        [Required(ErrorMessage = "متن مطلب وارد نشده است")]
        [AllowHtml]
        public string Describtion { get; set; }
        public ProductSuperCategory? SuperCategory { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }

}
