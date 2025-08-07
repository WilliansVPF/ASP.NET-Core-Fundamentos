using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;
using TWTodoList.ViewModels;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        // ViewData["apresentacao"] = "Olá TreinaWeb";
        // ViewData.Add("apresentacao", "Olá Mundo");
        var todo = new Todo
        {
            Titulo = "Estudar ASP .NET Core",
            Descricao = "Concluir o curso de ASP.NET Core da Treina Web"
        };

        ViewData["todo"] = todo;

        ViewBag.Todo = todo;

        TempData["mensagem"] = "Mensagem vinda da action Index";
        return View();
    }

    public IActionResult Mensagem()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        var todo = new Todo
        {
            Titulo = "Estudar ASP .NET Core",
            Descricao = "Concluir o curso de ASP.NET Core da Treina Web"
        };

        var viewModel = new DetailTodoViewModel
        {
            Todo = todo,
            PageTitle = "Detalhes da Tarefa"
        };

        return View(viewModel);
    }
}