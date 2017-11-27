using System.Collections.Generic;
using ApiCoreEntity.Models;

namespace ApiCoreEntity.Services.Inter
{
    public interface IBlogService
    {
        void Salvar(Blog blog);
        Blog Obter(int id);
        IEnumerable<Blog> Listar();

        void Deletar(int id);
        void Atualizar(int id, Blog blog);
    }
}