using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUpdatePhim" in both code and config file together.
    [ServiceContract]
    public interface IServiceUpdatePhim
    {
        [OperationContract]
        string capNhatPhim(PHIM phim);
    }
    [DataContract]
    public class Phim_Moi
    {
            [DataMember]
            public string Ten { get; set; }
            [DataMember]
            public string Dao_dien { get; set; }
            [DataMember]
            public string Dien_vien { get; set; }
            [DataMember]
            public string The_loai { get; set; }
            [DataMember]
            public string Phien_ban { get; set; }
            [DataMember]
            public string Hang_phim { get; set; }
            [DataMember]
            public string Nuoc_san_xuat { get; set; }
            [DataMember]
            public int Do_dai { get; set; }
            [DataMember]
            public string Gioi_thieu { get; set; }
    }
    
}
