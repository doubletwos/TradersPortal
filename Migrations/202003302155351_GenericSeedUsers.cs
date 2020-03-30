namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenericSeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65fe8661-9a9b-4ab7-96d6-9d4ea1427fca', N'adminuser@tradersportal.com', 0, N'ABfiNBhpdfhz95Ae9I3OGWKFXppEiYshGrbg591jv2vQfERg2weSF/0gRDO8D3wpDw==', N'53d297dc-5a89-4042-9851-0082dd5520b4', NULL, 0, 0, NULL, 1, 0, N'adminuser@tradersportal.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'be9e076d-1559-405a-9f64-f9fa0f639cdf', N'ordinaryuser@tradersportal.com', 0, N'AEo1Rk+nSqihu99PrCg+mK+GhN9S8HlYxfVkDhxJuN1UG8Qo0StmEN5iaiJFZMbfCg==', N'3a58566d-2b08-4aa6-b9d3-209865f7c42a', NULL, 0, 0, NULL, 1, 0, N'ordinaryuser@tradersportal.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'34200a8e-cfbc-4973-9a59-0e54791a999a', N'CanManageTraders')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4f0617bf-5368-4cb2-a780-688a0969b9d3', N'CanManageUsers')



INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65fe8661-9a9b-4ab7-96d6-9d4ea1427fca', N'34200a8e-cfbc-4973-9a59-0e54791a999a')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65fe8661-9a9b-4ab7-96d6-9d4ea1427fca', N'4f0617bf-5368-4cb2-a780-688a0969b9d3')

");
        }
        
        public override void Down()
        {
        }
    }
}
