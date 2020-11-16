using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} Debe contener hasta {1} caracteres")]
        [Required]
        public string Name { get; set; }

        //Esto es para los servicios y que no se mapee en la BD
        [JsonIgnore]
        [NotMapped]
        public int IdDepartment { get; set; }
    }

}
