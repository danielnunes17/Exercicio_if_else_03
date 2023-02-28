/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.*/

public class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora digite outro número inteiro: ");
        int B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Os números são multiplos");
        }
        else
        {
            Console.WriteLine("Os números não são multiplos");
        }
    }
}