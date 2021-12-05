using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Locations { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(50)]
        public string icon { get; set; }
        [MaxLength(250)]
        public string Reserved { get; set; }

    }
}
