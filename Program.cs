AulaClasses();

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
