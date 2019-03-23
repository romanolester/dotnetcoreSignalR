using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.BLL.Services.Interfaces;

namespace dotnetcodecamp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandidateService _candidateService;

        public HomeController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        public IActionResult Index()
        {
            var candidateInfo = _candidateService.GetCandidateVotes();
            return View(candidateInfo);
        }
    }
}