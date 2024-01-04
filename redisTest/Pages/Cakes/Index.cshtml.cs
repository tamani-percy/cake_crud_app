using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using redisTest.Data.Entities;
using Microsoft.EntityFrameworkCore;
using redisTest.Data;

namespace redisTest.Pages.Cakes
{
    public class IndexModel : PageModel
    {

        private readonly MyDbContext _myDbContext;
        public IndexModel(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public List<Cake> AllCakes = new List<Cake>();

        public async Task<IActionResult> OnGetAsync()
        {
            AllCakes = await _myDbContext.Cake.ToListAsync();
            return Page();
        }
        
    }
}
