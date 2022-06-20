/*5) Escreva um programa que inverta os caracteres de um string.
IMPORTANTE:
	a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
	b) Evite usar funções prontas, como, por exemplo, reverse;*/
 
using System;
class Program
{
    public static void reverterString(string original)
    {
        char[] vetorCaracteres = original.ToCharArray();
        string reversa = "";
        int i;
        for (i = vetorCaracteres.Length - 1; i >= 0; i--)
        {
            reversa += vetorCaracteres[i];
        }
        Console.WriteLine(reversa);
    }

    public static void Main(string[] args)
    {
       string original = "socorram me subi no ônibus em marrocos";
       reverterString(original);
    }
}
