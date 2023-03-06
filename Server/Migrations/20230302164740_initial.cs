using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tool.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AddQuestions",
                columns: table => new
                {
                    QuizesQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddQuestions", x => x.QuizesQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.QuestionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Quizs",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxScore = table.Column<int>(type: "int", nullable: false),
                    PassingScore = table.Column<int>(type: "int", nullable: false),
                    QuizLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timer = table.Column<double>(type: "float", nullable: false),
                    PublishedBy = table.Column<int>(type: "int", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizs", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleDiscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleCode);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestions",
                columns: table => new
                {
                    QuizQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    QuestionMedia = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ToolTip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestions", x => x.QuizQuestionId);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "QuestionTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    AddQuestionQuizesQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_AddQuestions_AddQuestionQuizesQuestionId",
                        column: x => x.AddQuestionQuizesQuestionId,
                        principalTable: "AddQuestions",
                        principalColumn: "QuizesQuestionId");
                    table.ForeignKey(
                        name: "FK_User_Roles_RoleCode",
                        column: x => x.RoleCode,
                        principalTable: "Roles",
                        principalColumn: "RoleCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    QuizOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.QuizOptionId);
                    table.ForeignKey(
                        name: "FK_QuestionOptions_QuizQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuizQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionOptions_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizReports",
                columns: table => new
                {
                    QuizReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    ObtainedScore = table.Column<int>(type: "int", nullable: false),
                    PassingScore = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attempt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizReports", x => x.QuizReportId);
                    table.ForeignKey(
                        name: "FK_QuizReports_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuizReports_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ObtainedScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK_Scores_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    UserAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    Attempt = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    UserSelectedOption = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => x.UserAnswerId);
                    table.ForeignKey(
                        name: "FK_UserAnswers_QuizQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuizQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswers_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswerMappings",
                columns: table => new
                {
                    UserAnsweringMappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Attempt = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuizOptionId = table.Column<int>(type: "int", nullable: false),
                    UserSelectedOption = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    QuizQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswerMappings", x => x.UserAnsweringMappingId);
                    table.ForeignKey(
                        name: "FK_UserAnswerMappings_QuestionOptions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionOptions",
                        principalColumn: "QuizOptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswerMappings_QuizQuestions_QuizQuestionId",
                        column: x => x.QuizQuestionId,
                        principalTable: "QuizQuestions",
                        principalColumn: "QuizQuestionId");
                    table.ForeignKey(
                        name: "FK_UserAnswerMappings_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuizId",
                table: "QuestionOptions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_QuestionTypeId",
                table: "QuizQuestions",
                column: "QuestionTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_QuizId",
                table: "QuizQuestions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizReports_QuizId",
                table: "QuizReports",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizReports_UserId",
                table: "QuizReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_QuizId",
                table: "Scores",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_UserId",
                table: "Scores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddQuestionQuizesQuestionId",
                schema: "dbo",
                table: "User",
                column: "AddQuestionQuizesQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleCode",
                schema: "dbo",
                table: "User",
                column: "RoleCode",
                unique: true,
                filter: "[RoleCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswerMappings_QuestionId",
                table: "UserAnswerMappings",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswerMappings_QuizQuestionId",
                table: "UserAnswerMappings",
                column: "QuizQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswerMappings_UserId",
                table: "UserAnswerMappings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuestionId",
                table: "UserAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuizId",
                table: "UserAnswers",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_UserId",
                table: "UserAnswers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizReports");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "UserAnswerMappings");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "AddQuestions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "Quizs");
        }
    }
}
