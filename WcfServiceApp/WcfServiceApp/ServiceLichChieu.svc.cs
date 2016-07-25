using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLichChieu" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceLichChieu.svc or ServiceLichChieu.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLichChieu : IServiceLichChieu
    {
        WcfDbContext db = new WcfDbContext();
        public List<LichChieu> DocTatCa()
        {
            return db.LICH_CHIEU.Select(lc => new
            {
               id= lc.ID,
               bd= lc.Ngay_bat_dau,
               kt= lc.Ngay_ket_thuc
            }).ToArray().Select(result => new LichChieu
            {
                ID = result.id,
                Ngay_bat_dau = result.bd,
                Ngay_ket_thuc = result.kt,
                ThoiGian = result.bd.ToString("dd/MM/yyyy") + " - " + result.kt.ToString("dd/MM/yyyy")
            }).ToList();
        }
    }
}
