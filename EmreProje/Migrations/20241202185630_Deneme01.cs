using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmreProje.Migrations
{
    /// <inheritdoc />
    public partial class Deneme01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunlers",
                table: "Urunlers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategorilers",
                table: "Kategorilers");

            migrationBuilder.RenameTable(
                name: "Urunlers",
                newName: "Urunler_Db");

            migrationBuilder.RenameTable(
                name: "Musteris",
                newName: "Musteri_Db");

            migrationBuilder.RenameTable(
                name: "Kategorilers",
                newName: "Kategoriler_Db");

            migrationBuilder.AlterColumn<decimal>(
                name: "UrunFiyat",
                table: "Urunler_Db",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler_Db",
                table: "Urunler_Db",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteri_Db",
                table: "Musteri_Db",
                column: "MusteriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoriler_Db",
                table: "Kategoriler_Db",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Personel_Db",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelTelefon = table.Column<int>(type: "int", nullable: false),
                    PersonelAktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel_Db", x => x.PersonelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personel_Db");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler_Db",
                table: "Urunler_Db");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteri_Db",
                table: "Musteri_Db");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoriler_Db",
                table: "Kategoriler_Db");

            migrationBuilder.RenameTable(
                name: "Urunler_Db",
                newName: "Urunlers");

            migrationBuilder.RenameTable(
                name: "Musteri_Db",
                newName: "Musteris");

            migrationBuilder.RenameTable(
                name: "Kategoriler_Db",
                newName: "Kategorilers");

            migrationBuilder.AlterColumn<int>(
                name: "UrunFiyat",
                table: "Urunlers",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunlers",
                table: "Urunlers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteris",
                table: "Musteris",
                column: "MusteriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategorilers",
                table: "Kategorilers",
                column: "Id");
        }
    }
}
