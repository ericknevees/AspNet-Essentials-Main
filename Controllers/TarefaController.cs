
using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller{
    //View = Página web (site)
    // Funções
    public IActionResult Index (){

        ViewData["Cabecalho"] = "Tarefa diária";
        ViewData["Titulo"] = "Planejar Aula Senai";
        ViewData["Descricao"] = "Criar nova PEUC";
        return View();
    }

}