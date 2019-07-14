using FinalADS.Domain.Clientes.Entities;
using FluentNHibernate.Mapping;

namespace FinalADS.Infrastructure.Clientes.Persistence.NHibernate.Mapping
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("articulo");
            Id(x => x.Id).Column("cliente_id").GeneratedBy.Identity();
            Map(x => x.Titulo).Length(150).Column("titulo");
            Map(x => x.Resumen).Length(150).Column("resumen");
            Map(x => x.Contenido).Length(150).Column("contenido");
            Map(x => x.Formato).Length(4).Column("formato");
            Map(x => x.Fechaenvio).Column("fechaenvio");
            Map(x => x.Fechaacept).Column("fechaacept");
            Map(x => x.Fechapubli).Column("fechapubli");
            Map(x => x.Account_id).Column("account_id").Not.Nullable();
            //Map(x => x.CreatedAt).Column("created_at_utc");
            //Map(x => x.UpdatedAt).Column("updated_at_utc");
            //References(x => x.Customer, "customer_id");
        }
    }
}
