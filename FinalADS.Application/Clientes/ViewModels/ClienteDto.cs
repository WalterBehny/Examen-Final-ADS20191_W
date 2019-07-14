namespace FinalADS.Application.Clientes.ViewModels
{
    public class ClienteDto
    {
        public long id { get; set; }
        public string titulo { get; set; }
        public string resumen { get; set; }
        public string contenido { get; set; }
        public string formato { get; set; }
        public int fechaenvio { get; set; }
        public int fechaacept { get; set; }
        public int fechapubli { get; set; }

        public int Account_id { get; set; }

        public ClienteDto()
        {
        }
    }
}
