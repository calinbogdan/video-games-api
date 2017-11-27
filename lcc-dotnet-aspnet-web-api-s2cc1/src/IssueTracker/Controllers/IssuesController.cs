using IssueTrackerShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace IssueTracker.Controllers
{
    public class IssuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Issue> Get()
        {
            var department = new Department();
            department.Id = 1;
            department.Name = "Bugs";
            return new List<Issue>()
            {
                new Issue(2017, 1, 2, "Invalid things here", "calin.bogdan15@gmail.com", department, "Some weird shit is going on around here"),
                new Issue(2017, 1, 3, "Invalid things here too", "calin.bogdan15@outlook.com", department, "Some weird shit is going on around here BOI")
            };
        }

        [HttpGet]
        public Issue Get(int id)
        {
            return null;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }


    }
}