using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {


        private readonly IRegionRepository regionRepository1;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository1 = regionRepository;
            this.mapper = mapper;
        }

       

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository1.GetAll();

            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region => 
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id= region.Id,
            //        Name = region.Name,
            //        Code= region.Code,
            //        Area= region.Area,
            //        Lat= region.Lat,    
            //        Long= region.Long,
            //        Population= region.Population,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regions);
        }
        
    }
}
