internal class Program
{

    private static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        int numero = Convert.ToInt32(Console.ReadLine());

        bool booleana = true;
        int valor1 = 5;
        int valor2 = 6;

        // operadores aritméticos
        int adicao = 1 + 1;
        int subtracao = 2 - 1;
        int multiplicacao = 2 * 3;
        float divisao = 5f / 2;
        float mod = 5 % 2;

        //Console.WriteLine(mod);

        double potencia = Math.Pow(2, 3); //2 ^ 3;
        double raizQuadrada = Math.Sqrt(9);
        


        //Console.WriteLine(divisao);

        // operadores lógicos

        // 2 > 1; maior que
        // 1 < 2; menor que
        // 10 == 10; igual a 
        // 10 != 11; diferente de 
        // 11 >= 10; maior ou igual a
        // 11 <= 10; menor ou igual a

        // exemplo 1
        if (valor1 > valor2)
        {
            Console.WriteLine("O valor 1 é maior");
        } 
        else if (valor1 == valor2)
        {
            Console.WriteLine("Os valores são iguais");
        }
        else
        {
            Console.WriteLine("O valor 2 é maior");
        }

        Console.WriteLine("--------------");

        // exemplo 2
        if (booleana)
        {
            Console.WriteLine("A booleana é verdadeira");
        }
        else
        {
            Console.WriteLine("A booleana é falsa");
        }

        Console.WriteLine("--------------");

        // exemplo 3
        if (valor1 is int)
        {
            Console.WriteLine("O valor é inteiro");
        }
        else
        {
            Console.WriteLine("O valor não é inteiro");
        }

        Console.WriteLine("--------------");

        // switch
        switch (valor1)
        {
            case 1: Console.WriteLine("O valor é 1"); break;
            case 3: Console.WriteLine("O valor é 3"); break;
            case 5: Console.WriteLine("O valor é 5"); break;
            default: Console.WriteLine("Valor padrão"); break;
        }
    }
}