using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp7.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    IdAccount = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.IdAccount);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    IdGood = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Sale = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.IdGood);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoodIdGood = table.Column<int>(type: "int", nullable: false),
                    AccountIdAccount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_AccountIdAccount",
                        column: x => x.AccountIdAccount,
                        principalTable: "Accounts",
                        principalColumn: "IdAccount",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Goods_GoodIdGood",
                        column: x => x.GoodIdGood,
                        principalTable: "Goods",
                        principalColumn: "IdGood",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AccountIdAccount",
                table: "Orders",
                column: "AccountIdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GoodIdGood",
                table: "Orders",
                column: "GoodIdGood");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
