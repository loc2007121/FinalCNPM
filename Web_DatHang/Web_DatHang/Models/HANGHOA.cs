//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_DatHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            this.NHAPKHO_CT = new HashSet<NHAPKHO_CT>();
            this.XUATKHO_CT = new HashSet<XUATKHO_CT>();
        }
    
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string NhaCC { get; set; }
        public string DVT { get; set; }
        public string MaLoai { get; set; }
        public string HinhAnh { get; set; }
    
        public virtual LOAIHANG LOAIHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAPKHO_CT> NHAPKHO_CT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUATKHO_CT> XUATKHO_CT { get; set; }
    }
}
