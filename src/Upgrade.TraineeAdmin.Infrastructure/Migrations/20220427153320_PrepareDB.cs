using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Upgrade.TraineeAdmin.Infrastructure.Migrations
{
    public partial class PrepareDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    TechnologyId = table.Column<int>(type: "int", nullable: true),
                    LevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProfile_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobProfile_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobProfile_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JobProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_JobProfile_JobProfileId",
                        column: x => x.JobProfileId,
                        principalTable: "JobProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 597, DateTimeKind.Local).AddTicks(2467), null, "Basic", 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(409) },
                    { 2, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2209), null, "Intermediate", 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2226) },
                    { 3, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2231), null, "Advanced", 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2234) },
                    { 4, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2238), null, "Super saiyan ultra hyper god green hair ", 1, new DateTime(2022, 4, 27, 10, 33, 19, 601, DateTimeKind.Local).AddTicks(2241) }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8803), null, "Front-end", 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8840) },
                    { 2, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8845), null, "Back-end", 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8849) },
                    { 3, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8852), null, "QA Automation", 1, new DateTime(2022, 4, 27, 10, 33, 19, 602, DateTimeKind.Local).AddTicks(8855) }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2039), null, ".NET", 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2067) },
                    { 2, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2073), null, "Java", 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2076) },
                    { 3, true, 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2080), null, "Angular 2", 1, new DateTime(2022, 4, 27, 10, 33, 19, 603, DateTimeKind.Local).AddTicks(2083) }
                });

            migrationBuilder.InsertData(
                table: "JobProfile",
                columns: new[] { "Id", "LevelId", "PositionId", "TechnologyId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 2, 1, 2 },
                    { 4, 3, 1, 2 },
                    { 7, 3, 3, 2 },
                    { 5, 1, 2, 3 },
                    { 6, 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "JobProfileId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobProfile_LevelId",
                table: "JobProfile",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfile_PositionId",
                table: "JobProfile",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfile_TechnologyId",
                table: "JobProfile",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Name",
                table: "Levels",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Name",
                table: "Positions",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_Name",
                table: "Technologies",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_JobProfileId",
                table: "UserProfiles",
                column: "JobProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "JobProfile");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Technologies");
        }
    }
}
