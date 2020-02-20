using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_First.Models
{
    public class Image
    {
        public string Id_SP { get; set; }

        [Key]
        public string Image_SP { get; set; }
    }
}
