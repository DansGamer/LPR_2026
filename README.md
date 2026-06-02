# LRP 2026

## This repository contains files of my studies regarding the LPR subject within ETE FMC! In this very document are all the questions separated by class, just like the folders.

### Aula 1

1. Faça um "hello world" em C# e C++

**______________________________________________________________________________________________________________________________**

### Aula 2

1. Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
   Fórmula da área: area = π * raio * 2; 
   Considere o valor de π = 3.14159

2. Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D

3. Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcule o salário desse funcionário.
   A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

4. Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
   Calcule e mostre o valor a ser pago.

**______________________________________________________________________________________________________________________________**

### Aula 3

1. Clone o meu repositório (do professor) LPR_Aula3_Exemplo, faça alguma alteração, e publique no seu próprio GitHub

2. Ache uma dupla entre seus colegas. Você deve fazer um clone do repositório público do seu colega, criado no Desafio 1, para o seu computador.
   Neste repositório local, altere o programa “cloneGit.cpp”, inserindo uma nova variável “NomeDoColega”, contendo seu nome. Salve!
   Faça o commit dessa alteração para o seu repositório local, e em sequência, dê o push dessa alteração para o seu repositório GitHub.
   Dica: aqui será “Push origin”. Agora, no seu GitHub no navegador, acesse seu repositório alterado. Clique no botão “Compare & pull request” e em seguida em “Create pull request”.
   Peça para o seu colega aceitar seu Pull pela conta dele no GitHub no navegador. Ao final, você deve ter conseguido alterar o arquivo no repositório do seu colega no GitHub

**______________________________________________________________________________________________________________________________**

### Aula 4

1. Fazer um programa para ler um número inteiro, e depois dizer se este número é par ou não.

2. Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos    entre si. Atenção: os números podem ser digitados em ordem crescente ou decrescente.

3. Suponha que você está desenvolvendo um jogo de RPG. Você é responsável por implementar a mecânica de habilidades especiais para diferentes classes de              personagens. Cada classe tem suas próprias habilidades especiais. Crie um programa que permita ao jogador escolher uma classe de personagem e, em seguida,
   exiba suas habilidades especiais correspondentes. 


   
**______________________________________________________________________________________________________________________________**

### Aula 5

1. WHILE: Construa um algoritmo que calcule a média aritmética de um conjunto de números pares fornecidos pelo usuário. O usuário deve fornecer primeiro a            quantidade de números que serão digitados, e em seguida, os números considerados na média. O usuário pode digitar números ímpares, que devem ser ignorados.
   Por exemplo, no caso da tabela abaixo, o 5 informa que serão digitados 5 números (2 7 8 6 10), e para a média devem ser considerados apenas os números pares       (2, 8, 6 e 10) ignorando o número 7 digitado.

2. DO WHILE: Construa um algoritmo de adivinhação de números. Com as linhas abaixo, o algoritmo gerará um número inteiro aleatório de 1a 100:
   (C#) Random numAleatorio = new Random(); int valorInteiro = numAleatorio.Next(1,100);
   (C++) random_device numAleatorio; uniform_int_distribution<> distribuicao(1,100); int valorInteiro = distribuicao(numAleatorio);
   O seu trabalho é elaborar um algoritmo em que o usuário possa digitar números no console até acertar o número inteiro aleatório valorInteiro, de 1 a 100. A cada chute, o programa deve responder com “chutou alto”, “chutou baixo” ou “acertou”. Após acertar, deve ser mostrado quantas tentativas foram usadas para descobrir o número.

3. FOR: Elabore um algoritmo que calcule a soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500

**______________________________________________________________________________________________________________________________**

### Aula 6

1. Construa uma função em C++ que retorne o reverso de um número inteiro.

2. Construa um algoritmo em C++ que agrupe em funções os exercícios 1, 3 e 4 da tarefa de estruturas de repetições. Cada exercício deve estar contido em uma          função separada. Defina os parâmetros de modo eficiente e generalista. Construa um menu na função main. Reuse os códigos das suas respostas da tarefa no GitHub    ou a resposta do professor postada no AVA.

3. Desenvolva um programa em C# que simule um sistema de seleção de heróis da Marvel para uma equipe. O programa deve ter as seguintes funcionalidades:
- Cadastro de Heróis:Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, poder e pontuação de um herói da Marvel. A função deve solicitar essas informações ao usuário e armazená-las em variáveis. Não é necessário armazenar os heróis em uma lista ou vetor. O programa deve permitir o cadastro de até 5 heróis.
- Seleção de Equipe: Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis para formar sua equipe. A função deve exibir os heróis cadastrados e permitir que o usuário selecione quais heróis deseja incluir em sua equipe. O usuário deve ser capaz de selecionar três heróis para sua equipe.
- Pontuação Total da Equipe: Crie uma função chamada calcularPontuacaoTotal que calcule a pontuação total da equipe com base nos heróis selecionados. A pontuação total da equipe deve ser a soma das pontuações individuais de cada herói selecionado.
- Exibição da Equipe: Crie uma função chamada exibirEquipe que exiba os heróis selecionados para a equipe, seu poder e a pontuação total da equipe.
- Menu: Crie uma função chamada menuPrincipal que exiba um menu com as opções disponíveis para o usuário (cadastro de heróis, seleção de equipe, exibição da equipe e sair do programa). O usuário deve poder escolher uma das opções do menu e o programa deve executar a funcionalidade correspondente.
- Requisitos Adicionais: O programa deve continuar em execução até que o usuário escolha a opção de sair; Utilize variáveis locais para armazenar as informações dos heróis e da equipe; Não utilize classes, vetores ou listas! 

**______________________________________________________________________________________________________________________________**

### Aula 7

1. VETOR: Construa um algoritmo que leia 10 números inteiros e armazene-os em um vetor (use o for para fazer a leitura). Depois, crie automaticamente dois vetores, um contendo apenas os números pares e outro os números ímpares digitados.

2. VETOR: Construa um algoritmo que leia 10 números inteiros. Depois solicite para o usuário um número que ele gostaria de pesquisar no vetor. Caso o número exista no vetor, mostre em qual posição (ou quais) ele aparece e quantas ocorrências foram detectadas. 

