//AulaClasses();
//AulaPropriedadeSomenteLeitura();
//AulaHeranca();
//AulaClasseSelada();
//AulaClasseAbstrata();
AulaRecord();

void AulaClasses()
{
  // Maneira de utilizar uma classe estática
  var resultado = Cadastro.Calculos.SomarNumeros(2, 3); // Utilizando um método da classe estática, por ser uma classe estática não precisa ser intanciada para utilização
  Console.WriteLine(resultado);

  // Maneira de utilizar uma classe não estática
  var produto = new Cadastro.Produto(); // Instanciando a classe produto para utilização, por ser classe não estática que precisa ser instanciada

  produto.Descricao = "Teclado"; // Informando um valor para o atributo descrição
  produto.SetId(1); // Chamando o método SetId e passando um valor por parâmetro
  produto.ImprimirDescricao(); // Chamando o método ImprimirDescricao
  Console.WriteLine(produto.GetId());
}

void AulaPropriedadeSomenteLeitura()
{
  var produto = new Cadastro.Produto();

  produto.Descricao = "Mouse";
  // produto.Estoque = 1; Não conseguimos atribuir valor dessa maneira porque se trata de uma propriedade somente leitura
  Console.WriteLine(produto.Estoque + " - " + produto.Descricao); // Exibindo o valor da propriedade somente leitura estoque
}

void AulaHeranca()
{
  // Utilizando a classe pessoa física
  var pessoaFisica = new Cadastro.PessoaFisica();

  pessoaFisica.Id = 1;
  pessoaFisica.Endereco = "Endereço Teste";
  pessoaFisica.Cidade = "Cidade Teste";
  pessoaFisica.Cep = "12345-678";
  pessoaFisica.CPF = "123.456.789-10";

  pessoaFisica.ImprimirDados();
  pessoaFisica.ImprimirCPF();

  // Utilizando a classe funcionário
  var funcionario = new Cadastro.Funcionario();

  funcionario.Id = 2;
  funcionario.Endereco = "Endereço Teste 2";
  funcionario.Cidade = "Cidade Teste 2";
  funcionario.Cep = "12345-678";
  funcionario.CPF = "123.456.789-10";
  funcionario.Matricula = "12345";

  funcionario.ImprimirDados();
  funcionario.ImprimirCPF();
  funcionario.ImprimirMatricula();
}

void AulaClasseSelada()
{
  /*
  var configuracao = new Cadastro.Configuracao();
  configuracao.Host = "localhost";
  */

  var configuracao = new Cadastro.Configuracao // Outra maneira de instanciar a classe já atribuindo valor as propriedades
  {
    Host = "localhost"
  };

  Console.WriteLine(configuracao.Host);
}

void AulaClasseAbstrata()
{
  var cachorro = new Cadastro.Cachorro();

  cachorro.Nome = "Dog";
  cachorro.ImprimirDados();
}

void AulaRecord()
{
  // Exemplo de comparando valores sem e com o Record (solução com o retord no namespace cadastro)
  var curso01 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
  var curso02 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
  Console.WriteLine(curso01 == curso02); // Comparando se os valores das instancias são iguais
  Console.WriteLine(curso01.Equals(curso02)); // Comparando se os valores das instancias são iguais

  // Exemplo de como copiar dados de uma instancia para outra sem o Record
  var cursoTeste01 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
  //var cursoTeste02 = cursoTeste01;
  //cursoTeste02.Descricao = "TESTE TESTE"; // Desta forma um valor vai sobrepor o outro
  var cursoTeste02 = new Cadastro.CursoTeste();
  cursoTeste02.Descricao = "TESTE TESTE";
  Console.WriteLine(cursoTeste01.Descricao);
  Console.WriteLine(cursoTeste02.Descricao);

  // Record
  var curso03 = new Cadastro.CursoRecord(1, "Curso"); // Instanciando e atribuindo valores com record
  Console.WriteLine(curso03.Id + " - " + curso03.Descricao);

  // Exemplo de como copiar dados de uma instancia para outra com o Record
  var cursoTeste03 = curso03 with { Descricao = "Teste Record" }; // Copiando os valores da instancia curso 03 alterando apenas o atributo descrição
  Console.WriteLine(curso03.Descricao);
  Console.WriteLine(cursoTeste03.Descricao);
}