//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class NGUOI_DUNG
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Mat_khau { get; set; }
        public int ID_NHOM_NGUOI_DUNG { get; set; }
    
        public virtual NHOM_NGUOI_DUNG NHOM_NGUOI_DUNG { get; set; }
    }
}
