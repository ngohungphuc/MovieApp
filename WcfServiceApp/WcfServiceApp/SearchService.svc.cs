using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SearchService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SearchService.svc or SearchService.svc.cs at the Solution Explorer and start debugging.
    public class SearchService : ISearchService
    {
        WcfDbContext db = new WcfDbContext();
        public List<Phim> DocTatCa()
        {
            return db.PHIMs.Select(result => new Phim
            {
                ID = result.ID,
                Ten = result.Ten,
                Dao_dien = result.Dao_dien,
                Dien_vien = result.Dien_vien
            }).ToList();
        }

        public List<string> DocTheLoai()
        {
            return db.PHIMs.Select(result => result.The_loai).ToList();
            
        }

        public List<Phim> DocPhimTheoTheLoai(string theloai)
        {
            return db.PHIMs.Where(result => result.The_loai.Equals(theloai)).Select(result1 => new Phim {
                ID = result1.ID,
                Ten = result1.Ten,
                Dao_dien = result1.Dao_dien,
                Dien_vien = result1.Dien_vien
            }).ToList();
        }
    }
}
