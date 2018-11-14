using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer;

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

        public ActionResult<City> Post([FromBody] CreateTodoModel createTodoModel)

        {

            if (createTodoModel == null)

            {

                return BadRequest();

            }



            City todo = new City(createTodoModel.Description, createTodoModel.IsCompleted);

            this._repository.Create(todo);



            return CreatedAtRoute("GetById", new { id = todo.Id }, todo);

        }
    }
}