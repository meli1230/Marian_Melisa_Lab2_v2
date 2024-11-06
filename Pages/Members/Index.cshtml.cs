using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marian_Melisa_Lab2.Data;
using Marian_Melisa_Lab2.Models;

namespace Marian_Melisa_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Marian_Melisa_Lab2.Data.Marian_Melisa_Lab2Context _context;

        public IndexModel(Marian_Melisa_Lab2.Data.Marian_Melisa_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
