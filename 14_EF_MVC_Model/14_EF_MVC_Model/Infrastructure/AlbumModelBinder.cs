using _14_EF_MVC_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_EF_MVC_Model.Infrastructure
{
    public class AlbumModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            string day = request.Form.Get("Day");
            string month = request.Form.Get("Month");
            string year = request.Form.Get("Year");

            string issuedString = string.Format("Wydano dnia: {0}/{1}/{2}", day, month, year);

            return new Album
            {
                AlbumTitle = request.Form.Get("AlbumTitle"),
                Artist = new Artist() { Name = request.Form.Get("Artist.Name") },
                Price = decimal.Parse(request.Form.Get("Price")),
                DateString = issuedString
            };
        }
    }
}