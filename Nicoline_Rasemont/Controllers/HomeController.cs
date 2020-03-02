using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nicoline_Rasemont.Models;
using Nicoline_Rasemont.ViewModels;

namespace Nicoline_Rasemont.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validator()
        {
            ValidatorViewModel vm = new ValidatorViewModel();
            return View(vm);
        }
        public IActionResult Checksum()
        {
            ChecksumViewModel vm = new ChecksumViewModel();
            return View(vm);
        }

        public IActionResult InstructieSet()
        {
            InstructiesetViewModel vm = new InstructiesetViewModel();
            return View(vm);
        }

        public IActionResult StreamProcessing()
        {
            StreamProcessingViewModel vm = new StreamProcessingViewModel();
            return View(vm);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
