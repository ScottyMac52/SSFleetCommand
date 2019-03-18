using Microsoft.AspNetCore.Mvc;
using SSFleetCommandModels.Enums;
using SSFleetCommandModels.Models;
using SSFleetCommandModels.Util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SSFleetCommandApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        // GET: api/System
        [HttpGet]
        public async Task<IEnumerable<DraftStarSystem>> GetAsync()
        {
            var csvConverter = new CSVConverter<DraftStarSystem>()
            {
                Path = @"C:\Users\Scott\Source\Repos\SSFleetCommand\SSFleetCommand\SSFleetCommandApi\Data\SystemLog.csv",
                SkipLines = 1,
                TakeLines = 1
            };

            var result = await csvConverter.ExecuteAsync();
            return csvConverter.Results;
        }

        // GET: api/System/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/System
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/System/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
