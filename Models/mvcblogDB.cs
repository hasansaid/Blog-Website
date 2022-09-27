namespace MvcBlog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mvcblogDB : DbContext
    {
        public mvcblogDB()
            : base("name=mvcblogDB")
        {
        }

        public virtual DbSet<Eiket> Eikets { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Makale> Makales { get; set; }
        public virtual DbSet<Uye> Uyes { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }
        public virtual DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eiket>()
                .Property(e => e.EtiketAdi)
                .IsFixedLength();

            modelBuilder.Entity<Eiket>()
                .HasMany(e => e.Makales)
                .WithMany(e => e.Eikets)
                .Map(m => m.ToTable("MakaleEtiket").MapLeftKey("EtiketId").MapRightKey("MakaleId"));

            modelBuilder.Entity<Kategori>()
                .Property(e => e.KategoriAdi)
                .IsFixedLength();

            modelBuilder.Entity<Makale>()
                .Property(e => e.Baslik)
                .IsFixedLength();

            modelBuilder.Entity<Makale>()
                .Property(e => e.Icerik)
                .IsFixedLength();

            modelBuilder.Entity<Makale>()
                .Property(e => e.Foto)
                .IsFixedLength();

            modelBuilder.Entity<Yetki>()
                .Property(e => e.Yetki1)
                .IsFixedLength();

            modelBuilder.Entity<Yorum>()
                .Property(e => e.İcerik)
                .IsFixedLength();
        }
    }
}
