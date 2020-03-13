using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Data.Todos
{
    public class TodoData : ITodoData
    {
        private List<Todo> todos;

        public TodoData()
        {
            todos = new List<Todo>();
        }

        public List<Todo> GetAllTodos()
        {
            return todos;
        }

        public Todo GetTodoById(Guid id)
        {
            return todos.FirstOrDefault(w=> w.Id==id);
        }

        public Todo AddTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid();
            todo.CreateDateTime = DateTime.Now;
            todo.DateOfLastChange = DateTime.Now;
            todo.Completed = false;
            todos.Add(todo);
            return todo;
        }

        public Todo UpdateTodo(Todo todo)
        {
            var temp = todos.FirstOrDefault(w => w.Id==todo.Id);
            if (temp != null)
            {
                temp.DateOfLastChange = DateTime.Now;
                temp.Completed = todo.Completed;
                temp.Description = todo.Description;
            }
            return temp;
        }

        public void DeleteTodo(Guid id)
        {
            var temp = todos.FirstOrDefault(w => w.Id == id);
            if (temp != null)
                todos.Remove(temp);
        }
    }
}
