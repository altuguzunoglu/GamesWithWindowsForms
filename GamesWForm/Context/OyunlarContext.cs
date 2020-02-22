using GamesWForm.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWForm.Context
{
    class OyunlarContext : DbContext
    {
        public OyunlarContext() : base("OyunlarContext")
        {

        }
        public DbSet<Oyun> Oyunlar { get; set; }
        public DbSet<OyunTur> OyunTurleri { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Yil> Yillar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyun>().ToTable("Oyun");
            modelBuilder.Entity<OyunTur>().ToTable("OyunTur");
            modelBuilder.Entity<Tur>().ToTable("Tur");
            modelBuilder.Entity<Yil>().ToTable("Yil");

            modelBuilder.Entity<Oyun>().HasKey(s => s.Id);
            modelBuilder.Entity<OyunTur>().HasKey(s => s.Id);
            modelBuilder.Entity<Tur>().HasKey(s => s.Id);
            modelBuilder.Entity<Yil>().HasKey(s => s.Id);

            modelBuilder.Entity<Oyun>().HasKey(o => o.Id)
                .HasMany(o => o.OyunTurleri)
                .WithRequired(ot => ot.Oyun)
                .HasForeignKey(ot => ot.OyunId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Tur>().HasKey(t => t.Id)
                .HasMany(t => t.OyunTurleri)
                .WithRequired(ot => ot.Tur)
                .HasForeignKey(ot => ot.TurId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Yil>().HasKey(y => y.Id)
                .HasMany(y => y.Oyunlar)
                .WithRequired(o => o.Yil)
                .HasForeignKey(o => o.YilId)
                .WillCascadeOnDelete(false);
        }
    }
}
