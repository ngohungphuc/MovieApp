using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDangNhap" in both code and config file together.
    [ServiceContract]
    public interface IServiceDangNhap
    {
        [OperationContract]
        NguoiDung dangnhap(string username,string password);
        [OperationContract]
        string dangky(string username, string password);
        [OperationContract]
        List<NguoiDung> lietke();
    }
    [DataContract]
    public class NguoiDung
    {
        [DataMember]
        public string Ten { get; set; }
        [DataMember]
        public string Mat_khau { get; set; }
        [DataMember]
        public int ID_NHOM_NGUOI_DUNG { get; set; }
    }
}
