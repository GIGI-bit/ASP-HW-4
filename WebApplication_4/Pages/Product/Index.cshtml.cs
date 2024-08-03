using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_4.Data;
using WebApplication_4.Entities;
using WebApplication_4.Services;

namespace WebApplication_4.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _service;

        public IndexModel(IProductService service)
        {
            _service = service;
        }

        public List<Entities.Product> Products { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Products = await _service.GetProductsAsync();

            if (id!=null)
            {
                Product = await _service.GetProductByIdAsync(id);
            }

            return Page();
        }

        public string Info { get; set; }

        [BindProperty]
    public Entities.Product  Product { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Product.Id == 0)
            {
                await _service.Create(Product);
            }
            else
            {
                await _service.Update(Product);
            }

            return RedirectToPage();
        }
        public IActionResult OnPostDelete(Entities.Product product)
        {
            _service.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
