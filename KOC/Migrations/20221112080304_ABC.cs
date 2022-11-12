using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KOC.Migrations
{
    public partial class ABC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Xes",
                table: "Xes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuDichVus",
                table: "PhieuDichVus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuChiTiets",
                table: "PhieuChiTiets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "Xes",
                newName: "Xe");

            migrationBuilder.RenameTable(
                name: "PhieuDichVus",
                newName: "PhieuDichVu");

            migrationBuilder.RenameTable(
                name: "PhieuChiTiets",
                newName: "PhieuChiTiet");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.CreateCheckConstraint(
                name: "TimeHT",
                table: "PhieuDichVu",
                sql: "ThoiGianHT >= GETDATE()");

            migrationBuilder.CreateCheckConstraint(
                name: "TimeNhan",
                table: "PhieuDichVu",
                sql: "ThoiGianNhan >= GETDATE()");

            migrationBuilder.CreateCheckConstraint(
                name: "PriceSum",
                table: "PhieuDichVu",
                sql: "TongTien >= 0");

            migrationBuilder.CreateCheckConstraint(
                name: "Stocks",
                table: "PhieuChiTiet",
                sql: "SoLuong >= 0");

            migrationBuilder.CreateCheckConstraint(
                name: "Prices",
                table: "PhieuChiTiet",
                sql: "DonGia >= 0");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "Xe",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BienSo",
                table: "Xe",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Xe",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "PhieuDichVu",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianTao",
                table: "PhieuDichVu",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiNhan",
                table: "PhieuDichVu",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "PhieuDichVu",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "PhieuDichVu",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PhieuDichVu",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "PhieuChiTiet",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PhieuChiTiet",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "NhanVien",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ThanhPho",
                table: "NhanVien",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDem",
                table: "NhanVien",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "NhanVien",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "NhanVien",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanVien",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ho",
                table: "NhanVien",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "NhanVien",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHang",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ThanhPho",
                table: "KhachHang",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDem",
                table: "KhachHang",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "KhachHang",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "KhachHang",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHang",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ho",
                table: "KhachHang",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "KhachHang",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Xe",
                table: "Xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuDichVu",
                table: "PhieuDichVu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuChiTiet",
                table: "PhieuChiTiet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_IdKH",
                table: "Xe",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_IdNVTaoPhieu",
                table: "PhieuDichVu",
                column: "IdNVTaoPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_IdXe",
                table: "PhieuDichVu",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChiTiet_IdDichVu",
                table: "PhieuChiTiet",
                column: "IdDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChiTiet_IdPhieu",
                table: "PhieuChiTiet",
                column: "IdPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_IdCV",
                table: "NhanVien",
                column: "IdCV",
                principalTable: "ChucVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuChiTiet_DichVu_IdDichVu",
                table: "PhieuChiTiet",
                column: "IdDichVu",
                principalTable: "DichVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuChiTiet_PhieuDichVu_IdPhieu",
                table: "PhieuChiTiet",
                column: "IdPhieu",
                principalTable: "PhieuDichVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuDichVu_NhanVien_IdNVTaoPhieu",
                table: "PhieuDichVu",
                column: "IdNVTaoPhieu",
                principalTable: "NhanVien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuDichVu_Xe_IdXe",
                table: "PhieuDichVu",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_KhachHang_IdKH",
                table: "Xe",
                column: "IdKH",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IdCV",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuChiTiet_DichVu_IdDichVu",
                table: "PhieuChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuChiTiet_PhieuDichVu_IdPhieu",
                table: "PhieuChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuDichVu_NhanVien_IdNVTaoPhieu",
                table: "PhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuDichVu_Xe_IdXe",
                table: "PhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_KhachHang_IdKH",
                table: "Xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Xe",
                table: "Xe");

            migrationBuilder.DropIndex(
                name: "IX_Xe_IdKH",
                table: "Xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuDichVu",
                table: "PhieuDichVu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuDichVu_IdNVTaoPhieu",
                table: "PhieuDichVu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuDichVu_IdXe",
                table: "PhieuDichVu");

            migrationBuilder.DropCheckConstraint(
                name: "TimeHT",
                table: "PhieuDichVu");

            migrationBuilder.DropCheckConstraint(
                name: "TimeNhan",
                table: "PhieuDichVu");

            migrationBuilder.DropCheckConstraint(
                name: "PriceSum",
                table: "PhieuDichVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuChiTiet",
                table: "PhieuChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_PhieuChiTiet_IdDichVu",
                table: "PhieuChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_PhieuChiTiet_IdPhieu",
                table: "PhieuChiTiet");

            migrationBuilder.DropCheckConstraint(
                name: "Stocks",
                table: "PhieuChiTiet");

            migrationBuilder.DropCheckConstraint(
                name: "Prices",
                table: "PhieuChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.RenameTable(
                name: "Xe",
                newName: "Xes");

            migrationBuilder.RenameTable(
                name: "PhieuDichVu",
                newName: "PhieuDichVus");

            migrationBuilder.RenameTable(
                name: "PhieuChiTiet",
                newName: "PhieuChiTiets");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "Xes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "BienSo",
                table: "Xes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Xes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "PhieuDichVus",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianTao",
                table: "PhieuDichVus",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiNhan",
                table: "PhieuDichVus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "PhieuDichVus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "PhieuDichVus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PhieuDichVus",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "PhieuChiTiets",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PhieuChiTiets",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "NhanViens",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ThanhPho",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "TenDem",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Ho",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "NhanViens",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHangs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ThanhPho",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "TenDem",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Ho",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "KhachHangs",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Xes",
                table: "Xes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuDichVus",
                table: "PhieuDichVus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuChiTiets",
                table: "PhieuChiTiets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "Id");
        }
    }
}
