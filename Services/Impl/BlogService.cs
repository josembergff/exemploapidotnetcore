using System.Collections.Generic;
using System.Linq;
using ApiCoreEntity.Base;
using ApiCoreEntity.Models;
using ApiCoreEntity.Services.Inter;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreEntity.Services.Impl
{
    public class BlogService : IBlogService
    {
        private readonly MyContext _db;

        public BlogService(MyContext db)
        {
            this._db = db;
        }

        public void Atualizar(int id, Blog blog)
        {
            var atual = this._db.Blog.FirstOrDefault(f => f.ID == id);
            if (atual != null)
            {
                this._db.Blog.Attach(atual);
                this._db.Entry(atual).State = EntityState.Modified;
                this._db.SaveChanges();
            }
            else
            {
                throw new System.ApplicationException("Blog não encontrado!");
            }

        }

        public void Deletar(int id)
        {
            var b = new Blog() { ID = id };
            this._db.Blog.Attach(b);
            this._db.Blog.Remove(b);
            this._db.SaveChanges();
        }

        public IEnumerable<Blog> Listar()
        {
            return this._db.Blog.ToList();
        }

        public Blog Obter(int id)
        {
            return this._db.Blog.FirstOrDefault(f => f.ID == id);
        }

        public void Salvar(Blog blog)
        {
            this._db.Blog.Add(blog);
            this._db.SaveChanges();
        }

    }
}