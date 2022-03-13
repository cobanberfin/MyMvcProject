using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class About
    {
        [Key]
        public int AboutID { get; set; }   
        [StringLength(1000)]
        public string AboutDetails { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }//dosyayoluıle ımageoluşturdm
        [StringLength(500)]
        public string AboutImage2 { get; set; }
    }
}
