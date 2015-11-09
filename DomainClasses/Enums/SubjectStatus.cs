using System.ComponentModel.DataAnnotations;

namespace DomainClasses.Enums
{
    public enum SubjectStatus
    {
        [Display(Name = @"بخش اسلایدشو")]
        Slideshow = 1,

        [Display(Name = @"بخش محصول ویژه")]

        Special = 2,

        [Display(Name = @"بخش محصولات")]

        Products = 3,

        [Display(Name = @" منوی اصلی")]

        MainMenu = 4,

        [Display(Name = @"غیر فعال")]

        Disable = 5,


    }
}
