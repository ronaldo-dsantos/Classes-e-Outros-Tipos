namespace Cadastro
{
  public class Produto
  {
    private int Id; // Private torna o método privado e não é possível utilizá-lo em outras classes

    public string Descricao { get; set; } // Public torna o método público e com isso é possível utilizá-lo em outras classes

    public void ImprimirDescricao()
    {
      Console.WriteLine(Descricao);
    }

    public void SetId(int id)
    {
      Id = id;
    }

    public int GetId()
    {
      return Id;
    }
  }
}