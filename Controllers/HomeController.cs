using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ViraTestApp.Models;
using ViraTestApp.TestCases;
using ViraTestApp.Data;

namespace ViraTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestResultContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult HandelForm(Test ApplicatioNames, Test TestTypes, Test ProjectNames)
        {
            string ProjectName = ProjectNames.ProjectName.ToString();
            string TestType = TestTypes.TestType.ToString();
            string ApplicatioName = ApplicatioNames.ApplicatioName.ToString();
            TestCase1 Testobj = new TestCase1();
            switch (ProjectName)
            {
                case "lifeAlborzInsurance":
                {
                    switch (ApplicatioName)
                    {
                        case "AlborzContactManagingDirector":
                        {
                            switch (TestType)
                            {
                                case "AcceptanceTest":
                                     string[] testrepo = Testobj.TestAction1();
                                     IList<TestingResult> testindexlist = new List<TestingResult>();
                                     testindexlist.Add(new TestingResult() { TestCheck1 = testrepo[0],TestCheck2 = testrepo[1], TestCheck3 = testrepo[2] });
                                      _context.Add(testindexlist);
                                      _context.SaveChangesAsync();  
                                     ViewData["testindexlist"] = testindexlist;
                                     return View("TestResult");
                                   
  
                            }
                        }
                            break;
                    }
                    break;
                }
            }
            
            return View("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
