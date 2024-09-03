using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yarışma.Models;

namespace Yarışma.Areas.Management.Controllers
{
    [Area("Management")]
    public class JudgeCategoriesController : Controller
        
    {
        CompetitionDbContext db = new CompetitionDbContext();

        

        // GET: Management/JudgeCategories
        public async Task<IActionResult> Index()
        {
            var JudgeCategories = db.JudgeCategories.ToList();
            return View(JudgeCategories);

        }

        // GET: Management/JudgeCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            return View();
        }

        // GET: Management/JudgeCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Management/JudgeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       

        // GET: Management/JudgeCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
          
            return View();
        }

        // POST: Management/JudgeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Management/JudgeCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            
           

            return View();
        }

       

        
    }
}
