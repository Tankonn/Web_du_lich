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
                name: "phuongthucthanhtoans",
                columns: table => new
                {
                    Mapt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenpt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phuongthucthanhtoans", x => x.Mapt);
                });

            migrationBuilder.CreateTable(
                name: "PKhachsans",
                columns: table => new
                {
                    Makhachsan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tenkhachsan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dongia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thongtinchitiet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PKhachsans", x => x.Makhachsan);
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
                    images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: false),
                    Diadiemkhoihanh = table.Column<int>(type: "int", nullable: false),
                    Thoiluong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diemden = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.MaTour);
                });

            migrationBuilder.CreateTable(
                name: "datTours",
                columns: table => new
                {
                    IdDattour = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mapt = table.Column<int>(type: "int", nullable: false),
                    yeucau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTour = table.Column<int>(type: "int", nullable: false),
                    Tinhtrang = table.Column<int>(type: "int", nullable: true),
                    Makhachsan1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datTours", x => x.IdDattour);
                    table.ForeignKey(
                        name: "FK_datTours_PKhachsans_Makhachsan1",
                        column: x => x.Makhachsan1,
                        principalTable: "PKhachsans",
                        principalColumn: "Makhachsan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_datTours_Tours_MaTour",
                        column: x => x.MaTour,
                        principalTable: "Tours",
                        principalColumn: "MaTour",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_datTours_phuongthucthanhtoans_Mapt",
                        column: x => x.Mapt,
                        principalTable: "phuongthucthanhtoans",
                        principalColumn: "Mapt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_datTours_Makhachsan1",
                table: "datTours",
                column: "Makhachsan1");

            migrationBuilder.CreateIndex(
                name: "IX_datTours_Mapt",
                table: "datTours",
                column: "Mapt");

            migrationBuilder.CreateIndex(
                name: "IX_datTours_MaTour",
                table: "datTours",
                column: "MaTour");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "datTours");

            migrationBuilder.DropTable(
                name: "PKhachsans");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "phuongthucthanhtoans");
        }
    }
}
