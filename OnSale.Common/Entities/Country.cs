using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
