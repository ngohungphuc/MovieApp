using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCaChieu" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCaChieu.svc or ServiceCaChieu.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCaChieu : IServiceCaChieu
    {
        WcfDbContext db = new WcfDbContext();
        public List<CaChieu> xuatCaChieu()
        {
            return db.CA_CHIEU.Select(result => new CaChieu
            {
                ID = result.ID,
                Gio_bat_dau=result.Gio_bat_dau,
                Phut_bat_dau=result.Phut_bat_dau,
                So_phut=result.So_phut
            }).ToList();
        }
    }
}
