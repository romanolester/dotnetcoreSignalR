﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.DAL.Context;

namespace Web.DAL.Migrations
{
    [DbContext(typeof(VoteDbContext))]
    [Migration("20190323062150_candidatevotesview")]
    partial class candidatevotesview
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.DTO.CandidateVote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anime");

                    b.Property<string>("Bio");

                    b.Property<string>("Name");

                    b.Property<string>("ProfilePhoto");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("CandidateVotes");
                });

            modelBuilder.Entity("Web.Models.Entities.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anime");

                    b.Property<string>("Bio");

                    b.Property<string>("Name");

                    b.Property<string>("ProfilePhoto");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Web.Models.Entities.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CandidateId");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Web.Models.Entities.Vote", b =>
                {
                    b.HasOne("Web.Models.Entities.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
