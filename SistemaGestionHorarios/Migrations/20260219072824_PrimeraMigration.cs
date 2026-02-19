using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionHorarios.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleItems");
        }
    }
}
