using System.ComponentModel.DataAnnotations;

namespace EnviosApiRest.Models.Dto
{
    public class EnvioCreateDto
    {
        [Required]
        public string Destinatario { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Estado { get; set; }
    }
}
