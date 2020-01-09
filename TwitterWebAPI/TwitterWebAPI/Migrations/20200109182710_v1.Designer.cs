﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterWebAPI.Models;

namespace TwitterWebAPI.Migrations
{
    [DbContext(typeof(TwitterAPIContext))]
    [Migration("20200109182710_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TwitterWebAPI.Models.Tweet", b =>
                {
                    b.Property<int>("tweetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tweetContent")
                        .HasColumnType("nvarchar(280)");

                    b.Property<DateTime>("tweetDate")
                        .HasColumnType("smalldatetime");

                    b.Property<int?>("userIdFk");

                    b.HasKey("tweetId");

                    b.HasIndex("userIdFk");

                    b.ToTable("Tweets");
                });

            modelBuilder.Entity("TwitterWebAPI.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("userSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwitterWebAPI.Models.Tweet", b =>
                {
                    b.HasOne("TwitterWebAPI.Models.User", "User")
                        .WithMany("Tweets")
                        .HasForeignKey("userIdFk");
                });
#pragma warning restore 612, 618
        }
    }
}
