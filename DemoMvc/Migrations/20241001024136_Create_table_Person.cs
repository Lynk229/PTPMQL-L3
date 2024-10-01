using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "Thisinh");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    CCCD = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoTen = table.Column<string>(type: "TEXT", nullable: true),
                    QueQuan = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.CCCD);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    EmployeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Diachi = table.Column<string>(type: "TEXT", nullable: true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.EmployeID);
                });

            migrationBuilder.CreateTable(
                name: "Thisinh",
                columns: table => new
                {
                    ThisinhID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thisinh", x => x.ThisinhID);
                });
        }
    }
}
