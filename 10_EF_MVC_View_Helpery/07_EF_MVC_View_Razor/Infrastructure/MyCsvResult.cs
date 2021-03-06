using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ControllerActionParameters.Infrastructure
{
    public class MyCsvResult : ActionResult
    {

        public string Content
        {
            get;
            set;
        }

        public Encoding ContentEncoding
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public MyCsvResult(string content)
        {
            this.Content = content;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;

            response.ContentType = "text/csv";

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            var fileName = "file.csv";

            if (!String.IsNullOrEmpty(Name))
            {
                fileName = Name.Contains('.') ? Name : Name + ".csv";
            }

            response.AddHeader("Content-Disposition",
                String.Format("attachment; filename={0}", fileName));

            if (Content != null)
            {
                response.Write(Content);
            }
        }
    }
}