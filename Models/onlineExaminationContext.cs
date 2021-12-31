using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace oe.Models
{
    public partial class onlineExaminationContext : DbContext
    {
        public onlineExaminationContext()
        {
        }

        public onlineExaminationContext(DbContextOptions<onlineExaminationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Longquestion> Longquestions { get; set; }
        public virtual DbSet<Shortquestion> Shortquestions { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=onlineExamination;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Longquestion>(entity =>
            {
                entity.ToTable("longquestion");

                entity.Property(e => e.LongquestionId).HasColumnName("longquestion_id");

                entity.Property(e => e.ExamId).HasColumnName("exam_id");

                entity.Property(e => e.Longanswer)
                    .HasMaxLength(50)
                    .HasColumnName("longanswer");

                entity.Property(e => e.Longanswerupload)
                    .HasMaxLength(50)
                    .HasColumnName("longanswerupload");

                entity.Property(e => e.LongquestionText)
                    .HasMaxLength(50)
                    .HasColumnName("longquestion_text");
            });

            modelBuilder.Entity<Shortquestion>(entity =>
            {
                entity.ToTable("shortquestion");

                entity.Property(e => e.ShortquestionId).HasColumnName("shortquestion_id");

                entity.Property(e => e.ExamId).HasColumnName("exam_id");

                entity.Property(e => e.Shortanswer)
                    .HasMaxLength(50)
                    .HasColumnName("shortanswer");

                entity.Property(e => e.Shortanswerupload)
                    .HasMaxLength(50)
                    .HasColumnName("shortanswerupload");

                entity.Property(e => e.ShortquestionText)
                    .HasMaxLength(50)
                    .HasColumnName("shortquestion_text");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuId)
                    .HasName("PK__student__E53CAB215430B9A8");

                entity.ToTable("student");

                entity.Property(e => e.StuId).HasColumnName("stu_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.StuImage).HasColumnName("stu_image");

                entity.Property(e => e.StuName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("stu_name");

                entity.Property(e => e.StuPassword)
                    .HasMaxLength(20)
                    .HasColumnName("stu_password");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
