using Fleet_Management_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fleet_Management_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiController: ControllerBase  //controlador para una api rest
    {
        private readonly MyAppDbContext _context;

        public TaxiController(MyAppDbContext context)
        {
            _context = context;
        }

        [HttpGet("/list")]
        public ActionResult<IEnumerable<Taxi>> GetTaxis(int? pageNumber, int? pageSize)
        {
            // Valores predeterminados si los parámetros no se proporcionan
            int currentPageNumber = pageNumber ?? 1;
            int currentPageSize = pageSize ?? 10;

            var taxis = _context.Taxis
                                 .Skip((currentPageNumber - 1) * currentPageSize)
                                 .Take(currentPageSize)
                                 .ToList();
            return Ok(taxis);
        }
    }
}
