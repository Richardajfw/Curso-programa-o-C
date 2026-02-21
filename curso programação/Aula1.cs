using System.Net.NetworkInformation;

namespace curso_programação
{
    public class Aula1
    {
        public void Soma()
        {

            int valor1;
            int valor2;


            Console.WriteLine("informe o valo1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"total{valor1 + valor2}");
        }


        public void multiplicar ()
        {

            int valor1;
            int valor2;


            Console.WriteLine("informe o primeiro valo1");
             valor1 = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("informe o segundo valo2");
             valor2 = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine($"total {valor1 * valor2}");

        }


        public void subtrair()
        {
            int valor1;
            int valor2;


            Console.WriteLine("informe o primeiro valor1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo valor2");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"total {valor1 - valor2}");


                    }



        public void divir() 
        {
            int valor1;
            int valor2;

            Console.WriteLine("informe o primeiro valor1");
            valor1 = Convert.ToInt32(Console.Read);


            Console.WriteLine("informe o segundo valor2");
            valor2 = Convert.ToInt32(Console.Read);


            Console.WriteLine($"total {valor1 / valor2}");

          
        }










    }
}



