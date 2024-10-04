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

    // Propriedade somente leitura são propriedades que não permitem a modificação de seus valores, a não ser que seja modificada pelo construtor da classe
    public int Estoque { get; } // Maneiras de declarar uma propriedade como somente leitura
    // public readonly int Estoque; // Maneiras de declarar a propriedade como somente leitura

    // Contrutor é uma ação que é executada no momento que a classe está sento instanciada e através desse construtor conseguimos ter acesso aos atributos e métodos da classe e de outras classes também
    public Produto()
    {
      Estoque = 2; // Setando valor a propriedade somente leitura estoque, por ser uma propriedade privada só é possível setar valor no momento de construção da classe, isso cria uma proteção de acesso a essa propriedade, pois quando for instanciada por outros objetos essa propriedade não poderá ser alterada
    }
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

  // Super classe que será herdada por outras sub classes
  public class Pessoa // Super Classe Pessoa
  {
    public int Id { get; set; }

    public string Endereco { get; set; }

    public string Cidade { get; set; }

    public string Cep { get; set; }

    public void ImprimirDados()
    {
      Console.WriteLine("Código: " + Id);
      Console.WriteLine("Endereço: " + Endereco);
      Console.WriteLine("Cidade: " + Cidade);
      Console.WriteLine("Cep: " + Cep);
    }
  }

  // Herança
  public class PessoaFisica : Pessoa // Sub classe PessoaFisica herdando os atributos e métodos da classe pessoa
  {
    public string CPF { get; set; }

    public void ImprimirCPF() // Método exclusivo da sub classe
    {
      Console.WriteLine("CPF: " + CPF);
    }
  }

  // Herança
  public class Funcionario : PessoaFisica // Sub classe Funcionario herdando os atributos e métodos da classe PessoaFisica e consequentemente da classe Pessoa
  {
    public string Matricula { get; set; }

    public void ImprimirMatricula()
    {
      Console.WriteLine("Matrícula: " + Matricula);
    }
  }

  // Classe Selada (É uma classe como as demais, porém não pode ser herdada por outras classes, essa é a principal utilização da classe selada, forçar que ela não possa ser herdada por nenhuma outra classe, mas pode ser instanciada e utilizada por outras classes normalmente)
  public sealed class Configuracao // sealed = Classe Selada
  {
    public string Host { get; set; }
  }

  // Classe Abstrata (É uma classe que não pode ser instanciada, isso faz que a classe abstrata tenha o propósito de ser uma super classe para ser instanciadas por outras sub classes, uma espécie de contrato para forçar que as sub classes implemente de forma concreta o que é informado na classe abstrata)
  public abstract class Animal // abstract = Classe Abstrata
  {
    public string Nome { get; set; }

    public abstract string GetInformacoes(); // abstract para forçar que a sub classe que estiver herdando a classe animal implemente também este método (Obs. método sem instruções que precisarão ser informadas pela classe que está herdando) 

    public void ImprimirDados()
    {
      Console.WriteLine("Nome animal: " + Nome);
      Console.WriteLine("Informações: " + GetInformacoes());
    }
  }
  // sub classe Cachorro herdando a classe abstrata Animal
  public class Cachorro : Animal
  {
    public override string GetInformacoes() // Complementando o método GetInformacoes que estava sem instruções
    {
      return "Cachorro é um bom amigo";
    }
  }

  // Record
  public class Curso // Classe de exemplo para mostrar como teria que ser feito a comparação de valores das instâncias sem o Record, neste exemplo se substituir a palava class para record, os métodos criados para comparação não se fazem necessários
  {
    public int Id { get; set; }

    public string Descricao { get; set; }

    // Método para alterar o comportamento do Equals para verificar se os valores das instancias são iguais, por padrão o retorno seria false porque ele analisa se as instancias são iguais
    public override bool Equals(object? obj)
    {
      if (obj == null) return false;

      if (obj is Curso curso)
      {
        return Id == curso.Id && Descricao == curso.Descricao;
      }

      return base.Equals(obj);
    }

    // Método para alterar o comportamento do == para verificar se os valores das instancias são iguais, por padrão o retorno seria false porque ele analisa se as instancias são iguais
    public static bool operator ==(Curso a, Curso b)
    {
      return a.Equals(b);
    }

    public static bool operator !=(Curso a, Curso b)
    {
      return !(a == b);
    }
  }

  public record CursoRecord(int Id, string Descricao); // Criando um record com duas propriedades somente leitura

  public class CursoTeste
  {
    public int Id { get; set; }
    public string Descricao { get; set; }
  }
}

