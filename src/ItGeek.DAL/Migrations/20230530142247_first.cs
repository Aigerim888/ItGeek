using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItGeek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Posts",
                newName: "EditedAt");

            migrationBuilder.RenameColumn(
                name: "SocailLink",
                table: "AuthorSocial",
                newName: "SocialLink");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EditedAt",
                table: "Posts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "SocialLink",
                table: "AuthorSocial",
                newName: "SocailLink");
        }
    }
}
