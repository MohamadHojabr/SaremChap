using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class GalleryItem
    {
        [Key]
        public int GalleryItemId { get; set; }
        public int GalleryId { get; set; }
        [Required]
        [DisplayName("نام ")]

        public string Name { get; set; }
        [DisplayName("توضیحات")]
        public string Describtion { get; set; }
        [Required]
        [DisplayName("تصویر")]

        public string Url { get; set; }
        public virtual Gallery Gallery { get; set; }

    }
}
