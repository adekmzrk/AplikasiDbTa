//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aplikasiDbTa
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ta()
        {
            this.tbl_jadwal = new HashSet<tbl_jadwal>();
        }
    
        public int id_ta { get; set; }
        public string judul_ta { get; set; }
        public string pembimbing { get; set; }
        public string penguji1 { get; set; }
        public string penguji2 { get; set; }
        public string npm { get; set; }
    
        public virtual tbl_dosen tbl_dosen { get; set; }
        public virtual tbl_dosen tbl_dosen1 { get; set; }
        public virtual tbl_dosen tbl_dosen2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_jadwal> tbl_jadwal { get; set; }
        public virtual tbl_mhs tbl_mhs { get; set; }
    }
}