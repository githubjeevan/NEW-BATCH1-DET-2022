﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.SqlClient;

namespace NEW_BATCH1_DET_2022.Models
{
    public partial class tsql_trainingContext : DbContext
    {
        public tsql_trainingContext()
        {
        }

        public tsql_trainingContext(DbContextOptions<tsql_trainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=H985T72-SHEL\\SQLEXPRESS;Database=tsql_training;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("EMP_PRIMARY_KEY");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("date")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");

                entity.HasOne(d => d.MgrNavigation)
                    .WithMany(p => p.InverseMgrNavigation)
                    .HasForeignKey(d => d.Mgr)
                    .HasConstraintName("EMP_SELF_KEY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
