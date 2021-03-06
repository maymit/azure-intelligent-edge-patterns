﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailDemo.Infrastructure.Data;

namespace RetailDemo.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RetailDemo.Core.Entities.Body", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyId");

                    b.Property<string>("Dest_img");

                    b.Property<int>("ImageEventId");

                    b.Property<string>("MessageId");

                    b.Property<string>("ModuleId");

                    b.Property<string>("Src_img");

                    b.HasKey("Id");

                    b.HasIndex("ImageEventId")
                        .IsUnique();

                    b.ToTable("Body");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetectionBoxId");

                    b.Property<int?>("DetectionBoxesId");

                    b.Property<double>("Detection_box");

                    b.HasKey("Id");

                    b.HasIndex("DetectionBoxesId");

                    b.ToTable("DetectionBox");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionBoxes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetectionBoxesId");

                    b.Property<int?>("ResultId");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("DetectionBoxes");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetectionClassId");

                    b.Property<int>("Detection_class");

                    b.Property<int?>("ResultId");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("DetectionClass");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetectionScoreId");

                    b.Property<double>("Detection_score");

                    b.Property<int?>("ResultId");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("DetectionScore");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.EdgeDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EdgeDeviceId");

                    b.Property<string>("EdgeDeviceName");

                    b.HasKey("Id");

                    b.ToTable("EdgeDevices");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.ImageEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CaptureTime");

                    b.Property<string>("EdgeDeviceName");

                    b.Property<byte[]>("EncodedImage");

                    b.Property<int>("ImageEventId");

                    b.Property<string>("Name");

                    b.Property<string>("RequestId");

                    b.Property<string>("Source");

                    b.Property<DateTimeOffset>("TimeRecieved");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ImageEvents");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyId");

                    b.Property<int>("Num_detections");

                    b.Property<int>("ResultId");

                    b.HasKey("Id");

                    b.HasIndex("BodyId")
                        .IsUnique();

                    b.ToTable("Result");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Height");

                    b.Property<int>("ResultId");

                    b.Property<int>("SizeId");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.HasIndex("ResultId")
                        .IsUnique();

                    b.ToTable("Size");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.Body", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.ImageEvent", "ImageEvent")
                        .WithOne("Body")
                        .HasForeignKey("RetailDemo.Core.Entities.Body", "ImageEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionBox", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.DetectionBoxes")
                        .WithMany("Detection_boxes")
                        .HasForeignKey("DetectionBoxesId");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionBoxes", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.Result")
                        .WithMany("Detection_boxes")
                        .HasForeignKey("ResultId");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionClass", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.Result")
                        .WithMany("Detection_classes")
                        .HasForeignKey("ResultId");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.DetectionScore", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.Result")
                        .WithMany("Detection_scores")
                        .HasForeignKey("ResultId");
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.Result", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.Body", "Body")
                        .WithOne("Result")
                        .HasForeignKey("RetailDemo.Core.Entities.Result", "BodyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RetailDemo.Core.Entities.Size", b =>
                {
                    b.HasOne("RetailDemo.Core.Entities.Result", "Result")
                        .WithOne("Size")
                        .HasForeignKey("RetailDemo.Core.Entities.Size", "ResultId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
