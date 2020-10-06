using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ATPapp.Models
{
    [Table("tblClienti")]
    public class Clienti
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClientiId { get; set; }
        public string RagioneSociale { get; set; }
        public int? AgentiId { get; set; }

        [ForeignKey("AgentiId")]
        public Agenti Agente { get; set; }
    }
}