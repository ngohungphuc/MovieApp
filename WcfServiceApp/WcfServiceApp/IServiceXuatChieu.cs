using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceXuatChieu" in both code and config file together.
    [ServiceContract]
    public interface IServiceXuatChieu
    {
        [OperationContract]
        List<XuatChieu> DocTheoPhim(int id);
        [OperationContract]
        XuatChieu DocTheoMa(int id);
        [OperationContract]
        List<Ngay> layngay();
    }
    [DataContract]
    public class XuatChieu
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public System.DateTime Ngay { get; set; }
        [DataMember]
        public string Ca { get; set; }
        [DataMember]
        public string Phong { get; set; }
    }
    [DataContract]
    public class Ngay
    {
        [DataMember]
        public System.DateTime ngay { get; set; }
    }
}
