using TWTodoList.Models;

namespace TWTodoList.ViewModels;

public class ListTodoViewModel
{
    public ICollection<TodoModel> Todos { get; set; } = new List<TodoModel>();
}