# invoicing
 
Este é um programa simples em C# que analisa os dados de faturamento mensal de uma distribuidora, conforme os requisitos abaixo:

- Determina o menor e o maior valor de faturamento ocorrido em um dia do mês.
- Calcula o número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

## Requisitos

- .NET Core SDK 3.1 ou superior
- Um arquivo JSON contendo os dados de faturamento mensal

## Utilização

1. Certifique-se de ter o .NET Core SDK instalado em seu sistema.
2. Clone este repositório ou faça o download dos arquivos.
3. Adicione o arquivo JSON contendo os dados de faturamento mensal no diretório do projeto.
4. Abra um terminal na pasta do projeto e execute o comando `dotnet run`.
5. O programa exibirá o menor e o maior faturamento diário, bem como o número de dias com faturamento acima da média mensal.

## Formato do Arquivo JSON

O arquivo JSON deve ter a seguinte estrutura:

```json
{
  "Faturamentos": [100.5, 200.3, 150.7, 0, 180.2, 0, 300.9, 250.6, 0, 220.4, 175.8, 0, 198.6, 205.1, 210.3, 190.7, 180.5, 170.9, 0, 0, 230.2, 195.8, 0, 185.6, 160.4, 220.7, 0, 0, 180.3, 210.8, 225.4]
}
```
Neste exemplo, o vetor Faturamentos contém os valores diários de faturamento para cada dia do mês. Os dias sem faturamento têm o valor 0.