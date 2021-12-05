using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class GalleryImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string link1 { get; set; }
        [MaxLength(50)]
        public string link2 { get; set; }
        public DateTime CreateDate { get; set; }
       
        [ForeignKey("Gallery")]
        public int CalleryId { get; set; }
        public Callery Callery { get; set; }







    }
}
