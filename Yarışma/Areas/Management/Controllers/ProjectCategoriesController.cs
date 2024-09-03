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
    public class ProjectCategoriesController : Controller
    {
        
       CompetitionDbContext db = new CompetitionDbContext();

        // GET: Management/ProjectCategories
        public async Task<IActionResult> Index()
        {
            var ProjectCategories = db.ProjectCategories.ToList();
            return View(ProjectCategories);
        }

        // GET: Management/ProjectCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           

            return View();
        }

        // GET: Management/ProjectCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Management/ProjectCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Management/ProjectCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            
            return View();
        }

        // POST: Management/ProjectCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        

        // GET: Management/ProjectCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            

            return View();
        }

        
    }
}
