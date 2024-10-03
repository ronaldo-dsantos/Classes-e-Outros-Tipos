namespace Cadastro
{
  // Classe estática
  public static class Calculos // static = Classe estática, classes estáticas não precisam ser instancialas para usá-las, mas a sua desalocação na memória tem que ser realizada de forma manual, devido a isso é recomendado utilizá-la apenas para situações específicas como extenções por exemplo
  {
    public static int SomarNumeros(int a, int b)
    {
      return a + b;
    }
  }

  // Classe não estática
  public class Produto // Classe não estática, classes não estáticas é necessário instancialas para usá-las, com isso elas são desalocadas da memória automaticamente pelo garbage collector quando não estão sendo mais utilizadas, por isso são mais indicadas para a utilização
  {
    private int Id; // Propriedade | Private torna a propriedade privada e não é possível utilizá-la em outras classes

    public string Descricao { get; set; } // Propriedade | Public torna a propriedade pública e com isso é possível utilizá-la em outras classes

    public void ImprimirDescricao() // Método
    {
      Console.WriteLine(GetId() + " - " + Descricao);
    }

    public void SetId(int id) // Método | void = vazio, ou seja, não retorna valor
    {
      Id = id;
    }

    public int GetId() // Método | int = inteiro, ou seja, retorna um inteiro
    {
      return Id;
    }
  }
}