using System.Globalization;

class Aluno
{
  public string Nome;
  public double Nota1;
  public double Nota2;
  public double Nota3;

  public double NotaFinal()
  {
    return Nota1 + Nota2 + Nota3;
  }

  public override string ToString()
  {
    bool passou = NotaFinal() > 60;
    double pontosFaltaram = 60 - NotaFinal();
    string aprovado = "APROVADO";
    string reprovado = "REPROVADO";
    

    return $@"
      NOTA FINAL = {NotaFinal()}
      {(passou ? aprovado : reprovado)}
      {(!passou ? $"FALTARAM: {pontosFaltaram.ToString("F2", CultureInfo.InvariantCulture)} PONTOS" : "")}
    ";
  }
}