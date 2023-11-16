﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blockwoche
{
    public class Buch
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }

        public virtual ICollection<Lehrer> Lehrer { get; set; }


    }
}
