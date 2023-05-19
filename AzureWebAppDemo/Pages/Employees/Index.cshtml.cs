using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureWebAppDemo.Data;
using AzureWebAppDemo.Entities;

namespace AzureWebAppDemo.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly AzureWebAppDemo.Data.AzureAppDbContext _context;

        public IndexModel(AzureWebAppDemo.Data.AzureAppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees.ToListAsync();
            }
        }
    }
}
