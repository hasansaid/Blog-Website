namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Makale")]
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            Yorums = new HashSet<Yorum>();
            Eikets = new HashSet<Eiket>();
        }

        public int MakaleId { get; set; }

        [StringLength(500)]
        [DisplayName("Baþlýk")]
        public string Baslik { get; set; }
        [UIHint("tinymce_full_compressed"),AllowHtml] // sonradan ekleme

        [StringLength(3000)]
        [DisplayName("Ýçerik")]
        public string Icerik { get; set; }

        [StringLength(500)]
        [DisplayName("Fotoðraf")]
        public string Foto { get; set; }

        public DateTime? Tarih { get; set; }
        [DisplayName("Kategori")]
        public int? KategoriId { get; set; }

        public int? UyeId { get; set; }

        public int? Okunma { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Uye Uye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorums { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eiket> Eikets { get; set; }
    }
}
