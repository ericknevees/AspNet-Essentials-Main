// namespace e um conjunto de classes

namespace GerenciaTarefa.Models;
public class Tarefa {
    /* classe e um conjunto de objetos
    tem que ter 2 recursos dentro da classe:
    -Propriedade
    -funcionalidade*/

    //Propiedades Automáticas
    public int Id {get; set; } //inteiro
    public string? Cabecalho { get; set; }
    public string? Titulo { get; set; }

    public string? Descricao {get; set; } //texto

    public bool TaCompleta { get; set; }
    

}