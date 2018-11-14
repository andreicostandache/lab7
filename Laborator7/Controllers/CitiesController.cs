using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer;
using Laborator7.Models;

namespace Laborator7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IReadOnlyList<City>> Get()

        {

            return Ok(_repository.GetAll());

        }

    

        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<City> Get(Guid id)

        {

            return Ok(this._repository.GetById(id));

        }

        [HttpPost]

        public ActionResult<City> Post([FromBody] CreateCityModel createTodoModel)

        {

            if (createTodoModel == null)

            {

                return BadRequest();

            }



            City city = new City(createTodoModel.Description);

            this._repository.Create(city);



            return CreatedAtRoute("GetById", new { id = city.Id }, city);

        }
    }
}