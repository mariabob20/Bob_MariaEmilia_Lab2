using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bob_MariaEmilia_Lab2.Data;
using Bob_MariaEmilia_Lab2.Models;

namespace Bob_MariaEmilia_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Bob_MariaEmilia_Lab2.Data.Bob_MariaEmilia_Lab2Context _context;

        public DetailsModel(Bob_MariaEmilia_Lab2.Data.Bob_MariaEmilia_Lab2Context context)
        {
            _context = context;
        }

      public Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
