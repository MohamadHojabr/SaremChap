using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        [Required]
        [DisplayName("نام گالری")]
        public string Name { get; set; }

        [DisplayName("توضیحات")]
        public string Describtion { get; set; }

        public virtual ICollection<GalleryItem> GalleryItem { get; set; }

    }
}
