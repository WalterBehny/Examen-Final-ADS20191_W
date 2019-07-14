using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(100)]
    public class CreateCustomerTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("5_CreateCustomerTable.sql");
        }

        public override void Down()
        {
        }
    }
}
