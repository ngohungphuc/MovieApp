using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceMovies" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceMovies.svc or ServiceMovies.svc.cs at the Solution Explorer and start debugging.
    public class ServiceMovies : IServiceMovies
    {
        WcfDbContext db = new WcfDbContext();
        public List<Phim> DocTheoLich(int id)
        {
            return db.BAO_GOM.Where(bg => bg.ID_LICH_CHIEU == id)
               .Select(bg => new Phim
               {
                   ID = bg.ID_PHIM,
                   Ten = bg.PHIM.Ten
               }).ToList();
        }





        public List<PHIM_ALL> Doctheocachieu(DateTime ngaychon, int id_cachon)
        {
            var dsphim = db.XUAT_CHIEU.Where(xc => xc.Ngay == ngaychon && xc.ID_CA_CHIEU == id_cachon)
                    .Select(p => p.PHIM).ToList().Select(vd => new PHIM_ALL
                    {
                        ID = vd.ID,
                        Ten = vd.Ten,
                        Dao_dien = vd.Dao_dien,
                        Dien_vien = vd.Dien_vien,
                        The_loai = vd.The_loai,
                        Phien_ban = vd.Phien_ban,
                        Hang_phim = vd.Hang_phim,
                        Nuoc_san_xuat = vd.Nuoc_san_xuat,
                        Do_dai = vd.Do_dai,
                        Poster = @"\Posters\" + vd.Poster,
                        Gioi_thieu = vd.Gioi_thieu,
                        Trailer = @"\Trailers\" + vd.Trailer,
                        PDF = @"\PDF\" +vd.PDF
                    }).ToList();

            return dsphim;
        }
    }
}
