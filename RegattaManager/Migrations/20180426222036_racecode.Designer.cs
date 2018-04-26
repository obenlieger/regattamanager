﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RegattaManager.Data;
using System;

namespace RegattaManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180426222036_racecode")]
    partial class racecode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RegattaManager.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RegattaManager.Models.Boatclass", b =>
                {
                    b.Property<int>("BoatclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Seats");

                    b.HasKey("BoatclassId");

                    b.ToTable("Boatclasses");
                });

            modelBuilder.Entity("RegattaManager.Models.CampingFee", b =>
                {
                    b.Property<int>("CampingFeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<string>("Name");

                    b.HasKey("CampingFeeId");

                    b.ToTable("CampingFees");
                });

            modelBuilder.Entity("RegattaManager.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("VNr");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("RegattaManager.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoatclassId");

                    b.Property<int>("RaceclassId");

                    b.HasKey("CompetitionId");

                    b.HasIndex("BoatclassId");

                    b.HasIndex("RaceclassId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("RegattaManager.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Birthyear");

                    b.Property<int>("ClubId");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("RentYear");

                    b.Property<int>("RentedToClubId");

                    b.Property<bool>("isRented");

                    b.HasKey("MemberId");

                    b.HasIndex("ClubId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("RegattaManager.Models.Oldclass", b =>
                {
                    b.Property<int>("OldclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromAge");

                    b.Property<string>("Name");

                    b.Property<int>("ToAge");

                    b.HasKey("OldclassId");

                    b.ToTable("Oldclasses");
                });

            modelBuilder.Entity("RegattaManager.Models.Race", b =>
                {
                    b.Property<int>("RaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoatclassId");

                    b.Property<string>("Comment");

                    b.Property<int>("FinishType");

                    b.Property<string>("Gender");

                    b.Property<int>("OldclassId");

                    b.Property<string>("RaceCode");

                    b.Property<int>("RaceTypId");

                    b.Property<int>("RaceclassId");

                    b.Property<int>("RacestatusId");

                    b.Property<DateTime>("Realstarttime");

                    b.Property<int>("RegattaId");

                    b.Property<DateTime>("Starttime");

                    b.HasKey("RaceId");

                    b.HasIndex("BoatclassId");

                    b.HasIndex("OldclassId");

                    b.HasIndex("RaceTypId");

                    b.HasIndex("RaceclassId");

                    b.HasIndex("RacestatusId");

                    b.HasIndex("RegattaId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("RegattaManager.Models.Raceclass", b =>
                {
                    b.Property<int>("RaceclassId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Length");

                    b.Property<string>("Name");

                    b.HasKey("RaceclassId");

                    b.ToTable("Raceclasses");
                });

            modelBuilder.Entity("RegattaManager.Models.RaceDraw", b =>
                {
                    b.Property<int>("RaceDrawId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EndlaufCount");

                    b.Property<int>("HoffnungslaufCount");

                    b.Property<int>("ReportedSBCountFrom");

                    b.Property<int>("ReportedSBCountTo");

                    b.Property<int>("VorlaufCount");

                    b.Property<int>("ZwischenlaufCount");

                    b.HasKey("RaceDrawId");

                    b.ToTable("RaceDraws");
                });

            modelBuilder.Entity("RegattaManager.Models.RaceDrawRules", b =>
                {
                    b.Property<int>("RaceDrawRuleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlacementFrom");

                    b.Property<int>("PlacementTo");

                    b.Property<int>("RaceDrawId");

                    b.Property<int>("RaceSequence");

                    b.Property<int>("RaceTypId");

                    b.Property<int>("ToRaceSequence");

                    b.Property<int>("ToRaceTypId");

                    b.HasKey("RaceDrawRuleId");

                    b.HasIndex("RaceDrawId");

                    b.HasIndex("RaceTypId");

                    b.ToTable("RaceDrawRules");
                });

            modelBuilder.Entity("RegattaManager.Models.Racestatus", b =>
                {
                    b.Property<int>("RacestatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("RacestatusId");

                    b.ToTable("Racestati");
                });

            modelBuilder.Entity("RegattaManager.Models.RaceTyp", b =>
                {
                    b.Property<int>("RaceTypId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isFinal");

                    b.HasKey("RaceTypId");

                    b.ToTable("RaceTyps");
                });

            modelBuilder.Entity("RegattaManager.Models.Regatta", b =>
                {
                    b.Property<int>("RegattaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Accomodation");

                    b.Property<string>("Awards");

                    b.Property<string>("Catering");

                    b.Property<bool>("Choosen");

                    b.Property<int>("ClubId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Judge");

                    b.Property<string>("Name");

                    b.Property<string>("ReportAddress");

                    b.Property<string>("ReportFax");

                    b.Property<string>("ReportMail");

                    b.Property<DateTime>("ReportOpening");

                    b.Property<DateTime>("ReportSchedule");

                    b.Property<string>("ReportTel");

                    b.Property<string>("ReportText");

                    b.Property<string>("ScheduleText");

                    b.Property<string>("Security");

                    b.Property<int>("Startslots");

                    b.Property<float>("SubscriberFee");

                    b.Property<DateTime>("ToDate");

                    b.Property<int>("WaterId");

                    b.Property<int>("Waterdepth");

                    b.HasKey("RegattaId");

                    b.HasIndex("ClubId");

                    b.HasIndex("WaterId");

                    b.ToTable("Regattas");
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaCampingFee", b =>
                {
                    b.Property<int>("CampingFeeId");

                    b.Property<int>("RegattaId");

                    b.HasKey("CampingFeeId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaCampingFees");
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaCompetition", b =>
                {
                    b.Property<int>("CompetitionId");

                    b.Property<int>("RegattaId");

                    b.HasKey("CompetitionId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaCompetitions");
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaOldclass", b =>
                {
                    b.Property<int>("OldclassId");

                    b.Property<int>("RegattaId");

                    b.HasKey("OldclassId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaOldclasses");
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaStartingFee", b =>
                {
                    b.Property<int>("StartingFeeId");

                    b.Property<int>("RegattaId");

                    b.HasKey("StartingFeeId", "RegattaId");

                    b.HasIndex("RegattaId");

                    b.ToTable("RegattaStartingFees");
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedRace", b =>
                {
                    b.Property<int>("ReportedRaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompetitionId");

                    b.Property<string>("Gender");

                    b.Property<int>("OldclassId");

                    b.Property<string>("RaceCode");

                    b.Property<int>("RegattaId");

                    b.HasKey("ReportedRaceId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("OldclassId");

                    b.HasIndex("RegattaId");

                    b.ToTable("ReportedRaces");
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboat", b =>
                {
                    b.Property<int>("ReportedStartboatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubId");

                    b.Property<int?>("CompetitionId");

                    b.Property<string>("Gender");

                    b.Property<int>("RegattaId");

                    b.Property<int>("ReportedRaceId");

                    b.HasKey("ReportedStartboatId");

                    b.HasIndex("ClubId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("RegattaId");

                    b.HasIndex("ReportedRaceId");

                    b.ToTable("ReportedStartboats");
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboatMember", b =>
                {
                    b.Property<int>("ReportedStartboatId");

                    b.Property<int>("MemberId");

                    b.Property<int>("Seatnumber");

                    b.HasKey("ReportedStartboatId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ReportedStartboatMembers");
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboatStandby", b =>
                {
                    b.Property<int>("ReportedStartboatId");

                    b.Property<int>("MemberId");

                    b.Property<int>("Standbynumber");

                    b.HasKey("ReportedStartboatId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ReportedStartboatStandbys");
                });

            modelBuilder.Entity("RegattaManager.Models.Startboat", b =>
                {
                    b.Property<int>("StartboatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubId");

                    b.Property<DateTime>("FinishTime");

                    b.Property<int>("Placement");

                    b.Property<int>("RaceId");

                    b.Property<int>("RegattaId");

                    b.Property<int>("StartboatstatusId");

                    b.Property<int>("Startslot");

                    b.HasKey("StartboatId");

                    b.HasIndex("ClubId");

                    b.HasIndex("RaceId");

                    b.HasIndex("RegattaId");

                    b.HasIndex("StartboatstatusId");

                    b.ToTable("Startboats");
                });

            modelBuilder.Entity("RegattaManager.Models.StartboatMember", b =>
                {
                    b.Property<int>("StartboatId");

                    b.Property<int>("MemberId");

                    b.Property<int>("SeatNumber");

                    b.Property<int>("StartboatMemberId");

                    b.HasKey("StartboatId", "MemberId");

                    b.HasAlternateKey("StartboatMemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("StartboatMembers");
                });

            modelBuilder.Entity("RegattaManager.Models.Startboatstatus", b =>
                {
                    b.Property<int>("StartboatstatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("StartboatstatusId");

                    b.ToTable("Startboatstati");
                });

            modelBuilder.Entity("RegattaManager.Models.StartingFee", b =>
                {
                    b.Property<int>("StartingFeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<int>("BoatclassId");

                    b.Property<int>("OldclassId");

                    b.HasKey("StartingFeeId");

                    b.HasIndex("BoatclassId");

                    b.HasIndex("OldclassId");

                    b.ToTable("StartingFees");
                });

            modelBuilder.Entity("RegattaManager.Models.Water", b =>
                {
                    b.Property<int>("WaterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("WaterId");

                    b.ToTable("Waters");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RegattaManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RegattaManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RegattaManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.Competition", b =>
                {
                    b.HasOne("RegattaManager.Models.Boatclass", "Boatclasses")
                        .WithMany("Competitions")
                        .HasForeignKey("BoatclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Raceclass", "Raceclasses")
                        .WithMany("Competitions")
                        .HasForeignKey("RaceclassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.Member", b =>
                {
                    b.HasOne("RegattaManager.Models.Club", "Club")
                        .WithMany("Members")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.Race", b =>
                {
                    b.HasOne("RegattaManager.Models.Boatclass", "Boatclass")
                        .WithMany("Races")
                        .HasForeignKey("BoatclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Oldclass", "Oldclass")
                        .WithMany("Races")
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.RaceTyp", "RaceTyp")
                        .WithMany()
                        .HasForeignKey("RaceTypId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Raceclass", "Raceclass")
                        .WithMany("Races")
                        .HasForeignKey("RaceclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Racestatus", "Racestatus")
                        .WithMany("Races")
                        .HasForeignKey("RacestatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Regatta", "Regatta")
                        .WithMany("Races")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.RaceDrawRules", b =>
                {
                    b.HasOne("RegattaManager.Models.RaceDraw", "RaceDraw")
                        .WithMany("RaceDrawRules")
                        .HasForeignKey("RaceDrawId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.RaceTyp", "RaceTyp")
                        .WithMany("RaceDrawRules")
                        .HasForeignKey("RaceTypId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.Regatta", b =>
                {
                    b.HasOne("RegattaManager.Models.Club", "Club")
                        .WithMany("Regatten")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Water", "Waters")
                        .WithMany()
                        .HasForeignKey("WaterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaCampingFee", b =>
                {
                    b.HasOne("RegattaManager.Models.CampingFee", "CampingFees")
                        .WithMany("RegattaCampingFees")
                        .HasForeignKey("CampingFeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.Regatta", "Regattas")
                        .WithMany("RegattaCampingFees")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaCompetition", b =>
                {
                    b.HasOne("RegattaManager.Models.Competition", "Competitions")
                        .WithMany("RegattaCompetitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.Regatta", "Regattas")
                        .WithMany("RegattaCompetitions")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaOldclass", b =>
                {
                    b.HasOne("RegattaManager.Models.Oldclass", "Oldclasses")
                        .WithMany("RegattaOldclasses")
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.Regatta", "Regattas")
                        .WithMany("RegattaOldclasses")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.RegattaStartingFee", b =>
                {
                    b.HasOne("RegattaManager.Models.Regatta", "Regattas")
                        .WithMany("RegattaStartingFees")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.StartingFee", "StartingFees")
                        .WithMany("RegattaStartingFees")
                        .HasForeignKey("StartingFeeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedRace", b =>
                {
                    b.HasOne("RegattaManager.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Oldclass", "Oldclass")
                        .WithMany("ReportedRaces")
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Regatta", "Regatta")
                        .WithMany()
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboat", b =>
                {
                    b.HasOne("RegattaManager.Models.Club", "Club")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Competition")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("CompetitionId");

                    b.HasOne("RegattaManager.Models.Regatta", "Regatta")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.ReportedRace", "ReportedRace")
                        .WithMany("ReportedStartboats")
                        .HasForeignKey("ReportedRaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboatMember", b =>
                {
                    b.HasOne("RegattaManager.Models.Member", "Member")
                        .WithMany("ReportedStartboatMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.ReportedStartboat", "ReportedStartboat")
                        .WithMany("ReportedStartboatMembers")
                        .HasForeignKey("ReportedStartboatId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.ReportedStartboatStandby", b =>
                {
                    b.HasOne("RegattaManager.Models.Member", "Member")
                        .WithMany("ReportedStartboatStandbys")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.ReportedStartboat", "ReportedStartboat")
                        .WithMany("ReportedStartboatStandbys")
                        .HasForeignKey("ReportedStartboatId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.Startboat", b =>
                {
                    b.HasOne("RegattaManager.Models.Club", "Club")
                        .WithMany("Startboats")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Race", "Race")
                        .WithMany("Startboats")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.Regatta", "Regatta")
                        .WithMany("Startboats")
                        .HasForeignKey("RegattaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("RegattaManager.Models.Startboatstatus", "Startboatstatus")
                        .WithMany("Startboats")
                        .HasForeignKey("StartboatstatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RegattaManager.Models.StartboatMember", b =>
                {
                    b.HasOne("RegattaManager.Models.Member", "Member")
                        .WithMany("StartboatMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Startboat", "Startboat")
                        .WithMany("StartboatMembers")
                        .HasForeignKey("StartboatId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RegattaManager.Models.StartingFee", b =>
                {
                    b.HasOne("RegattaManager.Models.Boatclass", "Boatclasses")
                        .WithMany()
                        .HasForeignKey("BoatclassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RegattaManager.Models.Oldclass", "Oldclasses")
                        .WithMany()
                        .HasForeignKey("OldclassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
