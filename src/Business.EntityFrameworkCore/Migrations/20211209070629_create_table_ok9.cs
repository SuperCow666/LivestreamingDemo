using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class create_table_ok9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb _RoleModel");

            migrationBuilder.DropTable(
                name: "tb _UserModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderForm",
                table: "OrderForm");

            migrationBuilder.RenameTable(
                name: "OrderForm",
                newName: "tb _OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb _OrderForm",
                table: "tb _OrderForm",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb _MyUserModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSex = table.Column<int>(type: "int", nullable: false),
                    UserAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserHeadPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb _MyUserModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb _PartModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb _PartModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb _MyUserModel");

            migrationBuilder.DropTable(
                name: "tb _PartModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb _OrderForm",
                table: "tb _OrderForm");

            migrationBuilder.RenameTable(
                name: "tb _OrderForm",
                newName: "OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderForm",
                table: "OrderForm",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb _RoleModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb _RoleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb _UserModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserHeadPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb _UserModel", x => x.Id);
                });
        }
    }
}
