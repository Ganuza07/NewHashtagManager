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
    public class PosteoController : ControllerBase
    {
        private readonly IBaseRepository<Posteo> _repo;
        private readonly IMapper _mapper;

        public PosteoController(IBaseRepository<Posteo> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        /// <summary>
        /// Devuelve una lista con todos los posts
        /// </summary>
        /// <returns></returns>
        // GET: api/<PostController>
        [HttpGet]
        public IActionResult Get()
        {
            var test = _mapper.Map<IEnumerable<PosteoDTO>>(_repo.GetAll());
            return new OkObjectResult(test);
        }

        /// <summary>
        /// Devuelve los post que contengan la keyword
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns>Lista de 0 o mas posts</returns>
        // GET api/<PostController>/5
        [HttpGet("{keyWord}")]
        public IActionResult Get(string keyWord) // was IEnumerable
        {
            var output = _mapper.Map<IEnumerable<PosteoDTO>>(_repo.GetQuery(x => x.TextPost.Contains(keyWord)));
            return new OkObjectResult(output);
        }

        /// <summary>
        /// Crea un post nuevo usando el ID de un usuario
        /// </summary>
        /// <param name="posteo"></param>
        /// <returns></returns>
        // POST api/<PostController>
        [HttpPost]
        public IActionResult Post(Posteo posteo)
        {
            _repo.Add(posteo);
            _repo.Save();
            return new CreatedResult(posteo.Id.ToString(), posteo);
        }
        
        /// <summary>
        /// No hace nada
        /// </summary>
        /// <param name="post"></param>
        // PUT api/<PostController>/5
        [HttpPut("{id}")]
        public void Put(Posteo post)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Elimina un post nediante su ID
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_repo.GetById(id) == null)
                return new NotFoundResult();
            _repo.Delete(id);
            _repo.Save();
            return new OkResult();
        }
    }
}