using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TorreWebapp.Models;

namespace TorreWebapp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Root
        public ActionResult Index()
        {            
            return View();
        }

        // GET: Root/Details/5
        public ActionResult Details(string userName)
        {
            PersonResult root = null;

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

                    root = JsonConvert.DeserializeObject<PersonResult>(readTask.Result);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    root = new PersonResult();

                    ModelState.AddModelError("CustomError", "Server error. Please contact administrator.");
                    return View("Index");
                }
            }
            return View(root);
        }
        public ActionResult Results(string name, string skill, string organization)
        {
            List<Result> results = null;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://search.torre.co/people/_search/?page=0&periodicity=hourly&lang=es&aggregate=false&offset=0&size=100"))
                {
                    Request search = new Request();
                    if (!String.IsNullOrWhiteSpace(skill))
                    {
                        Models.JobOpportunity.Skill skillSearch = new Models.JobOpportunity.Skill();
                        skillSearch.text = skill;
                        skillSearch.experience = "1-plus-year";
                        search.skill = skillSearch;
                    }
                    if (!string.IsNullOrWhiteSpace(organization))
                    {
                        Organization org = new Organization();
                        org.term = organization;
                        search.organization = org;
                    }
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        Name nameObj = new Name();
                        nameObj.term = name;
                        search.name = nameObj;
                    }
                    request.Content = new StringContent("{\"and\":["+JsonConvert.SerializeObject(search)+"]}", Encoding.UTF8, "application/json");


                    var response = httpClient.SendAsync(request);
                    response.Wait();
                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        results = JsonConvert.DeserializeObject<Response>(readTask.Result).results;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        results = new List<Result>();

                        ModelState.AddModelError("CustomError", "Server error. Please contact administrator.");
                        return View("Index");
                    }


                }
            }
            return View(results);
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