//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doan1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDon
    {
        public string MaMon { get; set; }
        public string MaHD { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> Gia { get; set; }
        public string Size { get; set; }
        public string Da { get; set; }
        public string Duong { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual Menu Menu1 { get; set; }
    }
}
