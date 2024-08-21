using CC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CC1.Controllers
{
    [RoutePrefix("api/country")]
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "Delhi" },
            new Country { ID = 2, CountryName = "UK", Capital = "London" },
            new Country { ID = 3, CountryName = "France", Capital = "Paris" }
        };

        // GET: api/Country
        public IHttpActionResult GetCountries()
        {
            return Ok(countries);
        }

        // GET: api/Country/5
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country
        public IHttpActionResult PostCountry(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            country.ID = countries.Max(c => c.ID) + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT: api/Country/5
        public IHttpActionResult PutCountry(int id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCountry = countries.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Country/5
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);
            return Ok(country);
        }
    }
}


