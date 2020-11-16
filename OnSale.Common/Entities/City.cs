using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} Debe contener hasta {1} caracteres")]
        [Required]
        public string Name { get; set; }
    }

}
