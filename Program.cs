namespace Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      Retangulo retangulo = new Retangulo();
      
      System.Console.WriteLine("Exercício 1");
      System.Console.WriteLine("Entre a largura e altura do retângulo:");
      System.Console.Write("Largura: ");
      retangulo.Largura = double.Parse(Console.ReadLine());

      System.Console.Write("Altura: ");
      retangulo.Altura = double.Parse(Console.ReadLine());

      System.Console.WriteLine($"AREA = {retangulo.Area()}");
      System.Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro()}");
      System.Console.WriteLine($"DIAGONAL = {retangulo.Diagonal()}");

      System.Console.WriteLine("Exercício 2");

      Funcionario funcionario = new Funcionario();

      System.Console.WriteLine("Informe os dados do funcionário:");
      System.Console.Write("Nome: ");
      funcionario.Nome = Console.ReadLine();

      System.Console.Write("Salário bruto: ");
      funcionario.SalarioBruto = double.Parse(Console.ReadLine());

      System.Console.Write("Imposto: ");
      funcionario.Imposto = double.Parse(Console.ReadLine());

      System.Console.WriteLine(funcionario);

      System.Console.Write("Digite a porcentagem para aumentar o salário: ");
      double porcentagem = double.Parse(Console.ReadLine());
      funcionario.AumentarSalario(porcentagem);

      System.Console.WriteLine(funcionario);

      System.Console.WriteLine("Exercício 3");

      Aluno aluno = new Aluno();

      System.Console.Write("Informe os dados do aluno: ");
      System.Console.Write("Nome: ");
      aluno.Nome = Console.ReadLine();

      System.Console.Write("Nota 1: ");
      aluno.Nota1 = double.Parse(Console.ReadLine());

      System.Console.Write("Nota 2: ");
      aluno.Nota2 = double.Parse(Console.ReadLine());

      System.Console.Write("Nota 3: ");
      aluno.Nota3 = double.Parse(Console.ReadLine());

      System.Console.WriteLine(aluno);
    }
  }
}