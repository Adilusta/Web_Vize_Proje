using System.Linq;

namespace Web_Vize_Proje.Models
{
    public class EFDuyuruRepository
    {
        private UniWebSiteContext _context;
        public EFDuyuruRepository(UniWebSiteContext context)
        {
            this._context = context;
        }
        public IQueryable<Duyuru> DuyurularıListele()
        {
            var result = _context.Duyurular;
            return result;

        }
    }
}
