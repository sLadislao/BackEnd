using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestRamsay.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Price = table.Column<double>(type: "REAL", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SSN = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    GenderId = table.Column<int>(type: "INTEGER", nullable: false),
                    DegreeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Degree",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Computer Science", 12000000.0 },
                    { 2, "Data Modeling", 11000000.0 },
                    { 3, "Analytics", 11500000.0 },
                    { 4, "Energy & Sustainability", 11500000.0 },
                    { 5, "Innovation", 6500000.0 }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "Birthday", "DegreeId", "Email", "GenderId", "Name", "Phone", "SSN" },
                values: new object[,]
                {
                    { 1, "4328 Laurel Lane Hobbs, TX 88240", new DateOnly(1944, 1, 23), 3, "CodyKShepley@rhyta.com", 1, "Cody K. Shepley", "4322970107", "463-05-XXXX" },
                    { 2, "264 Green Acres Road Nashville, NC 27856", new DateOnly(1987, 5, 16), 1, "KristopherCLyon@jourrapide.com", 1, "Kristopher C. Lyon", "2524599441", "681-05-XXXX" },
                    { 3, "1611 Ersel Street Dallas, TX 75215", new DateOnly(1981, 9, 25), 5, "TracyBBridges@teleworm.us", 2, "Tracy B. Bridges", "2144211527", "457-36-XXXX" },
                    { 4, "4932 Randolph Street Natick, MA 01760", new DateOnly(1999, 1, 5), 2, "StacyEMiller@dayrep.com", 2, "Stacy E. Miller", "508-651-0738", "019-12-XXXX" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_DegreeId",
                table: "Student",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GenderId",
                table: "Student",
                column: "GenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
