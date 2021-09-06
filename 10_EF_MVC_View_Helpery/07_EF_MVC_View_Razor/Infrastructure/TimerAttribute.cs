using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerActionParameters.Infrastructure
{
    public class TimerAttribute : ActionFilterAttribute
    {
        public TimerAttribute()
        {
            // Powinniśmy być ostatnim filtrem – tuż przed akcją
            this.Order = int.MaxValue;
        }

        private Stopwatch _stopWatch;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.Controller;
            if (controller != null)
            {
                var stopwatch = new Stopwatch();
                _stopWatch = stopwatch;
                stopwatch.Start();
            }
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.Controller;
            if (controller != null)
            {
                var stopwatch = (Stopwatch)_stopWatch;

                stopwatch.Stop();
                controller.ViewBag._Duration = stopwatch.Elapsed.TotalMilliseconds;
            }
        }
    }
}