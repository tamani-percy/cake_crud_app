using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using redisTest.Data;
using redisTest.Data.Entities;
using redisTest.Vms;
using Microsoft.EntityFrameworkCore;
namespace redisTest.Pages.Cakes
{
    public class EditModel : PageModel
    {
        private readonly MyDbContext _myDbContext;
        public EditModel(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [BindProperty]
        public CakeVm? CakeVm { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            CakeVm = await _myDbContext.Cake
                    .Where(_ => _.Id == id)
                    .Select(_ => new CakeVm
                    {
                        Description = _.Description,
                        Id = _.Id,
                        Name = _.Name,
                        Price = _.Price
                    }).FirstOrDefaultAsync();
            if (CakeVm == null)
            {
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var cakeToUpdate = await _myDbContext.Cake.FindAsync(id);

            if (cakeToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Cake> (
                cakeToUpdate,
                "CakeVm",
                c => c.Name, c => c.Description, c => c.Price
                ))
            {
                await _myDbContext.SaveChangesAsync();
                return Redirect("home");
            }

            return Page();
        }
    }
}
