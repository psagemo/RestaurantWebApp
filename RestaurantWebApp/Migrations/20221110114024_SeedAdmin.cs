using Microsoft.EntityFrameworkCore.Migrations;
using RestaurantWebApp.Areas.Identity.Data;

#nullable disable

namespace RestaurantWebApp.Migrations
{
    public partial class SeedAdmin : Migration
    {
        private string AdminRoleId = Guid.NewGuid().ToString();

        private string AdminUserId = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesSQL(migrationBuilder);

            SeedAdminUser(migrationBuilder);

            SeedAdminRole(migrationBuilder);
        }

        private void SeedRolesSQL(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{AdminRoleId}', 'Admin', 'ADMIN', null);");
            
        }

        private void SeedAdminUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], 
[Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], 
[PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
VALUES 
(N'{AdminUserId}', N'Admin', N'Admin', N'Admin2@test.com', N'ADMIN2@TEST.COM', 
N'Admin2@test.com', N'ADMIN2@TEST.COM', 0, 
N'AQAAAAEAACcQAAAAEOM53F1qxoKA08yiyT7+JTwtNSCkkzTX2sJU5uKo3nITO40ycLjBUdSiZeDBST7tHw==', 
N'YUPAFWNGZI2UC5FOITC7PX5J7XZTAZAA', N'8e150555-a20d-4610-93ff-49c5af44f749', NULL, 0, 0, NULL, 1, 0)");

        }

        private void SeedAdminRole(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"
        INSERT INTO [dbo].[AspNetUserRoles]
           ([UserId]
           ,[RoleId])
        VALUES
           ('{AdminUserId}', '{AdminRoleId}');");     

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
