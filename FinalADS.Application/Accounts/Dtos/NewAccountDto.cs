using System;

namespace FinalADS.Application.Accounts.Dtos
{
    public class NewAccountDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Institucion { get; set; }
        public int Nroarticulos { get; set; }

        public NewAccountDto()
        {
            
        }
    }
}
