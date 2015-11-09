using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Models
{
    public class Value
    {

        public int Id { get; set; }

        public string Val { get; set; }

        public DateTime Date { get; set; }

        public int SubmitId { get; set; }


        public virtual Field Field { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }



        public virtual Form Form { get; set; }
        [ForeignKey("Form")]
        public int FormId { get; set; }

    }
}
