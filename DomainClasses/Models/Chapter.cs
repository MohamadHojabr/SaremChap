using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
        [Required(ErrorMessage = "گروه خبر وارد نشده است")]
        [DisplayName("گروه خبر")]
        public string Name { get; set; }
        public ICollection<Subject> Subject { get; set; }
    }
}
