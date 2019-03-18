﻿using Microsoft.AspNetCore.Mvc;
using SSFleetCommandModels.Enums;
using SSFleetCommandModels.Models;
using System.Collections.Generic;

namespace SSFleetCommandApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        // GET: api/System
        [HttpGet]
        public IEnumerable<DraftStarSystem> Get()
        {
            return new List<DraftStarSystem>();
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
