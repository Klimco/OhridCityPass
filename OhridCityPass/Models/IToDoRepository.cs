using OhridCityPass.Models;
using System.Collections.Generic;


namespace TodoApi.Models
{
    public interface IToDoRepository
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(string key);
        TodoItem Remove(string key);
        void Update(TodoItem item);
        void Add(TodoItem item);

    }
}