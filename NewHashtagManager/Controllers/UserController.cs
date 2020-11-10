using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewHashtagManager.Domain.DTO;
using NewHashtagManager.Domain.Entities.Models;
using NewHashtagManager.Domain.Repository;

namespace NewHashtagManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBaseRepository<User> _repo;
        private readonly IMapper _mapper;
        public UserController(IBaseRepository<User> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        /// <summary>
        /// Devuelve una lista con todos los usuarios
        /// </summary>
        /// <returns></returns>
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var output = _mapper.Map<IEnumerable<UserDTO>>(_repo.GetAll());
            return new OkObjectResult(output);
        }

        /// <summary>
        /// Busca un usuario por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var output = _mapper.Map<UserDTO>(_repo.GetById(id));
            
            return new OkObjectResult(output);
        }

        /// <summary>
        /// Crea un usuario nuevo
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post(User user)
        {
            _repo.Add(user);
            _repo.Save();
            return new CreatedResult(user.Id.ToString(), user);
        }

        /// <summary>
        /// No hace nada
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Elimina un usuario mediante su ID
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_repo.GetById(id) == null)
                return NotFound();
            _repo.Delete(id);
            _repo.Save();
            return new OkResult();
        }
    }
}