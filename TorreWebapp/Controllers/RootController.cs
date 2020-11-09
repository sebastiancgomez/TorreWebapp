﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TorreWebapp.Models;

namespace TorreWebapp.Controllers
{
    public class RootController : Controller
    {
        // GET: Root
        public ActionResult Index()
        {            
            return View();
        }

        // GET: Root/Details/5
        public ActionResult Details(string userName)
        {
            Root root = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://bio.torre.co/api/bios/" + userName);
                //HTTP GET
                var responseTask = client.GetAsync(userName);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    root = JsonConvert.DeserializeObject<Root>(readTask.Result);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    root = new Root();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(root);
        }

        // GET: Root/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Root/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Root/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Root/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Root/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Root/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}