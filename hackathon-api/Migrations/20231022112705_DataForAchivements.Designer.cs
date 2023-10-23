﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hackathon_api.Data;

#nullable disable

namespace hackathon_api.Migrations
{
    [DbContext(typeof(DBMainContext))]
    [Migration("20231022112705_DataForAchivements")]
    partial class DataForAchivements
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hackathon_api.Models.Achivement", b =>
                {
                    b.Property<long>("AchivementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AchivementId"));

                    b.Property<string>("AchivementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<short>("Points")
                        .HasColumnType("smallint");

                    b.Property<short>("Treashold")
                        .HasColumnType("smallint");

                    b.HasKey("AchivementId");

                    b.ToTable("Achivements");
                });

            modelBuilder.Entity("hackathon_api.Models.Match", b =>
                {
                    b.Property<long>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MatchId"));

                    b.Property<string>("MatchesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("hackathon_api.Models.Ticket", b =>
                {
                    b.Property<long>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TicketID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("FreeBet")
                        .HasColumnType("bit");

                    b.Property<int>("GameType")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceTxId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TicketDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TxId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("hackathon_api.Models.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("hackathon_api.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("BingoBetCount")
                        .HasColumnType("int");

                    b.Property<int>("BingoFreeCount")
                        .HasColumnType("int");

                    b.Property<int>("BingoPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("BingoWinCount")
                        .HasColumnType("int");

                    b.Property<int>("CasinoBetCount")
                        .HasColumnType("int");

                    b.Property<int>("CasinoFreeCount")
                        .HasColumnType("int");

                    b.Property<int>("CasinoPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("CasinoWinCount")
                        .HasColumnType("int");

                    b.Property<int>("CurrentUserPoints")
                        .HasColumnType("int");

                    b.Property<int>("DepositAmount")
                        .HasColumnType("int");

                    b.Property<int>("DepositCumulativeAmount")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("FirstLogin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<int>("LiveBetCount")
                        .HasColumnType("int");

                    b.Property<int>("LiveFreeCount")
                        .HasColumnType("int");

                    b.Property<int>("LivePlayCount")
                        .HasColumnType("int");

                    b.Property<int>("LiveWinCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("PrematchBetCount")
                        .HasColumnType("int");

                    b.Property<int>("PrematchFreeCount")
                        .HasColumnType("int");

                    b.Property<int>("PrematchPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("PrematchWinCount")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("VGBetCount")
                        .HasColumnType("int");

                    b.Property<int>("VGFreeCount")
                        .HasColumnType("int");

                    b.Property<int>("VGPlayCount")
                        .HasColumnType("int");

                    b.Property<int>("VGWinCount")
                        .HasColumnType("int");

                    b.Property<int>("WithdrawalCumulativeAmount")
                        .HasColumnType("int");

                    b.Property<int>("WithdrwalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("hackathon_api.Models.UserAchivement", b =>
                {
                    b.Property<long>("UserAchivementsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserAchivementsId"));

                    b.Property<long?>("AchivementId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAchivementsId");

                    b.HasIndex("AchivementId");

                    b.ToTable("UserAchivements");
                });

            modelBuilder.Entity("hackathon_api.Models.UserAchivement", b =>
                {
                    b.HasOne("hackathon_api.Models.Achivement", "Achivement")
                        .WithMany()
                        .HasForeignKey("AchivementId");

                    b.Navigation("Achivement");
                });
#pragma warning restore 612, 618
        }
    }
}
