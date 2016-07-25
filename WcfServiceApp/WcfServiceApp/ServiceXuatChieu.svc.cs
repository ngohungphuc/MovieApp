using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceXuatChieu" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceXuatChieu.svc or ServiceXuatChieu.svc.cs at the Solution Explorer and start debugging.
    public class ServiceXuatChieu : IServiceXuatChieu
    {
        WcfDbContext db = new WcfDbContext();
        public List<XuatChieu> DocTheoPhim(int id)
        {
            return db.XUAT_CHIEU.Where(xc => xc.ID_PHIM == id).Select(xc => new
            {
                ID = xc.ID,
                Ngay = xc.Ngay,
                xc.CA_CHIEU.Gio_bat_dau,
                xc.CA_CHIEU.Phut_bat_dau,
                Phong = xc.PHONG.Ten
            }).ToArray()
             .Select(vd => new XuatChieu
             {
                 ID = vd.ID,
                 Ngay = vd.Ngay,
                 Ca = vd.Gio_bat_dau.ToString("00") + ":" + vd.Phut_bat_dau.ToString("00"),
                 Phong = vd.Phong
             }).ToList();
        }

        public XuatChieu DocTheoMa(int id)
        {
            return db.XUAT_CHIEU.Where(xc => xc.ID == id).Select(xc => new XuatChieu
            {
                ID = xc.ID,
                Ngay = xc.Ngay,
                Phong = xc.PHONG.Ten
            }).SingleOrDefault();
        }



        public List<Ngay> layngay()
        {
            return db.XUAT_CHIEU.GroupBy(xc => xc.Ngay).Select(xc => new Ngay { ngay = xc.Key }).ToList();
        }
    }
}
