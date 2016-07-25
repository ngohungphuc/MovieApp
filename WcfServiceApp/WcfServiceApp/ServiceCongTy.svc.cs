using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCongTy" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCongTy.svc or ServiceCongTy.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCongTy : IServiceCongTy
    {
        WcfDbContext db = new WcfDbContext();
        public CongTy DocTheoId(int id)
        {
            return db.CONG_TY.Where(
                result => result.ID.Equals(id)).
                Select(result1 => new CongTy 
                    { 
                    ID = result1.ID,
                    Ten = result1.Ten,
                    Dia_chi = result1.Dia_chi,
                    Dien_thoai = result1.Dien_thoai,
                    So_tuan_lap_lich = result1.So_tuan_lap_lich
                    }
                ).FirstOrDefault();
        }

        public List<CongTy> DocTatCa()
        {
            return db.CONG_TY.Select(
                result => new CongTy
                {
                    ID = result.ID,
                    Ten = result.Ten,
                    Dia_chi = result.Dia_chi,
                    Dien_thoai = result.Dien_thoai,
                    So_tuan_lap_lich = result.So_tuan_lap_lich
                }).ToList();
          
        }

        public string Them(CONG_TY congty)
        {
            db.CONG_TY.Add(congty);
            db.SaveChanges();
            return "";
          
        }

        public string Sua(CongTy congty)
        {
            var query = db.CONG_TY.Where(result => result.ID.Equals(congty.ID)).FirstOrDefault();
            if (query != null)
            {
                db.CONG_TY.Remove(query);
                CONG_TY cty = new CONG_TY() 
                {
                    Ten=congty.Ten,
                    Dia_chi=congty.Dia_chi,
                    So_tuan_lap_lich=congty.So_tuan_lap_lich,
                    Dien_thoai=congty.Dien_thoai,
                    ID=congty.ID
                };
                db.CONG_TY.Add(cty);
                db.SaveChanges();
                return "";
            }
            else
            {
                return "error";
            }
            
        }

        public string Huy(int id)
        {
            var query = db.CONG_TY.Where(reuslt => reuslt.ID.Equals(id)).FirstOrDefault();
            if (query != null)
            {
                db.CONG_TY.Remove(query);
                db.SaveChanges();
                return "";
            }
            else
            {
                return "Error";
            }
         
          
        }
    }
}
