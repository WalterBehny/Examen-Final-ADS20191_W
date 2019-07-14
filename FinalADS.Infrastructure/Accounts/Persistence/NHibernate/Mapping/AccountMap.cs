using FinalADS.Domain.Accounts.Entities;
using FluentNHibernate.Mapping;

namespace FinalADS.Infrastructure.Accounts.Persistence.NHibernate.Mapping
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {     Table("autor");
           
            Id(x => x.Id).Column("autor_id");
            Map(x => x.Nombres).Length(50).Column("nombres");
            Map(x => x.Apellidos).Length(50).Column("apellidos");
            Map(x => x.Institucion).Length(50).Column("institucion");
            Map(x => x.Nroarticulos).Column("nroarticulos");
           // Map(x => x.CreatedAt).Column("created_at_utc");
          //  Map(x => x.UpdatedAt).Column("updated_at_utc");
            //References(x => x.Customer, "customer_id");
        }
    }
}
