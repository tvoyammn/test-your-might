﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestYourMight.Data;

namespace TestYourMight.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestYourMight.Data.Models.Deal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gameID")
                        .HasColumnType("int");

                    b.Property<bool>("isReal")
                        .HasColumnType("bit");

                    b.Property<string>("mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gameID");

                    b.ToTable("AllDeals");
                });

            modelBuilder.Entity("TestYourMight.Data.Models.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gameImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gameName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AllGames");
                });

            modelBuilder.Entity("TestYourMight.Data.Models.Deal", b =>
                {
                    b.HasOne("TestYourMight.Data.Models.Game", "Game")
                        .WithMany("dealList")
                        .HasForeignKey("gameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
