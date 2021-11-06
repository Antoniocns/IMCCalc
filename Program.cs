using System;

namespace IMCCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //double massa, altura, imc;
           string diagnostico="";
            Console.WriteLine(" -- Calculadora IMC --\n");

            Console.Write("Digite seu peso em Kg...:");
           double massa=Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura em m..:");
            double altura=Convert.ToDouble(Console.ReadLine());

            double imc = massa / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:n2} kg/m².");
             
            if(imc < 17)
            {
               diagnostico = "Muito abaixo do peso";
            }  
              else if(imc < 18.5)
              {
                  diagnostico = "Abaixo do peso";
              }
              else if(imc < 18.5)
                {
                  diagnostico = "Abaixo do peso";
                }
              else if (imc < 25)    
              {
                  diagnostico = "Peso normal";
              }

              else if (imc< 30)
              {
                 diagnostico = "Acima do peso";
              }
             else if (imc < 35)
             {
               diagnostico = "Obesidade I";
             }
               else if (imc <40)
               {
                diagnostico = "Obesidade II (Severa)";
               }

               else
            {
                diagnostico = "Obesidade III (mórbida)";
            }
               
               Console.WriteLine($"diagnostico: {diagnostico}"); 
               
            
        }
    }
}
