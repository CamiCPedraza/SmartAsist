using InsuranceWeb.Models;
using InsuranceWeb.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace InsuranceWeb.Controllers
{
    public class AgentController : Controller
    {
        private readonly ILogger<AgentController> _logger;
        private readonly IAgentService _agentService;

        public AgentController(ILogger<AgentController> logger, IAgentService agentService)
        {
            _logger = logger;
            _agentService = agentService;
        }

        // GET: AgentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AgentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AgentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgentController/Create
        [HttpPost]
        public ActionResult Create(Agent model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _agentService.SaveAgent(model);
                    var list = new List<Agent>();
                    list.Add(new Agent
                    {
                        AccessType = Transversal.AccessType.Administrativo,
                        Address = "Direccion",
                        Commission = "10000",
                        CreatedDate = DateTime.UtcNow,
                        Document = "76544567",
                        DocumentType = Transversal.DocumentType.Cedula,
                        Email = "email@email.com",
                        HasDocuments = false,
                        Id = new Guid(),
                        MarriageState = Transversal.MarriageState.Soltero,
                        Mobile = "55764565",
                        Name = "Name",
                        Ocupation = "NA",
                        Phone = "6576547",
                        Salary = "758658"
                    });
                    return View(nameof(Index), list);
                }
                else
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
