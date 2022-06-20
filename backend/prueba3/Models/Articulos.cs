using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prueba3.Models
{
    public class Articulos
    {
        [Key]
        public int id { get; set; }
        public String cod { get; set; }
        public String nombre { get; set; }
        public String descp { get; set; }
        public int stock { get; set; }
    }
}
