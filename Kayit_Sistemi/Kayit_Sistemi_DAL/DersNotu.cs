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
    
    public partial class DersNotu
    {
        public int DersID { get; set; }
        public int OgrenciID { get; set; }
        public double DersNotu1 { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}