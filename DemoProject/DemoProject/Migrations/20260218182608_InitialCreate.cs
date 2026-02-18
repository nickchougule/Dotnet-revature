using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesRepresentatives",
                columns: table => new
                {
                    RepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesRepresentatives", x => x.RepId);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    LeadID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedRepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.LeadID);
                    table.ForeignKey(
                        name: "FK_Leads_SalesRepresentatives_AssignedRepId",
                        column: x => x.AssignedRepId,
                        principalTable: "SalesRepresentatives",
                        principalColumn: "RepId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadInteractions",
                columns: table => new
                {
                    InteractionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InteractionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InteractionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadInteractions", x => x.InteractionId);
                    table.ForeignKey(
                        name: "FK_LeadInteractions_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "LeadID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SalesRepresentatives",
                columns: new[] { "RepId", "Department", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Sales", "nikhil@gmail.com", "Nikhil" },
                    { 2, "Sales", "amit@gmail.com", "Amit" }
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "LeadID", "AssignedRepId", "Company", "CreatedDate", "Name", "PhoneNo", "Position", "Priority", "Source", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Infosys", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahul Sharma", "9999999999", "Manager", "High", "Website", "New" },
                    { 2, 2, "TCS", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Priya Verma", "8888888888", "Director", "Medium", "Referral", "Contacted" }
                });

            migrationBuilder.InsertData(
                table: "LeadInteractions",
                columns: new[] { "InteractionId", "Details", "FollowUpDate", "InteractionDate", "InteractionType", "LeadId" },
                values: new object[,]
                {
                    { 1, "Initial discussion completed", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call", 1 },
                    { 2, "Proposal shared", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Email", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadInteractions_LeadId",
                table: "LeadInteractions",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_AssignedRepId",
                table: "Leads",
                column: "AssignedRepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeadInteractions");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "SalesRepresentatives");
        }
    }
}
