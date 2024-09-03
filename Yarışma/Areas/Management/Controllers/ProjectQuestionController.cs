using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yarışma.Models;

namespace Yarışma.Areas.Management.Controllers
{
    [Area("Management")]
    public class ProjectQuestionController : Controller
    {
       CompetitionDbContext db = new CompetitionDbContext();
        // GET: Management/ProjectQuestion
        public async Task<IActionResult> Index()
        {
            var ProjectQuestion =db.ProjectQuestions.ToList();
            return View(ProjectQuestion);
        }

        // GET: Management/ProjectQuestion/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            return View();
        }

        // GET: Management/ProjectQuestion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Management/ProjectQuestion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Management/ProjectQuestion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            return View();
        }

        // POST: Management/ProjectQuestion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        // GET: Management/ProjectQuestion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            

            return View();
        }

        // POST: Management/ProjectQuestion/Delete/5
        

        
    }
}
