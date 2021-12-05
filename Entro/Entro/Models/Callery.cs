using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Callery
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public List<GalleryImage>GalleryImages { get; set; }



    }
}
