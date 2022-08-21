namespace Calculadora.Models;

public class CalculadoraViewModel
{
   [display(Name "Numero 1")]
   public int Num1 { get; set; }

   [display(Name "Numero 2")]
   public int Num2 { get; set; }

   public string Operador { get; set; }

   public int? Resultado { get; set; }
}