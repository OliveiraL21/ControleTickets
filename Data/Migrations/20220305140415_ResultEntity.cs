using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ResultEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    ResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    TotalHoras = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalHorasDiaria = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.ResultId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ResultId",
                table: "Ticket",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Result_ResultId",
                table: "Ticket",
                column: "ResultId",
                principalTable: "Result",
                principalColumn: "ResultId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Result_ResultId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ResultId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Ticket");
        }
    }
}
