using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATPapp.Models
{
    [Table("tblAgenti")]
    public class Agenti
    {
        [Key]
        public int AgentiId { get; set; }
        public string NomeAgente { get; set; }
        public string SiglaAgente { get; set; }

        public virtual ICollection<Clienti> Clienti { get; set; }
    }
}