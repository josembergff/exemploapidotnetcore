using System.Collections.Generic;
using ApiCoreEntity.Models;
using ApiCoreEntity.Services.Inter;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreEntity.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            this._blogService = blogService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return this._blogService.Listar();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return this._blogService.Obter(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Blog value)
        {
            this._blogService.Salvar(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Blog value)
        {
            this._blogService.Atualizar(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._blogService.Deletar(id);
        }
    }
}