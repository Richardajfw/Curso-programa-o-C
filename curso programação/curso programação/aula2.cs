
using System.ComponentModel.Design;

namespace curso_programação
{
    public class aula2
    {



        public void valorpar()
        {



            Console.WriteLine("informe o valor");

            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {

                Console.WriteLine("PAR");
            }

            else
            {
                Console.WriteLine("IMPAR");

            }


        }



        public void MaiorIdade() {


            Console.WriteLine("informe sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("maior");

            }
            else

            {
             Console.WriteLine("menor");

            }

            







        }


        public void Avaliacao()
        {
            int nota;
            Console.WriteLine("informe a sua nota");

            nota = int.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("aprovado");
            }

            else if (nota >= 5){
                Console.WriteLine("recuperacao");
            }


             else
            {
                Console.WriteLine("reprovado");
            }
              
            









        }











    }

}





        
        
        
        
    




         

        


        
