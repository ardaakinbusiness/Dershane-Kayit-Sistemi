//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kayit_Sistemi_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.DersNotu = new HashSet<DersNotu>();
        }
    
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string TC { get; set; }
        public string CepTelefonu { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public int KursID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DersNotu> DersNotu { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kurs Kurs { get; set; }
    }
}
