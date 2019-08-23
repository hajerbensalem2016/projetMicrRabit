using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Filiale
    {
        [Key]
        public int Filiale_ID { get; set; }
        [Required]
        public string Nom_Filiale { get; set; }
        public string Code_Filiale { get; set; }
        
    }
}
