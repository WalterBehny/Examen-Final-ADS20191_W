using FinalADS.Domain.Clientes.Constants;
using Common;

namespace FinalADS.Domain.Clientes.Entities
{
    public class Cliente : Entity
    {   
        public virtual string Titulo { get; set; }
        public virtual string Resumen { get; set; }
        public virtual string Contenido { get; set; }
        public virtual string Formato { get; set; }
        public virtual int Fechaenvio { get; set; }
        public virtual int Fechaacept { get; set; }
        public virtual int Fechapubli { get; set; }

        public virtual int Account_id { get; set; }
        
        public Cliente()
        {
        }
       
    }
}
