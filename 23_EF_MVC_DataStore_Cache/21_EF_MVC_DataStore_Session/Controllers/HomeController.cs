﻿using Cache_.Models;
using System;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace Cache_.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration=30, VaryByParam = "none")] //Cachuje strony z innym id jako 1
        [OutputCache(Duration = 30, VaryByParam = "id")] //Cachuje strony z innym id osobno
        public ActionResult Index()
        {
            var counters = GetCounters();
            return View(counters);
        }

        [HttpPost]
        public ActionResult IncrementCache(int id = 1)
        {
            var counters = GetCounters();

            // Inkrementuj stan zapisany w Cache
            counters.CacheCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
        }

        private Counters GetCounters()
        {
            var counters = new Counters();

            // Cache
            if (HttpRuntime.Cache["counter"] != null)
            {
                counters.CacheCounter = (int)HttpRuntime.Cache["counter"];
            }
            else
            {
                counters.CacheCounter = 0;
            }

            return counters;
        }

        private void SetCounters(Counters counters)
        {
            HttpRuntime.Cache.Remove("counter");
            HttpRuntime.Cache.Add("counter", counters.CacheCounter, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero, CacheItemPriority.Default, null);
            //HttpRuntime.Cache["counter"] = counters.CacheCounter;
        }

    }
}