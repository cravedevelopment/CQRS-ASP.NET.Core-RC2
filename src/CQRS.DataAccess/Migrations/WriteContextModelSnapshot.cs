﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CQRS.DataAccess;

namespace CQRS.DataAccess.Migrations
{
    [DbContext(typeof(WriteContext))]
    partial class WriteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CQRS.Contracts.Events.ItemBaseEvent", b =>
                {
                    b.Property<Guid>("AggregateId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("AggregateId");

                    b.ToTable("ItemEvents");
                });
        }
    }
}