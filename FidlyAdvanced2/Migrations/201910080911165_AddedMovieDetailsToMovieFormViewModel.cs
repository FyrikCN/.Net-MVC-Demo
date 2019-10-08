namespace FidlyAdvanced2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieDetailsToMovieFormViewModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            AddColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Byte());
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "GenreType_Id");
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
    }
}
