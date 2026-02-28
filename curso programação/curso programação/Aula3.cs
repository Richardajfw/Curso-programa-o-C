using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace curso_programação
{
    public class Aula3
    {
        //Switch 

        public void AvaliacaoSwitch()
        {

            int nota;
            Console.WriteLine("informe sua nota:");
            nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case >= 7:
                    Console.WriteLine("Aprovado");
                    break;

                case >= 5:
                    Console.WriteLine("recuperacao");
                    break;

                default:
                    Console.WriteLine("reprovado");
                    break;
            
            
            
            
            
            }


        }



        public void CategoraIdade()
        {
            Console.WriteLine("informe sua idade ");

            int idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case >= 18:
                    Console.WriteLine("maoir");
                    break;









            }


        }














    }














}
