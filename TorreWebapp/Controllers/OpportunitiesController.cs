using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TorreWebapp.Models.JobOpportunity;

namespace TorreWebapp.Controllers
{
    public class OpportunitiesController : Controller
    {
        // GET: Opportunities
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Results(string skill, string organization)
        {
            List<Result> results = null;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://search.torre.co/opportunities/_search/?offset=0&size=100&aggregate=false"))
                {
                    Request search = new Request();
                    if (!String.IsNullOrWhiteSpace(skill))
                    {
                        Skill skillSearch = new Skill();
                        skillSearch.text = skill;
                        skillSearch.experience = "potential-to-develop";
                        search.skill = skillSearch;
                    }
                    if (!string.IsNullOrWhiteSpace(organization))
                    {
                        Organization org = new Organization();
                        org.term = organization;
                        search.organization = org;
                    }
                    request.Content = new StringContent("{\"and\":[" + JsonConvert.SerializeObject(search)+"]}", Encoding.UTF8, "application/json");


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

        // GET: Opportunities/Details/5
        public ActionResult Details(string id)
        {
            JobDetail job = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://torre.co/api/opportunities/" + id);
                //HTTP GET
                var responseTask = client.GetAsync(id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    job = JsonConvert.DeserializeObject<JobDetail>(readTask.Result);
                }
                else //web api sent error response 
                {
                    //log response status here..

                    job = new JobDetail();

                    ModelState.AddModelError("CustomError", "Server error. Please contact administrator.");
                }
            }
            return View(job);
        }

        // GET: Opportunities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opportunities/Create
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

        // GET: Opportunities/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Opportunities/Edit/5
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

        // GET: Opportunities/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Opportunities/Delete/5
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