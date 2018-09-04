﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volvox.Helios.Service;

namespace Volvox.Helios.Service.Migrations
{
    [DbContext(typeof(VolvoxHeliosContext))]
    partial class VolvoxHeliosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupPlayerRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<Guid?>("LookingForGroupSessionId");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("LookingForGroupSessionId");

                    b.ToTable("LookingForGroupPlayerRole","lfg");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupPlayerRoleMap", b =>
                {
                    b.Property<Guid>("PlayerRoleId");

                    b.Property<Guid>("SessionId");

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("PlayerRoleId", "SessionId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("SessionId");

                    b.ToTable("LookingForGroupPlayerRoleMap","lfg");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupRoleRestriction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<Guid?>("LookingForGroupSessionId");

                    b.Property<decimal>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<Guid>("SessionId");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("LookingForGroupSessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("LookingForGroupRoleRestriction","lfg");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("HasMaximumCapacity");

                    b.Property<int>("MaximumMembers");

                    b.Property<string>("ShortIdentifyer");

                    b.Property<string>("Title");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("GuildId");

                    b.ToTable("LookingForGroupSessions","lfg");

                    b.HasData(
                        new { Id = new Guid("62aa88a8-b7e1-4b9d-8802-5bdec352660c"), Description = "Test LFG for things and whatnot", GuildId = 486220073933996043m, HasMaximumCapacity = true, MaximumMembers = 24, ShortIdentifyer = "TLG", Title = "Test LFG" }
                    );
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.HasKey("GuildId");

                    b.ToTable("LookingForGroupSettings","lfg");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.StreamAnnouncerSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("AnnouncementChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<bool>("RemoveMessages");

                    b.HasKey("GuildId");

                    b.ToTable("StreamAnnouncerSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.StreamerRoleSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<decimal>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("GuildId");

                    b.ToTable("StreamerRoleSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupPlayerRole", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession")
                        .WithMany("PlayerRoles")
                        .HasForeignKey("LookingForGroupSessionId");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupPlayerRoleMap", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupPlayerRole")
                        .WithMany()
                        .HasForeignKey("PlayerRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupRoleRestriction", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession")
                        .WithMany("RoleRestrictions")
                        .HasForeignKey("LookingForGroupSessionId");

                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSession", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.LookingForGroupSettings")
                        .WithMany("Sessions")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
