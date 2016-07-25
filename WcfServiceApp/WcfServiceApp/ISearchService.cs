using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISearchService" in both code and config file together.
    [ServiceContract]
    public interface ISearchService
    {
        [OperationContract]
        List<Phim> DocTatCa();
        [OperationContract]
        List<string> DocTheLoai();
        [OperationContract]
        List<Phim> DocPhimTheoTheLoai(string theloai);
    }
    [DataContract]
    public class Phim{
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Ten { get; set; }
        [DataMember]
        public string Dao_dien { get; set; }
        [DataMember]
        public string Dien_vien { get; set; }

    }
}
