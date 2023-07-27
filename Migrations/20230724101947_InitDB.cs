using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTechLabProjeFabrikasi.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minucipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Districk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platforms_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Platforms_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Platforms_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Temizlik" },
                    { 2, "", "Tesisat" },
                    { 3, "", "Nakliyat" },
                    { 4, "", "Özel Ders" },
                    { 5, "", "Tadilat" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityCode", "Name" },
                values: new object[,]
                {
                    { 1, 1, "ADANA" },
                    { 2, 2, "ADIYAMAN" },
                    { 3, 3, "AFYONKARAHİSAR" },
                    { 4, 4, "AĞRI" },
                    { 5, 5, "AMASYA" },
                    { 6, 6, "ANKARA" },
                    { 7, 7, "ANTALYA" },
                    { 8, 8, "ARTVİN" },
                    { 9, 9, "AYDIN" },
                    { 10, 10, "BALIKESİR" },
                    { 11, 11, "BİLECİK" },
                    { 12, 12, "BİNGÖL" },
                    { 13, 13, "BİTLİS" },
                    { 14, 14, "BOLU" },
                    { 15, 15, "BURDUR" },
                    { 16, 16, "BURSA" },
                    { 17, 17, "ÇANAKKALE" },
                    { 18, 18, "ÇANKIRI" },
                    { 19, 19, "ÇORUM" },
                    { 20, 20, "DENİZLİ" },
                    { 21, 21, "DİYARBAKIR" },
                    { 22, 22, "EDİRNE" },
                    { 23, 23, "ELAZIĞ" },
                    { 24, 24, "ERZİNCAN" },
                    { 25, 25, "ERZURUM" },
                    { 26, 26, "ESKİŞEHİR" },
                    { 27, 27, "GAZİANTEP" },
                    { 28, 28, "GİRESUN" },
                    { 29, 29, "GÜMÜŞHANE" },
                    { 30, 30, "HAKKARİ" },
                    { 31, 31, "HATAY" },
                    { 32, 32, "ISPARTA" },
                    { 33, 33, "MERSİN" },
                    { 34, 34, "İSTANBUL" },
                    { 35, 35, "İZMİR" },
                    { 36, 36, "KARS" },
                    { 37, 37, "KASTAMONU" },
                    { 38, 38, "KAYSERİ" },
                    { 39, 39, "KIRKLARELİ" },
                    { 40, 40, "KIRŞEHİR" },
                    { 41, 41, "KOCAELİ" },
                    { 42, 42, "KONYA" },
                    { 43, 43, "KÜTAHYA" },
                    { 44, 44, "MALATYA" },
                    { 45, 45, "MANİSA" },
                    { 46, 46, "KAHRAMANMARAŞ" },
                    { 47, 47, "MARDİN" },
                    { 48, 48, "MUĞLA" },
                    { 49, 49, "MUŞ" },
                    { 50, 50, "NEVŞEHİR" },
                    { 51, 51, "NİĞDE" },
                    { 52, 52, "ORDU" },
                    { 53, 53, "RİZE" },
                    { 54, 54, "SAKARYA" },
                    { 55, 55, "SAMSUN" },
                    { 56, 56, "SİİRT" },
                    { 57, 57, "SİNOP" },
                    { 58, 58, "SİVAS" },
                    { 59, 59, "TEKİRDAĞ" },
                    { 60, 60, "TOKAT" },
                    { 61, 61, "TRABZON" },
                    { 62, 62, "TUNCELİ" },
                    { 63, 63, "ŞANLIURFA" },
                    { 64, 64, "UŞAK" },
                    { 65, 65, "VAN" },
                    { 66, 66, "YOZGAT" },
                    { 67, 67, "ZONGULDAK" },
                    { 68, 68, "AKSARAY" },
                    { 69, 69, "BAYBURT" },
                    { 70, 70, "KARAMAN" },
                    { 71, 71, "KIRIKKALE" },
                    { 72, 72, "BATMAN" },
                    { 73, 73, "ŞIRNAK" },
                    { 74, 74, "BARTIN" },
                    { 75, 75, "ARDAHAN" },
                    { 76, 76, "IĞDIR" },
                    { 77, 77, "YALOVA" },
                    { 78, 78, "KARABÜK" },
                    { 79, 79, "KİLİS" },
                    { 80, 80, "OSMANİYE" },
                    { 81, 81, "DÜZCE" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "EMail", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "zeynepbilgic@gmail.com", "Zeynep Bilgiç", 0 },
                    { 2, "mehmettan@gmail.com", "Mehmet Tan", 0 }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "EMail", "MiddleName", "Name", "PhoneNumber", "ServiceArea", "Surname" },
                values: new object[,]
                {
                    { 1, "yusufali@gmail.com", "Ali", "Yusuf", "05553462133", "Su Tesisatı", "Kurt" },
                    { 2, "g.muratkaraca@gmail.com", "Murat", "Gökhan", "05553462133", "Kombi Tesisatı", "Karaca" },
                    { 3, "a.cankısa@gmail.com", "", "Emir", "05323698520", "Kombi Tesisatı", "Alioğlu" },
                    { 4, "yasinnnuroglu@gmail.com", "", "Yasin", "05362314578", "Su Tesisatı", "Nuroğlu" },
                    { 5, "m.rıza@gmail.com", "Rıza", "Mustafa", "05356231459", "Ev Nakliyat", "Yurttaş" },
                    { 6, "eminkaraoglu@gmail.com", "", "Emin", "05355632147", "Ev Nakliyat", "Karaoğlu" },
                    { 7, "a.cankısa@gmail.com", "Can", "Abdullah", "05348963214", "Ev Nakliyat", "Kısa" },
                    { 8, "ıhsanuzun@gmail.com", "", "İhsan", "05389632314", "Ev Boya Tadilat", "Uzun" },
                    { 9, "n.rızabalaban@gmail.com", "Rıza", "Nuri", "05321369654", "Ev Boya Tadilat", "Balaban" },
                    { 10, "fehmigursoy@gmail.com", "", "Fehmi", "05367894512", "Ev Banyo Tadilat", "Gürsoy" },
                    { 11, "haydardirican@gmail.com", "", "Haydar", "05346987436", "Ev Banyo Tadilat", "Dirican" },
                    { 12, "fatmaparlak@gmail.com", "", "Fatma", "05342365897", "Ev Temizlik", "Parlak" },
                    { 13, "aysenurkorkmaz@gmail.com", "Nur", "Ayşe", "05325632147", "Ev Temizlik", "Korkmaz" },
                    { 14, "esrahaktan@gmail.com", "", "Esra", "05378963215", "Ev Temizlik", "Haktan" },
                    { 15, "yusufali@gmail.com", "Ali", "Yusuf", "05553462133", "Su Tesisatı", "Kurt" },
                    { 16, "leylakara@gmail.com", "", "Leyla", "05478562314", "Matematik Özel Ders", "Kara" },
                    { 17, "ayhandonmez@gmail.com", "", "Ayhan", "05362696321", "Matematik Özel Ders", "Dönmez" },
                    { 18, "ebruyurtseven@gmail.com", "", "Ebru", "05562314569", "Matematik Özel Ders", "Yurtseven" },
                    { 19, "nurdandertli@gmail.com", "", "Nurdan", "05312659874", "Fizik Özel Ders", "Dertli" },
                    { 20, "aslısever@gmail.com", "", "Aslı", "05326987546", "Fizik Özel Ders", "Sever" },
                    { 21, "muratkaraman@gmail.com", "", "Murat", "05369875632", "Türkçe Özel Ders", "Karaman" },
                    { 22, "nilgunvatansever@gmail.com", "", "Nilgün", "05336952314", "Türkçe Özel Ders", "Vatansever" },
                    { 23, "n.ayseyılmaz@gmail.com", "Ayşe", "Nalan", "05426312369", "İngilizce Özel Ders", "Yılmaz" },
                    { 24, "alikemalcandan@gmail.com", "Kemal", "Ali", "05352698741", "İngilizce Özel Ders", "Candan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ExpertId",
                table: "Addresses",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CategoryId",
                table: "Platforms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_CustomerId",
                table: "Platforms",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_ExpertId",
                table: "Platforms",
                column: "ExpertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Experts");
        }
    }
}
