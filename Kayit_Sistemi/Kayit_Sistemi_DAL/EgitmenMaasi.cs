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
    
    public partial class EgitmenMaasi
    {
        public int MaasID { get; set; }
        public int EgitmenID { get; set; }
        public long Maas { get; set; }
        public int Yil { get; set; }
    
        public virtual Egitmen Egitmen { get; set; }
    }
}
