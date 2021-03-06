﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tour.Models;

namespace tour.Migrations
{
    [DbContext(typeof(Tour_DBContext))]
    partial class Tour_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tour.Models.ChiPhis", b =>
                {
                    b.Property<int>("ChiphiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("chiphi_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chitiet")
                        .HasColumnName("chitiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoanId")
                        .HasColumnName("doan_id")
                        .HasColumnType("int");

                    b.Property<float>("Tongchiphi")
                        .HasColumnName("tongchiphi")
                        .HasColumnType("real");

                    b.HasKey("ChiphiId");

                    b.ToTable("ChiPhis");
                });

            modelBuilder.Entity("tour.Models.ChiTietTours", b =>
                {
                    b.Property<int>("ChitietId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("chitiet_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiadiemId")
                        .HasColumnName("diadiem_id")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("ChitietId");

                    b.ToTable("ChiTietTours");
                });

            modelBuilder.Entity("tour.Models.DiaDiems", b =>
                {
                    b.Property<int>("DiadiemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("diadiem_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnName("mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnName("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thanhpho")
                        .IsRequired()
                        .HasColumnName("thanhpho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiadiemId");

                    b.ToTable("DiaDiems");
                });

            modelBuilder.Entity("tour.Models.Doans", b =>
                {
                    b.Property<int>("DoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("doan_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChiTietChuongTrinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayVe")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnName("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("DoanId");

                    b.ToTable("Doans");
                });

            modelBuilder.Entity("tour.Models.Gias", b =>
                {
                    b.Property<int>("GiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gia_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Denngay")
                        .HasColumnName("denngay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sotien")
                        .HasColumnName("sotien")
                        .HasColumnType("int");

                    b.Property<int?>("ToudId")
                        .IsRequired()
                        .HasColumnName("toud_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tungay")
                        .HasColumnName("tungay")
                        .HasColumnType("datetime2");

                    b.HasKey("GiaId");

                    b.ToTable("Gias");
                });

            modelBuilder.Entity("tour.Models.KhachHangs", b =>
                {
                    b.Property<string>("KhCmnd")
                        .IsRequired()
                        .HasColumnName("kh_cmnd")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<string>("KhEmail")
                        .HasColumnName("kh_email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("kh_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KhNgaysinh")
                        .HasColumnName("kh_ngaysinh")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KhSdt")
                        .IsRequired()
                        .HasColumnName("kh_sdt")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KhTen")
                        .IsRequired()
                        .HasColumnName("kh_ten")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("tour.Models.LoaiChiPhis", b =>
                {
                    b.Property<int>("ChiphiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("chiphi_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .HasColumnName("mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnName("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChiphiId");

                    b.ToTable("LoaiChiPhis");
                });

            modelBuilder.Entity("tour.Models.Loais", b =>
                {
                    b.Property<int>("LoaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("loai_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .HasColumnName("mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnName("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiId");

                    b.ToTable("Loais");
                });

            modelBuilder.Entity("tour.Models.NguoiDis", b =>
                {
                    b.Property<int>("NguoidiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nguoidi_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Danhsachkhach")
                        .HasColumnName("danhsachkhach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Danhsachnhanvien")
                        .HasColumnName("danhsachnhanvien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoanId")
                        .HasColumnName("doan_id")
                        .HasColumnType("int");

                    b.HasKey("NguoidiId");

                    b.ToTable("NguoiDis");
                });

            modelBuilder.Entity("tour.Models.NhanViens", b =>
                {
                    b.Property<string>("NvEmail")
                        .HasColumnName("nv_email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("NvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("nv_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NvNgaysinh")
                        .IsRequired()
                        .HasColumnName("nv_ngaysinh")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("NvNhiemvu")
                        .HasColumnName("nv_nhiemvu")
                        .HasColumnType("int");

                    b.Property<string>("NvSdt")
                        .HasColumnName("nv_sdt")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NvTen")
                        .IsRequired()
                        .HasColumnName("nv_ten")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("tour.Models.Tours", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoaiId")
                        .HasColumnName("loai_id")
                        .HasColumnType("int");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnName("mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnName("ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.ToTable("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}
