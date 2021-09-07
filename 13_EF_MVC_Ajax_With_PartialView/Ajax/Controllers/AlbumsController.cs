using Ajax.Infrastructure;
using Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class AlbumsController : Controller
    {
        //[NonAction]
        //[ActionName("Edytuj")]
        public ActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Album newAlbum)
        {
            //return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price));            
            return Json(newAlbum);
        }


	}
}