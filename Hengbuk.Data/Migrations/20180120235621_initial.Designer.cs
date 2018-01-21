﻿// <auto-generated />
using Hengbuk.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Hengbuk.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180120235621_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Hengbuk.Data.Models.Question", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created");

                    b.Property<string>("createdby");

                    b.Property<DateTime>("modified");

                    b.Property<string>("modifiedby");

                    b.Property<string>("text");

                    b.HasKey("id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Hengbuk.Data.Models.Setting", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created");

                    b.Property<string>("createdby");

                    b.Property<string>("key");

                    b.Property<DateTime>("modified");

                    b.Property<string>("modifiedby");

                    b.Property<long>("userid");

                    b.Property<string>("value");

                    b.HasKey("id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Hengbuk.Data.Models.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created");

                    b.Property<string>("createdby");

                    b.Property<DateTime>("modified");

                    b.Property<string>("modifiedby");

                    b.Property<string>("name");

                    b.Property<string>("username");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hengbuk.Data.Models.UserResponse", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created");

                    b.Property<string>("createdby");

                    b.Property<DateTime>("modified");

                    b.Property<string>("modifiedby");

                    b.Property<long>("total");

                    b.Property<long>("userid");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Hengbuk.Data.Models.UserResponseLines", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("answer");

                    b.Property<DateTime>("created");

                    b.Property<string>("createdby");

                    b.Property<DateTime>("modified");

                    b.Property<string>("modifiedby");

                    b.Property<long>("questionid");

                    b.Property<long>("userresponseid");

                    b.HasKey("id");

                    b.HasIndex("questionid");

                    b.HasIndex("userresponseid");

                    b.ToTable("ResponseLines");
                });

            modelBuilder.Entity("Hengbuk.Data.Models.UserResponse", b =>
                {
                    b.HasOne("Hengbuk.Data.Models.User")
                        .WithMany("responses")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hengbuk.Data.Models.UserResponseLines", b =>
                {
                    b.HasOne("Hengbuk.Data.Models.Question", "question")
                        .WithMany()
                        .HasForeignKey("questionid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hengbuk.Data.Models.UserResponse")
                        .WithMany("answers")
                        .HasForeignKey("userresponseid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
