namespace VHStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3c201702-55a4-4e45-90ef-63837ade30a1', N'quest@vhstore.com', 0, N'AJZFDoRs+PWA//5sYpxvTSZMSd1k5jpi/eYemUKs5aOc73wDV33q1HtSCK7yhkv84Q==', N'fafcab5f-c15a-45e5-b779-53893dca2007', NULL, 0, 0, NULL, 1, 0, N'quest@vhstore.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41b1b3bb-779b-4b18-901b-ec111aa48264', N'admin@vhstore.com', 0, N'AEazJDNngzq9e/Jn5fGQKlGkkWeBBVxYvFOmAG/dX5W2aFuVLPlPC+OHND1OkGnMHw==', N'0b75f784-f483-4c2f-abb3-8ea106d2ea86', NULL, 0, 0, NULL, 1, 0, N'admin@vhstore.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'17aff514-a462-405b-b79d-6f91bb954c82', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'41b1b3bb-779b-4b18-901b-ec111aa48264', N'17aff514-a462-405b-b79d-6f91bb954c82')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
