/*3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, 
na linguagem que desejar, que calcule e retorne:
	• O menor valor de faturamento ocorrido em um dia do mês;
	• O maior valor de faturamento ocorrido em um dia do mês;
	• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
    IMPORTANTE:
	a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
	b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média*/

using exercicio_3_solucao.models;
using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        using (StreamReader r = new StreamReader(@"D:\workspace\repositorio-target\exercicio-3\exercicio-3-solucao\exercicio-3-solucao\data\dados.json"))
        {
            string jsonString = r.ReadToEnd();
            double menor=0, soma=0, maior=0;
            int diaMenor = 0, diaMaior=0, qtdMaiorFaturamento=0;
            List<Dados>? dados = JsonConvert.DeserializeObject<List<Dados>>(jsonString);
            menor = dados[0].valor;
            maior = dados[0].valor;
            foreach (var item in dados)
            {
                if(item.valor < menor && item.valor != 0.0)
                {
                    menor = item.valor;
                    diaMenor = item.dia;
                }
                if(item.valor > maior)
                {
                    maior = item.valor;
                    diaMaior = item.dia;
                }
                soma = soma + item.valor;
            }
            soma = soma / dados.Count;
            foreach (var item in dados)
            {
                if (item.valor > soma)
                {
                    qtdMaiorFaturamento++;
                }
                
            }
            Console.WriteLine($"O menor valor de faturamento foi {menor} e ocorreu no dia {diaMenor}.");
            Console.WriteLine($"O maior valor de faturamento foi {maior} e ocorreu no dia {diaMaior}.");
            Console.WriteLine($"O número de dias em que o valor de faturamento diário foi superior à média mensal foi {qtdMaiorFaturamento}.");
        }
    }
}