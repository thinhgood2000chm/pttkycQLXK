//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services
{
    using System;
    using System.Collections.Generic;
    
    public partial class XeKhach
    {
        public int stt { get; set; }
        public string MaXe { get; set; }
        public string MaTaiXe { get; set; }
        public string MaHDV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
    }
}