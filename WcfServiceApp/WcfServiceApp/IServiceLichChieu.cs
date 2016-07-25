using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLichChieu" in both code and config file together.
    [ServiceContract]
    public interface IServiceLichChieu
    {
        [OperationContract]
        List<LichChieu> DocTatCa();
    }
    [DataContract]
    public class LichChieu
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public System.DateTime Ngay_bat_dau { get; set; }
        [DataMember]
        public System.DateTime Ngay_ket_thuc { get; set; }
        [DataMember]
        public string ThoiGian { get; set; }
    }
}
