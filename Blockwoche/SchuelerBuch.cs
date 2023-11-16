using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blockwoche
{
    public class SchuelerBuch
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Schueler")]
        public int SchuelerId { get; set; }
  
        [ForeignKey("Buch")]
        public int BuchId { get; set; }


        public virtual Schueler Schueler { get; set; }

        public virtual Buch Buch { get; set; }


    }  
}
