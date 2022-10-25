﻿using Microsoft.AspNetCore.Mvc;

namespace Home_Owners_Association_APP.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestRepository repo;

        public RequestController(IRequestRepository repo)
        {
            this.repo = repo;
        }

        //GET: /<controller>/
        public IActionResult Index()
        {
            var requests= repo.GetAllRequests();
            return View(requests);
        }
    }
}