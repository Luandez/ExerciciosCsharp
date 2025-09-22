# 📌 Exercício 3 - Verificação de Números Pares e Ímpares

Este programa em **C#** solicita ao usuário uma quantidade de números, depois lê cada número digitado e informa se ele é **par** ou **ímpar**.  
Ao final, apresenta um resumo com a contagem total de números pares e ímpares.

## 🖥️ Exemplo de execução
=== Verificação de Números Pares e Ímpares ===
Quantos números você deseja verificar? 5

Digite o 1º número: 10
➡ O número 10 é PAR.

Digite o 2º número: 7
➡ O número 7 é ÍMPAR.

Digite o 3º número: 4
➡ O número 4 é PAR.

Digite o 4º número: 15
➡ O número 15 é ÍMPAR.

Digite o 5º número: 8
➡ O número 8 é PAR.

Resumo da verificação:
🔹 Total de números: 5
🔹 Pares: 3
🔹 Ímpares: 2

## ▶️ Como executar

1. Clone este repositório:

   ```bash
   git clone https://github.com/Luandez/ExerciciosCsharp.git
   ```
2. Acesse a pasta do exercício:

   ```bash
   cd Iniciante/Exercicio3
   ```
3. Execute o projeto:

   ```bash
   dotnet run
   ```

## 🧩 Conceitos utilizados
- Entrada de dados com Console.ReadLine() Para capturar os números digitados pelo usuário.

- Conversão segura de dados com int.TryParse Para garantir que o usuário digite apenas números inteiros, evitando erros de execução.

- Estrutura de repetição while (validação de entrada) Usada tanto para validar a quantidade de números quanto cada número digitado.

- Estrutura de repetição for Para percorrer a quantidade de números informada pelo usuário.

- Estrutura condicional if...else Para verificar se cada número é par ou ímpar.

- Operador módulo % Utilizado para descobrir o resto da divisão por 2 e, assim, determinar se o número é par ou ímpar.

- Contadores (par++, impar++) Para acumular a quantidade de números pares e ímpares digitados.

- Saída formatada com Console.WriteLine() Para exibir mensagens claras e amigáveis ao usuário, incluindo o resumo final.

- Uso de Console.Clear() Para limpar a tela e deixar a execução mais organizada.
