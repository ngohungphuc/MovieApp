using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceMovies" in both code and config file together.
    [ServiceContract]
    public interface IServiceMovies
    {
        [OperationContract]
        List<Phim> DocTheoLich(int id);
        [OperationContract]
        List<PHIM_ALL> Doctheocachieu(DateTime ngaychon, int id_cachon);
    }
    [DataContract]
    public class PHIM_ALL
    {
        [DataMember]
        public int ID { get; set; }
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
        public string Poster { get; set; }
        [DataMember]
        public string Gioi_thieu { get; set; }
        [DataMember]
        public string Trailer { get; set; }
        [DataMember]
        public string PDF { get; set; }
    }
   
}
