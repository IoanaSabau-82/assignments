using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class updateColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedVolunteers_FoundPetPosts_PostId",
                table: "AssignedVolunteers");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedVolunteers_Users_AssignedToId",
                table: "AssignedVolunteers");

            migrationBuilder.DropForeignKey(
                name: "FK_FoundPetPosts_Users_CreatedById",
                table: "FoundPetPosts");

            migrationBuilder.RenameColumn(
                name: "Last name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "First name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedVolunteers_FoundPetPosts_PostId",
                table: "AssignedVolunteers",
                column: "PostId",
                principalTable: "FoundPetPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedVolunteers_Users_AssignedToId",
                table: "AssignedVolunteers",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FoundPetPosts_Users_CreatedById",
                table: "FoundPetPosts",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedVolunteers_FoundPetPosts_PostId",
                table: "AssignedVolunteers");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedVolunteers_Users_AssignedToId",
                table: "AssignedVolunteers");

            migrationBuilder.DropForeignKey(
                name: "FK_FoundPetPosts_Users_CreatedById",
                table: "FoundPetPosts");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Last name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "First name");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedVolunteers_FoundPetPosts_PostId",
                table: "AssignedVolunteers",
                column: "PostId",
                principalTable: "FoundPetPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedVolunteers_Users_AssignedToId",
                table: "AssignedVolunteers",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoundPetPosts_Users_CreatedById",
                table: "FoundPetPosts",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
