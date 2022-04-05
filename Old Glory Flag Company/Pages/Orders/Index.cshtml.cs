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

namespace Old_Glory_Flag_Company.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Old_Glory_Flag_Company.Data.Old_Glory_Flag_CompanyContext _context;

        public IndexModel(Old_Glory_Flag_Company.Data.Old_Glory_Flag_CompanyContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
