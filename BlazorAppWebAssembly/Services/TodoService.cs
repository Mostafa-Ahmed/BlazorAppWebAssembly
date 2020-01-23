using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppWebAssembly.Models;

namespace BlazorAppWebAssembly.Services
{
    public class TodoService
    {
        private static int ID { get; set; } = 1;
        private static List<Todo> Todos { get; set; }
        public static List<Todo> GetTodos()
        {
            return Todos;
        }
        public void AddTodo(Todo todo)
        {
            todo.Id = ID;
            Todos.Add(todo);
            ID += 1;
        }
        public void UpdateTodo(Todo todo)
        {
            Todos[todo.Id] = todo;
        }
    }
}
