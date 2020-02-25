namespace gighub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres values(1,'Jazz')");
            Sql("insert into genres values(2,'Blues')");
            Sql("insert into genres values(3,'Rock')");
            Sql("insert into genres values(4,'Country')");
        }

        public override void Down()
        {
            Sql("delete from genres where id in (1,2,3,4)");
        }
    }
}
