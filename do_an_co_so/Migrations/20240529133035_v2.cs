using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace do_an_co_so.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_datTours_PKhachsans_Makhachsan1",
                table: "datTours");

            migrationBuilder.DropForeignKey(
                name: "FK_datTours_Tours_MaTour",
                table: "datTours");

            migrationBuilder.DropForeignKey(
                name: "FK_datTours_phuongthucthanhtoans_Mapt",
                table: "datTours");

            migrationBuilder.DropIndex(
                name: "IX_datTours_Mapt",
                table: "datTours");

            migrationBuilder.DropIndex(
                name: "IX_datTours_MaTour",
                table: "datTours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PKhachsans",
                table: "PKhachsans");

            migrationBuilder.RenameTable(
                name: "PKhachsans",
                newName: "Khachsans");

            migrationBuilder.RenameColumn(
                name: "MaTour",
                table: "datTours",
                newName: "Matour");

            migrationBuilder.AddColumn<int>(
                name: "KhachsanMakhachsan",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DatTourIdDattour",
                table: "phuongthucthanhtoans",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Mapt",
                table: "datTours",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Makhachsan1",
                table: "datTours",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Matour",
                table: "datTours",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "tourMaTour",
                table: "datTours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Makhachsan",
                table: "Khachsans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Khachsans",
                table: "Khachsans",
                column: "Makhachsan");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_KhachsanMakhachsan",
                table: "Tours",
                column: "KhachsanMakhachsan");

            migrationBuilder.CreateIndex(
                name: "IX_phuongthucthanhtoans_DatTourIdDattour",
                table: "phuongthucthanhtoans",
                column: "DatTourIdDattour");

            migrationBuilder.CreateIndex(
                name: "IX_datTours_tourMaTour",
                table: "datTours",
                column: "tourMaTour");

            migrationBuilder.AddForeignKey(
                name: "FK_datTours_Khachsans_Makhachsan1",
                table: "datTours",
                column: "Makhachsan1",
                principalTable: "Khachsans",
                principalColumn: "Makhachsan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_datTours_Tours_tourMaTour",
                table: "datTours",
                column: "tourMaTour",
                principalTable: "Tours",
                principalColumn: "MaTour",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_phuongthucthanhtoans_datTours_DatTourIdDattour",
                table: "phuongthucthanhtoans",
                column: "DatTourIdDattour",
                principalTable: "datTours",
                principalColumn: "IdDattour");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Khachsans_KhachsanMakhachsan",
                table: "Tours",
                column: "KhachsanMakhachsan",
                principalTable: "Khachsans",
                principalColumn: "Makhachsan",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_datTours_Khachsans_Makhachsan1",
                table: "datTours");

            migrationBuilder.DropForeignKey(
                name: "FK_datTours_Tours_tourMaTour",
                table: "datTours");

            migrationBuilder.DropForeignKey(
                name: "FK_phuongthucthanhtoans_datTours_DatTourIdDattour",
                table: "phuongthucthanhtoans");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Khachsans_KhachsanMakhachsan",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_KhachsanMakhachsan",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_phuongthucthanhtoans_DatTourIdDattour",
                table: "phuongthucthanhtoans");

            migrationBuilder.DropIndex(
                name: "IX_datTours_tourMaTour",
                table: "datTours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Khachsans",
                table: "Khachsans");

            migrationBuilder.DropColumn(
                name: "KhachsanMakhachsan",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "DatTourIdDattour",
                table: "phuongthucthanhtoans");

            migrationBuilder.DropColumn(
                name: "tourMaTour",
                table: "datTours");

            migrationBuilder.RenameTable(
                name: "Khachsans",
                newName: "PKhachsans");

            migrationBuilder.RenameColumn(
                name: "Matour",
                table: "datTours",
                newName: "MaTour");

            migrationBuilder.AlterColumn<int>(
                name: "MaTour",
                table: "datTours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Mapt",
                table: "datTours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Makhachsan1",
                table: "datTours",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Makhachsan",
                table: "PKhachsans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PKhachsans",
                table: "PKhachsans",
                column: "Makhachsan");

            migrationBuilder.CreateIndex(
                name: "IX_datTours_Mapt",
                table: "datTours",
                column: "Mapt");

            migrationBuilder.CreateIndex(
                name: "IX_datTours_MaTour",
                table: "datTours",
                column: "MaTour");

            migrationBuilder.AddForeignKey(
                name: "FK_datTours_PKhachsans_Makhachsan1",
                table: "datTours",
                column: "Makhachsan1",
                principalTable: "PKhachsans",
                principalColumn: "Makhachsan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_datTours_Tours_MaTour",
                table: "datTours",
                column: "MaTour",
                principalTable: "Tours",
                principalColumn: "MaTour",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_datTours_phuongthucthanhtoans_Mapt",
                table: "datTours",
                column: "Mapt",
                principalTable: "phuongthucthanhtoans",
                principalColumn: "Mapt",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
