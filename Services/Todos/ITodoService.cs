using Core;
using System.Collections.Generic;

namespace Services.Todos
{
    public interface ITodoService
    {
        List<Todo> GetAll();
        Todo GetById(string id);
        Todo Add(Todo todo);
        Todo Update(Todo todo);
        void Delete(string id);
    }
}