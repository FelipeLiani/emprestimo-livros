namespace EmprestimoLivros.Models {
  public class Emprestimos {
    public int Id {get; set;}
    public string Recebedor {get; set;}
    public string Fornecedor {get; set;}
    public string LivroEmprestado {get; set;}
    public DateTime DataEmprestimo {get; set;} = DateTime.Now;
    
  }
}