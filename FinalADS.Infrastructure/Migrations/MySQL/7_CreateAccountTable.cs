using FluentMigrator;

namespace FinalADS.Infrastructure.Migrations.MySQL
{
    [Migration(101)]
    public class CreateAccountTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("7_CreateAccountTable.sql");
        }

        public override void Down()
        {
        }
    }
}
