namespace EnviosApiRest.Models.Domain
{
    public class Envio
    {
        public int Id { get; set; }
        public string Destinatario { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
    }
}
