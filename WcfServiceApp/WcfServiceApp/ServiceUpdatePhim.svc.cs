using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUpdatePhim" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUpdatePhim.svc or ServiceUpdatePhim.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUpdatePhim : IServiceUpdatePhim
    {

        WcfDbContext db = new WcfDbContext();
        public string capNhatPhim(PHIM phim)
        {
            var query = db.PHIMs.Where(result => result.ID.Equals(phim.ID)).FirstOrDefault();
            if (query != null)
            {
                query.Ten = phim.Ten;
                query.Dao_dien = phim.Dao_dien;
                query.Dien_vien = phim.Dien_vien;
                query.The_loai = phim.The_loai;
                query.Phien_ban = phim.Phien_ban;
                query.Hang_phim = phim.Hang_phim;
                query.Nuoc_san_xuat = phim.Nuoc_san_xuat;
                query.Do_dai = phim.Do_dai;
                query.Gioi_thieu = phim.Gioi_thieu;
                db.SaveChanges();
                return "";
            }
            else
            {
                return "error";
            }
        }
        
      
    }
}
