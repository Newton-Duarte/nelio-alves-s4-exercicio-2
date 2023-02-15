using System.Globalization;

class Funcionario
{
  public string Nome;
  public double SalarioBruto;
  public double Imposto;

  double SalarioLiquido()
  {
    return SalarioBruto - Imposto;
  }

  public void AumentarSalario(double porcentagem)
  {
    double valor = porcentagem/100;
    SalarioBruto += valor * SalarioBruto;
  }

  public override string ToString()
  {
    return $"Funcionário: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
  }
}