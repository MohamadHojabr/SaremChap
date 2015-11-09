using System.ComponentModel.DataAnnotations;

namespace DomainClasses.Enums
{
    public enum ProductSuperCategory
    {
        [Display(Name = @"چاپ روی انواع کاشی")]
        TilePrint = 1,

        [Display(Name = @"چاپ روی انواع ظروف")]

        DishPrint = 2,

        [Display(Name = @"چاپ روی انواع لباس")]

        ClothesPrint = 3,

        [Display(Name = @"چاپ روی دیگر سطوح")]

        OtherPrint = 4

    }
}
