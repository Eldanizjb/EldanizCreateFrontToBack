using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Sosial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string icon { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
    }
}
