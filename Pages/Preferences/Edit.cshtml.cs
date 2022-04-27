#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThompsonRazorPagesAzure.Data;
using ThompsonRazorPagesAzure.Models;

namespace ThompsonRazorPagesAzure.Pages.Preferences
{
    public class EditModel : PageModel
    {
        private readonly ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext _context;

        public EditModel(ThompsonRazorPagesAzure.Data.ThompsonRazorPagesAzureContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserPreferences).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPreferencesExists(UserPreferences.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserPreferencesExists(int id)
        {
            return _context.UserPreferences.Any(e => e.Id == id);
        }
    }
}
