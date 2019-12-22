using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YasayanKutuphane.Data.Migrations
{
    public partial class AddTablesFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dil",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dil", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KapakTipi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KapakTipi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KitapTuru",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapTuru", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ulke",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulke", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cevirmen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeID = table.Column<int>(nullable: false),
                    Isim = table.Column<string>(nullable: true),
                    Soyisim = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cevirmen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cevirmen_Ulke_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulke",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeID = table.Column<int>(nullable: false),
                    Isim = table.Column<string>(nullable: true),
                    Soyisim = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false),
                    Hayati = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yazar_Ulke_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulke",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriID = table.Column<int>(nullable: false),
                    DilID = table.Column<int>(nullable: false),
                    YayineviID = table.Column<int>(nullable: false),
                    KapakTipiID = table.Column<int>(nullable: false),
                    KitapTuruID = table.Column<int>(nullable: false),
                    Isim = table.Column<string>(nullable: true),
                    Tanitim = table.Column<string>(nullable: true),
                    KapakFotografi = table.Column<string>(nullable: true),
                    BasimTarihi = table.Column<DateTime>(nullable: false),
                    SayfaSayisi = table.Column<int>(nullable: false),
                    Puan = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kitap_Dil_DilID",
                        column: x => x.DilID,
                        principalTable: "Dil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_KapakTipi_KapakTipiID",
                        column: x => x.KapakTipiID,
                        principalTable: "KapakTipi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_KitapTuru_KitapTuruID",
                        column: x => x.KitapTuruID,
                        principalTable: "KitapTuru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitap_Yayinevi_YayineviID",
                        column: x => x.YayineviID,
                        principalTable: "Yayinevi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapCevirmen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CevirmenID = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    KitapID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapCevirmen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KitapCevirmen_Cevirmen_CevirmenID",
                        column: x => x.CevirmenID,
                        principalTable: "Cevirmen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapCevirmen_Kitap_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarID = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    KitapID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitap_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapID = table.Column<int>(nullable: false),
                    YorumTarihi = table.Column<DateTime>(nullable: false),
                    Icerik = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yorum_Kitap_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cevirmen_UlkeID",
                table: "Cevirmen",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_DilID",
                table: "Kitap",
                column: "DilID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_KapakTipiID",
                table: "Kitap",
                column: "KapakTipiID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_KategoriID",
                table: "Kitap",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_KitapTuruID",
                table: "Kitap",
                column: "KitapTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YayineviID",
                table: "Kitap",
                column: "YayineviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapCevirmen_CevirmenID",
                table: "KitapCevirmen",
                column: "CevirmenID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapCevirmen_KitapID",
                table: "KitapCevirmen",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_KitapID",
                table: "KitapYazar",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarID",
                table: "KitapYazar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Yazar_UlkeID",
                table: "Yazar",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_KitapID",
                table: "Yorum",
                column: "KitapID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapCevirmen");

            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Cevirmen");

            migrationBuilder.DropTable(
                name: "Yazar");

            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Ulke");

            migrationBuilder.DropTable(
                name: "Dil");

            migrationBuilder.DropTable(
                name: "KapakTipi");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "KitapTuru");

            migrationBuilder.DropTable(
                name: "Yayinevi");
        }
    }
}
