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
using Microsoft.EntityFrameworkCore;
using ViraTestApp.Data;



namespace ViraTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestResultContext _context;
        public HomeController(TestResultContext context)
        {
            _context = context;
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
                                     testindexlist.Add(new TestingResult() { TestCheck1 = ApplicatioName,TestCheck2 = ProjectName, TestCheck3 = TestType });

                                     TestingResult aaa = new TestingResult();
                                     aaa.TestCheck1 = ApplicatioName;
                                     aaa.TestCheck2 = ProjectName;
                                     aaa.TestCheck3 = TestType;

                                      _context.Add(aaa);
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


        public async Task<IActionResult> TestHistory()
        {
            return View(await _context.TestingResult.ToListAsync());
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.TestingResult
                .FirstOrDefaultAsync(m => m.Id == id);
            if (test == null)
            {
                return NotFound();
            }
            return View(test);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var test = await _context.TestingResult.FindAsync(id);
            _context.TestingResult.Remove(test);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(TestHistory));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
