#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThompsonRazorPagesAzure.Data;
using ThompsonRazorPagesAzure.Models;

namespace ThompsonRazorPagesAzure.Pages.Preferences
{
    public class DetailsModel : PageModel
    {
        private readonly ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext _context;

        public DetailsModel(ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext context)
        {
            _context = context;
        }

        public UserPreferences UserPreferences { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserPreferences = await _context.UserPreferences.FirstOrDefaultAsync(m => m.Id == id);

            if (UserPreferences == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
