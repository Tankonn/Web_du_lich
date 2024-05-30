using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace do_an_co_so.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tieude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Noidung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hinhanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaydang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khachsans",
                columns: table => new
                {
                    Makhachsan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenkhachsan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dongia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thongtinchitiet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachsans", x => x.Makhachsan);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    MaTour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lichtrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Banggia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thongtinlienquan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: false),
                    Diadiemkhoihanh = table.Column<int>(type: "int", nullable: false),
                    Thoiluong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diemden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhachSanMakhachsan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.MaTour);
                    table.ForeignKey(
                        name: "FK_Tours_Khachsans_KhachSanMakhachsan",
                        column: x => x.KhachSanMakhachsan,
                        principalTable: "Khachsans",
                        principalColumn: "Makhachsan");
                });

            migrationBuilder.CreateTable(
                name: "DatTours",
                columns: table => new
                {
                    IdDattour = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mapt = table.Column<int>(type: "int", nullable: true),
                    Yeucau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matour = table.Column<int>(type: "int", nullable: true),
                    Tinhtrang = table.Column<int>(type: "int", nullable: true),
                    Makhachsan = table.Column<int>(type: "int", nullable: true),
                    KhachsanMakhachsan = table.Column<int>(type: "int", nullable: false),
                    TourMaTour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatTours", x => x.IdDattour);
                    table.ForeignKey(
                        name: "FK_DatTours_Khachsans_KhachsanMakhachsan",
                        column: x => x.KhachsanMakhachsan,
                        principalTable: "Khachsans",
                        principalColumn: "Makhachsan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatTours_Tours_TourMaTour",
                        column: x => x.TourMaTour,
                        principalTable: "Tours",
                        principalColumn: "MaTour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phuongthucthanhtoans",
                columns: table => new
                {
                    Mapt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenpt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatTourIdDattour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phuongthucthanhtoans", x => x.Mapt);
                    table.ForeignKey(
                        name: "FK_Phuongthucthanhtoans_DatTours_DatTourIdDattour",
                        column: x => x.DatTourIdDattour,
                        principalTable: "DatTours",
                        principalColumn: "IdDattour",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatTours_KhachsanMakhachsan",
                table: "DatTours",
                column: "KhachsanMakhachsan");

            migrationBuilder.CreateIndex(
                name: "IX_DatTours_TourMaTour",
                table: "DatTours",
                column: "TourMaTour");

            migrationBuilder.CreateIndex(
                name: "IX_Phuongthucthanhtoans_DatTourIdDattour",
                table: "Phuongthucthanhtoans",
                column: "DatTourIdDattour");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_KhachSanMakhachsan",
                table: "Tours",
                column: "KhachSanMakhachsan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Phuongthucthanhtoans");

            migrationBuilder.DropTable(
                name: "DatTours");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Khachsans");
        }
    }
}
