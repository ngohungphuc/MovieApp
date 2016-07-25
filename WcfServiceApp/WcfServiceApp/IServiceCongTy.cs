using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCongTy" in both code and config file together.
    [ServiceContract]
    public interface IServiceCongTy
    {
        [OperationContract]
        //[WebGet(UriTemplate = "loadbyid/?id={id}", ResponseFormat = WebMessageFormat.Xml)]
        CongTy DocTheoId(int id);
        [OperationContract]
        //[WebGet(UriTemplate="all",ResponseFormat=WebMessageFormat.Xml)]
        List<CongTy> DocTatCa();
        [OperationContract]
        //[WebInvoke(UriTemplate = "insert",Method="POST", ResponseFormat = WebMessageFormat.Xml,RequestFormat=WebMessageFormat.Xml)]
        string Them(CONG_TY congty);
        [OperationContract]
        //[WebInvoke(UriTemplate = "sua", Method = "PUT", ResponseFormat = WebMessageFormat.Xml)]
        string Sua(CongTy congty);
        [OperationContract]
        //[WebInvoke(UriTemplate = "xoa/?id={id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Xml)]
        string Huy(int id);
    }
    [DataContract]
    public class CongTy
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Ten { get; set; }
        [DataMember]
        public string Dien_thoai { get; set; }
        [DataMember]
        public string Dia_chi { get; set; }
        [DataMember]
        public int So_tuan_lap_lich { get; set; }
    }
}
