namespace FidlyAdvanced2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'04ed70dd-25dc-47e1-8fae-502e62fde20b', N'fyrik@fidly.com', 0, N'AOckCqMGycjXgVXK51JUrV6J+ZmXqFVPDBogAJTznFNO5T0jz2XTu7kkOwhNPviRmg==', N'e608a6f6-6ead-431b-8c77-caaaf44ea89e', NULL, 0, 0, NULL, 1, 0, N'fyrik@fidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1430c688-56e4-4d22-9ee9-b160b4bf5802', N'admin@fidly.com', 0, N'AFOeuhb+G3WRx9QfvImCU3xUYbrghTaEK48zhwMEFiTNIgZYu1HyySwVjTTOyagE5g==', N'0f996328-02cf-4de5-807a-a43ef972d5fc', NULL, 0, 0, NULL, 1, 0, N'admin@fidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dd1b9de0-eda3-42a7-ad93-0dc593abaa2d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1430c688-56e4-4d22-9ee9-b160b4bf5802', N'dd1b9de0-eda3-42a7-ad93-0dc593abaa2d')
");
        }
        
        public override void Down()
        {
        }
    }
}
