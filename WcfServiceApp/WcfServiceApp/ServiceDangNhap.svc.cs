using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDangNhap" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDangNhap.svc or ServiceDangNhap.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDangNhap : IServiceDangNhap
    {
        WcfDbContext db = new WcfDbContext();
        public NguoiDung dangnhap(string username, string password)
        {

            return db.NGUOI_DUNG.Where(result => result.Ten == username && result.Mat_khau == password).Select(result => new NguoiDung
            {
                ID_NHOM_NGUOI_DUNG=result.ID_NHOM_NGUOI_DUNG,
                Ten=result.Ten,
                Mat_khau=result.Mat_khau
            }).FirstOrDefault();
        }

        public string dangky(string username, string password)
        {
            var check_user = db.NGUOI_DUNG.Count(result => result.Ten.Equals(username));
            if (check_user==0)
            {
                NGUOI_DUNG new_user = new NGUOI_DUNG
                {
                    ID_NHOM_NGUOI_DUNG = 1,
                    Ten = username,
                    Mat_khau = password
                };
    
                db.NGUOI_DUNG.Add(new_user);
                db.SaveChanges();
                return "Them thanh cong";
            }
            else
            {
                return "Them ko thanh cong";
            }




        }

        public List<NguoiDung> lietke()
        {
            return db.NGUOI_DUNG.Select(result => new NguoiDung
            {
                ID_NHOM_NGUOI_DUNG = result.ID_NHOM_NGUOI_DUNG,
                Ten = result.Ten,
                Mat_khau = result.Mat_khau
            }).ToList();
        }
    }
}
