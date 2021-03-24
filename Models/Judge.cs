using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxingThemis.Models
{
    public class Judge
    {
        [Key]
        public int Id { get; set; }
        public string Full_Name { get; set; }
    }
}
