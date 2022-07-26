using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Upgrade.TraineeAdmin.Infrastructure.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
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
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DasId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    TechnologyId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    CurrentCareerId = table.Column<int>(type: "int", nullable: true),
                    OnBoardingDate = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobProfileTrainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    JobProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobProfileTrainee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobProfileTrainee_JobProfile_JobProfileId",
                        column: x => x.JobProfileId,
                        principalTable: "JobProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobProfileTrainee_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 952, DateTimeKind.Local).AddTicks(8694), null, "Basic", 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(2444) },
                    { 2, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3591), null, "Intermediate", 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3601) },
                    { 3, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3604), null, "Advanced", 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3606) },
                    { 4, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3608), null, "Super saiyan ultra hyper god green hair ", 1, new DateTime(2022, 7, 22, 15, 36, 37, 955, DateTimeKind.Local).AddTicks(3610) }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3818), null, "Front-end", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3840) },
                    { 2, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3843), null, "Back-end", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3845) },
                    { 3, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3848), null, "QA Automation", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(3849) }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "Description", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6228), null, ".NET", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6241) },
                    { 2, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6258), null, "Java", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6260) },
                    { 3, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6262), null, "Angular 2", 1, new DateTime(2022, 7, 22, 15, 36, 37, 956, DateTimeKind.Local).AddTicks(6264) }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Active", "AddressId", "CreatedBy", "CreatedOn", "DasId", "Email", "UpdatedBy", "UpdatedOn", "UserId" },
                values: new object[] { 1, true, 1, 1, new DateTime(2022, 7, 22, 15, 36, 37, 957, DateTimeKind.Local).AddTicks(242), "1", "1@gmail.com", 1, new DateTime(2022, 7, 22, 15, 36, 37, 957, DateTimeKind.Local).AddTicks(257), 1 });

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
                table: "Trainees",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedOn", "CurrentCareerId", "UpdatedBy", "UpdatedOn", "UserProfileId" },
                values: new object[] { 1, true, 1, new DateTime(2022, 7, 22, 15, 36, 37, 957, DateTimeKind.Local).AddTicks(5110), 1, 1, new DateTime(2022, 7, 22, 15, 36, 37, 957, DateTimeKind.Local).AddTicks(5114), 1 });

            migrationBuilder.InsertData(
                table: "JobProfileTrainee",
                columns: new[] { "Id", "JobProfileId", "TraineeId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "JobProfileTrainee",
                columns: new[] { "Id", "JobProfileId", "TraineeId" },
                values: new object[] { 2, 2, 1 });

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
                name: "IX_JobProfileTrainee_JobProfileId",
                table: "JobProfileTrainee",
                column: "JobProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_JobProfileTrainee_TraineeId",
                table: "JobProfileTrainee",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Name",
                table: "Levels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Name",
                table: "Positions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_Name",
                table: "Technologies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_UserProfileId",
                table: "Trainees",
                column: "UserProfileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobProfileTrainee");

            migrationBuilder.DropTable(
                name: "JobProfile");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
