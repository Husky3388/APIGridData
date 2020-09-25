using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGridData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIGridData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        // GET: api/Records
        [HttpGet]
        public ActionResult Get()
        {
            //string json = JsonConvert.SerializeObject(Data.records, Formatting.Indented);
            //return json;
            return Ok(Data.records);
        }

        // GET: api/Records/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            Record getRecord = Data.records.FirstOrDefault(x => x.id == id);
            string json = JsonConvert.SerializeObject(getRecord, Formatting.Indented);
            return json;
        }

        // GET: api/Records/test
        [HttpGet]
        [Route("search")]
        public ActionResult Search([FromQuery]string name)
        {
            List<Record> searchedRecords = Data.records.Where(x => x.name.Contains(name)).ToList();
            return Ok(searchedRecords);
        }

        // POST: api/Records
        [HttpPost]
        public ActionResult Post([FromBody] Record value)
        {
            Data.InsertData(value);
            return Ok(value);
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Record value)
        {
            Data.UpdateData(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Data.DeleteData(id);
        }
    }
}
