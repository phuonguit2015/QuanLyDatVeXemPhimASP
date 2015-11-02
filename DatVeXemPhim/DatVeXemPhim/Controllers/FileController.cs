using DatVeXemPhim.Data_Access_Layer;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class FileController : Controller
    {
        private CinemaContext db = new CinemaContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}