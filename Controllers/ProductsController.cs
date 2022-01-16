using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ServerApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public ProductsController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // <summary>
        /// Get list of products
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        /// 
        [HttpGet("")]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            var products = from s in _context.Products
                           select s;
            int pageSize;
            int adjecentPagesNum;
            int.TryParse(_configuration["AppSettings:AdjecentPagesNum"], out adjecentPagesNum);
            int.TryParse(_configuration["AppSettings:PageSize"], out pageSize);
            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize, adjecentPagesNum));
        }
    }
}
