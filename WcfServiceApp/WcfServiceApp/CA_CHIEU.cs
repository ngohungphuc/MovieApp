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
    
    public partial class CA_CHIEU
    {
        public CA_CHIEU()
        {
            this.XUAT_CHIEU = new HashSet<XUAT_CHIEU>();
        }
    
        public int ID { get; set; }
        public int Gio_bat_dau { get; set; }
        public int Phut_bat_dau { get; set; }
        public int So_phut { get; set; }
    
        public virtual ICollection<XUAT_CHIEU> XUAT_CHIEU { get; set; }
    }
}
