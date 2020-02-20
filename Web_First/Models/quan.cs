using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_First.Models
{
    public class quan
    {
        public string Id_SP { get; set; }
        public string Loai_SP_1 { get; set; }
        public string Loai_SP_2 { get; set; }
        public string Name_SP { get; set; }
        public int Price_SP { get; set; }
        public string Mo_Ta { get; set; }
        [Key]
        public string Image_SP { get; set; }
        public DateTime ngay_add { get; set; }
        public int Sale { get; set; }
    }
}
