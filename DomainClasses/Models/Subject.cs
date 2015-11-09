using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DomainClasses.Enums;

namespace DomainClasses.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "گروه خبر وارد نشده است")]
        [DisplayName("گروه خبر")]
        public int ChapterId { get; set; }

        [Required(ErrorMessage = "نویسنده خبر وارد نشده است")]
        [DisplayName("نویسنده خبر")]
        public string Authors { get; set; }
        [Required(ErrorMessage = "تیتر خبر وارد نشده است")]
        [DisplayName("تیتر خبر")]
        public string SubjectLead { get; set; }

        [Required(ErrorMessage = "متن خبر وارد نشده است")]
        [DisplayName("متن خبر")]
        [AllowHtml]
        public string SubjectContent { get; set; }
        [Required(ErrorMessage = "عکس خبر وارد نشده است")]
        [DisplayName("عکس خبر")]
        public string SubjectImage { get; set; }
        [DisplayName("وضعیت خبر")]
        public SubjectStatus Status { get; set; }
        [DisplayName("تاریخ مطلب")]

        public DateTime SubjectDate { get; set; }
        public virtual Chapter Chapter { get; set; }
    }

}
