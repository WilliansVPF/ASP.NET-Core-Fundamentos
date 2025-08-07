namespace TWTodoList.Models;

public class TodoModel
{

    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; }

    public TodoModel(string title, DateTime date, bool isCompleted = false)
    {
        Title = title;
        Date = date;
        IsCompleted = isCompleted;
    }

    public TodoModel(int id, string title, DateTime date, bool isCompleted = false)
    {
        Id = id;
        Title = title;
        Date = date;
        IsCompleted = isCompleted;
    }
}

