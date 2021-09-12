using _14_EF_MVC_Model.Infrastructure;
using _14_EF_MVC_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_EF_MVC_Model.Controllers
{
    public class AlbumsController : Controller
    {
        public ActionResult Edit()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult Edit(Album newAlbum)
        //{
        //    return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}, DateString: {3}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price, newAlbum.DateString));
        //}

        //[HttpPost]
        //public ActionResult Edit(decimal price, string albumtitle)
        //{
        //    return Content(string.Format("Title: {0}, Price: {1}", albumtitle, price));
        //}

        //[HttpPost]
        //public ActionResult Edit(FormCollection collection)
        //{
        //   return Content(string.Format("Title: {0}, Price: {1}", collection["albumtitle"], collection["price"]));
        //}

        //[HttpPost]
        //public ActionResult Edit(FormCollection collection)
        //{
        //    Album newAlbum = new Album();
        //    TryUpdateModel(newAlbum);
        //    return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}, DateString: {3}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price, newAlbum.DateString));

        //}

        //[HttpPost]
        //public ActionResult Edit([ModelBinder(typeof(AlbumModelBinder))]Album newAlbum)
        //{
        //    return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}, DateString: {3}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price, newAlbum.DateString));
        //}


        //Inny sposob to dodanie ModelBinder przez Global.asax; Parametr metody edit dodaniu do global.asax Album newAlbum




        //Wykluczenie ktorejs z wartosci
        //[HttpPost]
        //public ActionResult Edit([Bind(Exclude="Price")]Album newAlbum)
        //{
        //    return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}, DateString: {3}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price, newAlbum.DateString));
        //}

        //Inny sposob umieszczenie [Bind(Exclude="Price")] w modelu
        [HttpPost]
        public ActionResult Edit(Album newAlbum)
        {
            return Content(string.Format("Title: {0}, Artist: {1}, Price: {2}, DateString: {3}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price, newAlbum.DateString));
        }

    }
}