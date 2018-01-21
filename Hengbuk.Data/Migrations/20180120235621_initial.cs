using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hengbuk.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<string>(nullable: true),
                    modified = table.Column<DateTime>(nullable: false),
                    modifiedby = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<string>(nullable: true),
                    key = table.Column<string>(nullable: true),
                    modified = table.Column<DateTime>(nullable: false),
                    modifiedby = table.Column<string>(nullable: true),
                    userid = table.Column<long>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<string>(nullable: true),
                    modified = table.Column<DateTime>(nullable: false),
                    modifiedby = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<string>(nullable: true),
                    modified = table.Column<DateTime>(nullable: false),
                    modifiedby = table.Column<string>(nullable: true),
                    total = table.Column<long>(nullable: false),
                    userid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Responses_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponseLines",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    answer = table.Column<int>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<string>(nullable: true),
                    modified = table.Column<DateTime>(nullable: false),
                    modifiedby = table.Column<string>(nullable: true),
                    questionid = table.Column<long>(nullable: false),
                    userresponseid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseLines", x => x.id);
                    table.ForeignKey(
                        name: "FK_ResponseLines_Questions_questionid",
                        column: x => x.questionid,
                        principalTable: "Questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseLines_Responses_userresponseid",
                        column: x => x.userresponseid,
                        principalTable: "Responses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponseLines_questionid",
                table: "ResponseLines",
                column: "questionid");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseLines_userresponseid",
                table: "ResponseLines",
                column: "userresponseid");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_userid",
                table: "Responses",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseLines");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
