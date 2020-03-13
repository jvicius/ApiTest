using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Data.Todos
{
    public interface ITodoData
    {
        List<Todo> GetAllTodos();
        Todo GetTodoById(Guid id);
        Todo AddTodo(Todo todo);
        Todo UpdateTodo(Todo todo);
        void DeleteTodo(Guid id);
    }
}
