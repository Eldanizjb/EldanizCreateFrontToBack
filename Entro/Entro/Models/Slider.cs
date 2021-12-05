using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string UpTitle { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        [MaxLength(250)]
        public string Image{ get; set; }
        [MaxLength(50)]
        public string Name { get; set; }



    }
}
