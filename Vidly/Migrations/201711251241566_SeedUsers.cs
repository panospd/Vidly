namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2ea88d41-9a56-4d5c-8d1a-7b59d03b916f', N'admin@vidly.com', 0, N'ACv7Ce+Bfy7MiL+hCTeMu45aniqS2ZQoPHUSklOWV9NfKkZft8GTsUZHCumuTQsLNQ==', N'846624bb-2150-4a94-af9e-a27faf39207e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3d7ab131-646a-41e5-805e-6b0a80984900', N'guest@vidly.com', 0, N'APkp6WW3ojDq6pNOQhDmwr3qpnszMDpqnbb5Qr550AkeqQms7fZRoJSiHeLkrixg9w==', N'329e9737-9704-485c-80ad-32a3fd12f57f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'57f60620-da26-4094-b8ff-d14d0dcbd340', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2ea88d41-9a56-4d5c-8d1a-7b59d03b916f', N'57f60620-da26-4094-b8ff-d14d0dcbd340')

");
        }
        
        public override void Down()
        {
        }
    }
}
