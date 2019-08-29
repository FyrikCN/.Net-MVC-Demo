namespace FidlyAdvanced2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyAndPopulateValues : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Comedy')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Family')");
            Sql("UPDATE Movies SET ReleaseDate = '2019-08-28', AddedDate = '2019-08-29', " +
                "NumberInStock = 2, GenreTypeId = 1 WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '2019-07-16', AddedDate = '2019-08-13', " +
                "NumberInStock = 3, GenreTypeId = 2 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
