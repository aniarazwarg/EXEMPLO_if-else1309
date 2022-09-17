using System;

class Program {
  public static void Main (string[] args) {
    int numdig;
    Console.Write ("Digite um número ");
    numdig = int.Parse(Console.ReadLine());
    if (numdig>=0)
      //Se numdig >=0, NÃO HÁ PONTO E VIRGULA POIS NÃO É FINAL DE COMANDO.
    {
      Console.WriteLine("POSITIVO");
    }
    else
      //SENÃO.
    {
      Console.WriteLine("NEGATIVO");
    }
  }
}