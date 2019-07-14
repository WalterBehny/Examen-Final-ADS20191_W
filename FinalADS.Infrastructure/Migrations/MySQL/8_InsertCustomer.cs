using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(103)]
    public class InsertCustomer : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("8_InsertCustomer.sql");
        }

        public override void Down()
        {
        }
    }
}
