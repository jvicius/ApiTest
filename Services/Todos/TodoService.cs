using System;
using System.Collections.Generic;
using Core;
using Data.Todos;

namespace Services.Todos
{
    public class TodoService : ITodoService
    {
        private ITodoData _todoData;

        public TodoService()
        {
            _todoData = new TodoData();
        }

        public List<Todo> GetAll()
        {
            return _todoData.GetAllTodos();
        }

        public Todo GetById(string id)
        {
            return _todoData.GetTodoById(new Guid(id));
        }

        public Todo Add(Todo todo)
        {
            return _todoData.AddTodo(todo);
        }

        public Todo Update(Todo todo)
        {
            return _todoData.UpdateTodo(todo);
        }

        public void Delete(string id)
        {
            _todoData.DeleteTodo(new Guid(id));
        }
    }
}