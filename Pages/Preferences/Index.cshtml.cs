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
    public class IndexModel : PageModel
    {
        private readonly ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext _context;

        public IndexModel(ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext context)
        {
            _context = context;
        }

        public IList<UserPreferences> UserPreferences { get;set; }

        public async Task OnGetAsync()
        {
            UserPreferences = await _context.UserPreferences.ToListAsync();
        }
    }
}
