using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }
        
        [MaxLength(50, ErrorMessage = "El campo {0} Debe contener hasta {1} caracteres")]
        [Required]
        public string Name { get; set; }
    }
}
