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
    
    public partial class tbl_jadwal
    {
        public int id_ta { get; set; }
        public System.DateTime hari { get; set; }
        public System.TimeSpan waktu { get; set; }
        public string ruangan { get; set; }
    
        public virtual tbl_ta tbl_ta { get; set; }
    }
}
