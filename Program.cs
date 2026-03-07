partial class program
{
    static void Main(string[] args)
    {
        float peso;
        float altura;
        float imc;
        string opcao;

        while (true)
        {
            Console.WriteLine("infome o seu peso!");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("informe sua altura!");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC : {imc:F2}");

            Console.WriteLine("Deseja calcular outro IMC s/n");
            opcao = Console.ReadLine();

            if(opcao != "s")
            {
                break;
            }
            Console.Clear();
        }








    }
}
