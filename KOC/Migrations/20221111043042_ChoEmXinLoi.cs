using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KOC.Migrations
{
    public partial class ChoEmXinLoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(nullable: true),
                    Ho = table.Column<string>(nullable: true),
                    TenDem = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    ThanhPho = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 200, nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdCV = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(nullable: true),
                    Ho = table.Column<string>(nullable: true),
                    TenDem = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    TenDangNhap = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    ThanhPho = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuChiTiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdPhieu = table.Column<Guid>(nullable: false),
                    IdDichVu = table.Column<Guid>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<float>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuChiTiets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDichVus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdXe = table.Column<Guid>(nullable: false),
                    IdNVTaoPhieu = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(nullable: true),
                    ThoiGianNhan = table.Column<DateTime>(nullable: false),
                    ThoiGianTao = table.Column<DateTime>(nullable: false),
                    ThoiGianHT = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<float>(nullable: false),
                    IdNVSua = table.Column<Guid>(nullable: false),
                    TenNguoiNhan = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDichVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdKH = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(nullable: true),
                    BienSo = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    IdLDV = table.Column<Guid>(nullable: false),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 200, nullable: false),
                    Gia = table.Column<float>(nullable: false),
                    ThoiGianHT = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.Id);
                    table.CheckConstraint("Price", "Gia >= 0");
                    table.CheckConstraint("Time", "ThoiGianHT >= GETDATE()");
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_IdLDV",
                        column: x => x.IdLDV,
                        principalTable: "LoaiDichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_IdLDV",
                table: "DichVu",
                column: "IdLDV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhieuChiTiets");

            migrationBuilder.DropTable(
                name: "PhieuDichVus");

            migrationBuilder.DropTable(
                name: "Xes");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");
        }
    }
}
