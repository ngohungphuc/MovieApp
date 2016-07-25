using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCaChieu" in both code and config file together.
    [ServiceContract]
    public interface IServiceCaChieu
    {
        [OperationContract]
        List<CaChieu> xuatCaChieu();
        
    }
    [DataContract]
    public class CaChieu
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int Gio_bat_dau { get; set; }
        [DataMember]
        public int Phut_bat_dau { get; set; }
        [DataMember]
        public int So_phut { get; set; }
    }
}
