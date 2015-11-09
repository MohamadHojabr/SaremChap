using DomainClasses.Enums;

namespace DomainClasses.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string TitleEn { get; set; }
        public string TitleFa { get; set; }
        public bool RequiredField { get; set; }
        public bool DisabledField { get; set; }
        public bool EffectivePrice { get; set; }
        public string Options { get; set; }
        public decimal? Finance { get; set; }
        public FieldType FieldType { get; set; }
        public virtual Form Form { get; set; }
        public int FormId { get; set; }


    }

}
