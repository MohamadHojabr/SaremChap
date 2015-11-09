using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("نام")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("نام خانوادگی")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [DisplayName("آدرس")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("کد پستی")]
        [StringLength(10)]
        public string PostalCode { get; set; }


        [DisplayName("تلفن")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [DisplayName("موبایل")]
        [StringLength(24)]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [DisplayName("ایمیل")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        public int SubmitFormId { get; set; }
        public List<Value> Value { get; set; }

    }
}
