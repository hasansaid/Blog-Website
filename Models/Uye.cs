namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uye")]
    public partial class Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uye()
        {
            Makales = new HashSet<Makale>();
            Yorums = new HashSet<Yorum>();
        }

        public int UyeId { get; set; }

        [StringLength(50)]
        [DisplayName("Kullanıcı Adı")]
        public string KullanıcıAdi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }

        [StringLength(50)]
        [DisplayName("Ad Soyad")]
        public string AdSoyad { get; set; }

        [StringLength(250)]
        [DisplayName("Fotoğraf")]
        public string Foto { get; set; }

        public int? YetkiId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales { get; set; }

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
