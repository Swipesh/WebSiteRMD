using Microsoft.EntityFrameworkCore.Migrations;

namespace PluralsightASP.Data.Migrations
{
    public partial class FixUsersFilesStruct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersFiles_AspNetUsers_FileId",
                table: "UsersFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFiles_Files_UserId",
                table: "UsersFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersFiles",
                table: "UsersFiles");

            migrationBuilder.DropIndex(
                name: "IX_UsersFiles_UserId",
                table: "UsersFiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersFiles",
                table: "UsersFiles",
                columns: new[] { "UserId", "FileId" });

            migrationBuilder.CreateIndex(
                name: "IX_UsersFiles_FileId",
                table: "UsersFiles",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFiles_Files_FileId",
                table: "UsersFiles",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFiles_AspNetUsers_UserId",
                table: "UsersFiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersFiles_Files_FileId",
                table: "UsersFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFiles_AspNetUsers_UserId",
                table: "UsersFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersFiles",
                table: "UsersFiles");

            migrationBuilder.DropIndex(
                name: "IX_UsersFiles_FileId",
                table: "UsersFiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersFiles",
                table: "UsersFiles",
                columns: new[] { "FileId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UsersFiles_UserId",
                table: "UsersFiles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFiles_AspNetUsers_FileId",
                table: "UsersFiles",
                column: "FileId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFiles_Files_UserId",
                table: "UsersFiles",
                column: "UserId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
