using System;

namespace FinalADS.Application.Clientes.Dtos
{
    public class NewClienteDto
    {

        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Contenido { get; set; }
        public string Formato { get; set; }
        public int Fechaenvio { get; set; }
        public int Fechaacept { get; set; }

        public int Fechapubli { get; set; }
        public int Account_id { get; set; }
        
        public NewClienteDto()
        {
            
        }
    }
}
