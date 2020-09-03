﻿// <auto-generated />
using System;
using MakerTracker.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace MakerTracker.Migrations
{
    [DbContext(typeof(MakerTrackerContext))]
    partial class MakerTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakerTracker.DBModels.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ModelNumber")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ProfileId");

                    b.ToTable("MakerEquipment");
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpectedFinished")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("PromisedCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProfileId");

                    b.ToTable("MakerOrders");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Need", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FulfilledDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SpecialInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Need");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructionUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeprecated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MakerTracker.DBModels.ProductRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChildId")
                        .HasColumnType("int");

                    b.Property<int>("ChildQuantityRequired")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductRequirement");
                });

            modelBuilder.Entity("MakerTracker.DBModels.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Other",
                            SortOrder = 9999
                        },
                        new
                        {
                            Id = 2,
                            Name = "Face Shield",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mask",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ventilator",
                            SortOrder = 10
                        },
                        new
                        {
                            Id = 5,
                            Name = "Intubation Box",
                            SortOrder = 15
                        },
                        new
                        {
                            Id = 6,
                            Name = "Supplies",
                            SortOrder = 20
                        },
                        new
                        {
                            Id = 7,
                            Name = "Materials",
                            SortOrder = 25
                        });
                });

            modelBuilder.Entity("MakerTracker.DBModels.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Auth0Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasCadSkills")
                        .HasColumnType("bit");

                    b.Property<bool>("HasOnboarded")
                        .HasColumnType("bit");

                    b.Property<string>("ImportId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsDropOffPoint")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequestor")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSelfQuarantined")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSupplier")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("MakerTracker.DBModels.ProfileHierarchy", b =>
                {
                    b.Property<int>("ParentProfileId")
                        .HasColumnType("int");

                    b.Property<int>("ChildProfileId")
                        .HasColumnType("int");

                    b.Property<bool>("ParentIsOwner")
                        .HasColumnType("bit");

                    b.HasKey("ParentProfileId", "ChildProfileId");

                    b.HasIndex("ChildProfileId");

                    b.ToTable("ProfileHierarchy");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FromId")
                        .HasColumnType("int");

                    b.Property<int?>("NeedId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("ToId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("NeedId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ToId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Feedback", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerEquipment", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Equipment", "Equipment")
                        .WithMany("UsedBy")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakerTracker.DBModels.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MakerTracker.DBModels.MakerOrder", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany("InMakerQueues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakerTracker.DBModels.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.Need", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany("NeedRequests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakerTracker.DBModels.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MakerTracker.DBModels.Product", b =>
                {
                    b.HasOne("MakerTracker.DBModels.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MakerTracker.DBModels.ProductRequirement", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Product", "Child")
                        .WithMany("UsedInProducts")
                        .HasForeignKey("ChildId");

                    b.HasOne("MakerTracker.DBModels.Product", "Parent")
                        .WithMany("PrecursorsRequired")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("MakerTracker.DBModels.ProfileHierarchy", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Profile", "ChildProfile")
                        .WithMany("Parents")
                        .HasForeignKey("ChildProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MakerTracker.DBModels.Profile", "ParentProfile")
                        .WithMany("Children")
                        .HasForeignKey("ParentProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MakerTracker.DBModels.Transaction", b =>
                {
                    b.HasOne("MakerTracker.DBModels.Profile", "From")
                        .WithMany("TransactionFrom")
                        .HasForeignKey("FromId");

                    b.HasOne("MakerTracker.DBModels.Need", "Need")
                        .WithMany("Transactions")
                        .HasForeignKey("NeedId");

                    b.HasOne("MakerTracker.DBModels.Product", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("ProductId");

                    b.HasOne("MakerTracker.DBModels.Profile", "To")
                        .WithMany("TransactionTo")
                        .HasForeignKey("ToId");
                });
#pragma warning restore 612, 618
        }
    }
}
