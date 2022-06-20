/*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre 
será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
escreva um programa na linguagem que desejar onde, informado um número, ele calcule a 
sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence 
ou não a sequência.*/
 
class Program
{
    //Função para cálculo da sequência de Fibonacci
    public static string fibonacci(int n)
    {
        int aux0=0, aux1=1, fib=0;
        while(fib < n){
            fib = aux0 + aux1;
            aux0 = aux1;
            aux1 = fib;
        }
        if(fib == n){
            return "Pertence a sequência de Fibonacci.";
        }else{
            return "Não pertence a sequência de Fibonacci.";
        }
    }

    public static void Main(string[] args)
    {
        //Número que deve ser verificado
        int valor = 89;
        string resultado = fibonacci(valor);
        Console.WriteLine(resultado);
    }
}
