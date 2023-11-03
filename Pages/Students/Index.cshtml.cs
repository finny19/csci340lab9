using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SillyGooseSchool.Data;
using SillyGooseSchool.Models;

namespace SillyGooseSchool.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SillyGooseSchool.Data.SchoolContext _context;

        public IndexModel(SillyGooseSchool.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
