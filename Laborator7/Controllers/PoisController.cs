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
    [Route("api/cities/{id}")]
    [ApiController]
    public class PoisController : ControllerBase
    {
        private readonly ICityRepository _repository; 

        public PoisController(ICityRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("/pois")]
        public ActionResult<IReadOnlyList<City>> Get()

        {

            return Ok(_repository.GetAll());

        }

    

        [HttpGet("{poiId}", Name = "GetById")]
        [Route("/pois/{poiId}")]
        public ActionResult<City> Get(Guid poiId)

        {

            return Ok(this._repository.GetById(poiId));

        }

        [HttpPost]
        [Route("/pois")]
        public ActionResult<City> Post([FromBody] CreatePoiModel createTodoModel)

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