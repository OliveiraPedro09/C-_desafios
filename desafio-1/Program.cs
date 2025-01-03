﻿// * Desafio 1 
// Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos. Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.

using System;

Random random = new Random();
int luckyNumber = random.Next(1, 101);

do{
    // * Print para saber se o programa está sendo Executado corretamente
    Console.WriteLine("Número sorteado: " + luckyNumber);

    Console.Write("\nAdivinhe o número sorteado entre 1 e 100: ");
    string userGuess = Console.ReadLine()!;
    int userNumber = int.Parse(userGuess);

    if (userNumber == luckyNumber){
        Console.WriteLine("Parabéns !! Você acertou o número sorteado.");
        break;
    } else if (userNumber > luckyNumber){
        Console.WriteLine("O numero sorteado é menor que o número digitado.");
    } else {
        Console.WriteLine("O número sorteado é maior que o número digitado.");
    };
}while(true);
