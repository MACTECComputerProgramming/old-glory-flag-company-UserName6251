#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Old_Glory_Flag_Company.Data;
using Old_Glory_Flag_Company.Models;

namespace Old_Glory_Flag_Company.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Old_Glory_Flag_Company.Data.Old_Glory_Flag_CompanyContext _context;

        public DetailsModel(Old_Glory_Flag_Company.Data.Old_Glory_Flag_CompanyContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
