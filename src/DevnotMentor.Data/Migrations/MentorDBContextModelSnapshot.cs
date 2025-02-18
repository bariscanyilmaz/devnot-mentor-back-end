﻿// <auto-generated />
using System;
using DevnotMentor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevnotMentor.Data.Migrations
{
    [DbContext(typeof(MentorDBContext))]
    partial class MentorDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevnotMentor.Data.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppliedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.LinkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseLink")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("HasUsername")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LinkTypes");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Message")
                        .HasMaxLength(2000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Mentees");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.Property<int?>("MentorQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorQuestionId");

                    b.ToTable("MenteeAnswers");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("LinkTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkTypeId");

                    b.HasIndex("MenteeId");

                    b.ToTable("MenteeLinks");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("TagId");

                    b.ToTable("MenteeTags");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("LinkTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkTypeId");

                    b.HasIndex("MentorId");

                    b.ToTable("MentorLinks");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionNotes")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("QuestionText")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("QuestionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MentorId");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("MentorQuestions");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MentorId");

                    b.HasIndex("TagId");

                    b.ToTable("MentorTags");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentorship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("MenteeComment")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<int?>("MenteeId")
                        .HasColumnType("int");

                    b.Property<byte?>("MenteeScore")
                        .HasColumnType("tinyint");

                    b.Property<string>("MentorComment")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<int?>("MentorId")
                        .HasColumnType("int");

                    b.Property<byte?>("MentorScore")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("datetime");

                    b.Property<int?>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId");

                    b.ToTable("Mentorships");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("ProfileImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nchar(500)")
                        .IsFixedLength(true);

                    b.Property<string>("ProfileUrl")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("SecurityKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("SecurityKeyExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SurName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Token")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("TokenExpireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("UserNameConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("UserState")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Application", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentee", "Mentee")
                        .WithMany("Applications")
                        .HasForeignKey("MenteeId")
                        .HasConstraintName("FK_MentorApplications_Mentee");

                    b.HasOne("DevnotMentor.Data.Entities.Mentor", "Mentor")
                        .WithMany("Applications")
                        .HasForeignKey("MentorId")
                        .HasConstraintName("FK_MentorApplications_Mentor");

                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentee", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.User", "User")
                        .WithMany("Mentee")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Mentee_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeAnswer", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentee", "Mentee")
                        .WithMany("MenteeAnswers")
                        .HasForeignKey("MenteeId")
                        .HasConstraintName("FK_MenteeAnswers_Mentee");

                    b.HasOne("DevnotMentor.Data.Entities.MentorQuestion", "MentorQuestion")
                        .WithMany("MenteeAnswers")
                        .HasForeignKey("MentorQuestionId")
                        .HasConstraintName("FK_MenteeAnswers_MentorQuestion");

                    b.Navigation("Mentee");

                    b.Navigation("MentorQuestion");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeLink", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.LinkType", "LinkType")
                        .WithMany("MenteeLinks")
                        .HasForeignKey("LinkTypeId")
                        .HasConstraintName("FK_MenteeLinks_LinkType");

                    b.HasOne("DevnotMentor.Data.Entities.Mentee", "Mentee")
                        .WithMany("MenteeLinks")
                        .HasForeignKey("MenteeId")
                        .HasConstraintName("FK_MenteeLinks_Mentee");

                    b.Navigation("LinkType");

                    b.Navigation("Mentee");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MenteeTag", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentee", "Mentee")
                        .WithMany("MenteeTags")
                        .HasForeignKey("MenteeId")
                        .HasConstraintName("FK_MenteeTags_Mentee");

                    b.HasOne("DevnotMentor.Data.Entities.Tag", "Tag")
                        .WithMany("MenteeTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_MenteeTags_Tag");

                    b.Navigation("Mentee");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentor", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.User", "User")
                        .WithMany("Mentor")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Mentor_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorLink", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.LinkType", "LinkType")
                        .WithMany("MentorLinks")
                        .HasForeignKey("LinkTypeId")
                        .HasConstraintName("FK_MentorLinks_LinkType");

                    b.HasOne("DevnotMentor.Data.Entities.Mentor", "Mentor")
                        .WithMany("MentorLinks")
                        .HasForeignKey("MentorId")
                        .HasConstraintName("FK_MentorLinks_Mentor");

                    b.Navigation("LinkType");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorQuestion", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentor", "Mentor")
                        .WithMany("MentorQuestion")
                        .HasForeignKey("MentorId")
                        .HasConstraintName("FK_MentorQuestion_Mentor");

                    b.HasOne("DevnotMentor.Data.Entities.QuestionType", "QuestionType")
                        .WithMany("MentorQuestion")
                        .HasForeignKey("QuestionTypeId")
                        .HasConstraintName("FK_MentorQuestion_QuestionType");

                    b.Navigation("Mentor");

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorTag", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentor", "Mentor")
                        .WithMany("MentorTags")
                        .HasForeignKey("MentorId")
                        .HasConstraintName("FK_MentorTags_Mentor");

                    b.HasOne("DevnotMentor.Data.Entities.Tag", "Tag")
                        .WithMany("MentorTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_MentorTags_Tag");

                    b.Navigation("Mentor");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentorship", b =>
                {
                    b.HasOne("DevnotMentor.Data.Entities.Mentee", "Mentee")
                        .WithMany("Mentorships")
                        .HasForeignKey("MenteeId")
                        .HasConstraintName("FK_Mentorships_Mentee");

                    b.HasOne("DevnotMentor.Data.Entities.Mentor", "Mentor")
                        .WithMany("Mentorships")
                        .HasForeignKey("MentorId")
                        .HasConstraintName("FK_Mentorships_Mentor");

                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.LinkType", b =>
                {
                    b.Navigation("MenteeLinks");

                    b.Navigation("MentorLinks");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentee", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("MenteeAnswers");

                    b.Navigation("MenteeLinks");

                    b.Navigation("MenteeTags");

                    b.Navigation("Mentorships");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Mentor", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("MentorLinks");

                    b.Navigation("MentorQuestion");

                    b.Navigation("Mentorships");

                    b.Navigation("MentorTags");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.MentorQuestion", b =>
                {
                    b.Navigation("MenteeAnswers");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.QuestionType", b =>
                {
                    b.Navigation("MentorQuestion");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.Tag", b =>
                {
                    b.Navigation("MenteeTags");

                    b.Navigation("MentorTags");
                });

            modelBuilder.Entity("DevnotMentor.Data.Entities.User", b =>
                {
                    b.Navigation("Mentee");

                    b.Navigation("Mentor");
                });
#pragma warning restore 612, 618
        }
    }
}
