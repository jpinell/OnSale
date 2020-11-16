using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnSale.Common.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} Debe contener hasta {1} caracteres")]
        [Required]
        public string Name { get; set; }

        //Esto es para relacionar Un departamentos con muchas ciudades
        public ICollection<City> Cities { get; set; }

        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        //Esto es para los servicios y que no se mapee en la BD
        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }
    }

}
