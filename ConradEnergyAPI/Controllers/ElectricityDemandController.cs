using AutoMapper;
using ConradEnergy.Core.DTOs;
using ConradEnergy.EFCore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConradEnergyAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ElectricityDemandController : ControllerBase
    {        
        private readonly ConradEnergyContext _context;
        private readonly IMapper _mapper;
        public ElectricityDemandController(ConradEnergyContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }

        /// <summary>
        /// Get electricity demand with date filter
        /// </summary>
        /// <param name="dateFrom">Date from</param>
        /// <param name="dateTo">Date to</param>
        /// <param name="pageSize">Number per page</param>
        /// <param name="currentPage">Current page number</param>
        /// <returns></returns>
        [HttpGet("{dateFrom}/{dateTo}/{pageSize}/{currentPage}")]
        public async Task<IActionResult> Get(DateTime dateFrom, DateTime dateTo, int pageSize, int currentPage)
        {
            var query = _context.ElectricityDemands
                .Where(x => x.SettlementDate >= dateFrom && x.SettlementDate <= dateTo);                

            var totalPages = (int)query.Count() / pageSize;
            var entities = await query.Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var results = _mapper.Map<ElectricityDemandDto[]>(entities);

            return Ok(new DataResultModel<ElectricityDemandDto[]>
            {
                Results = results,
                TotalPages = totalPages,
                CurrentPage = currentPage
            });
        }
    }
}
