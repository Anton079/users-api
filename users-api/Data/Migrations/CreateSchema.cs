using FluentMigrator;

namespace users_api.Data.Migrations
{
    [Migration(29012025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("user")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("first_name").AsString(120).NotNullable()
                .WithColumn("last_name").AsString(120).NotNullable()
                .WithColumn("mail").AsString(120).NotNullable()
                .WithColumn("password").AsString(120).NotNullable()
                .WithColumn("phone").AsInt32().NotNullable();
        }
    }
}
