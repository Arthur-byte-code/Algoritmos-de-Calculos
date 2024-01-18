


// BLOCOS DE COMANDOS DE CADA EXERCÍCIOS DENTRO DE UM DETERMINADO VOID ABAIXO//
using System.ComponentModel.Design;
Menu();
void Exercicio1()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo de Estoque)------");

    Console.WriteLine("Digite a quantidade mínima");
    decimal qmi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a quantidade máxima");
    decimal qma = Convert.ToInt32(Console.ReadLine());


    decimal em = (qmi + qma) / 2;

    Console.WriteLine(" o estoque medio é==>" + em);

    Console.ReadKey();
    Menu();

}//estoque//

void Exercicio2()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo de Cotação do Dólar)------");
    decimal dolar = 4.87m;

    Console.WriteLine("digite o dolar pra converter em reais");
    decimal qnt = Convert.ToInt32(Console.ReadLine());
    decimal real;

    real = dolar * qnt;

    Console.Write("o Dólar digitado convertido em reais ficará assim-->" + real);
    Console.ReadKey();
    Menu();

}//conversão monetária//

void Exercicio3()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo de Comissão)------");
    int p = 8;
    Console.WriteLine("ola, digite seu nome");
    string n = Convert.ToString(Console.ReadLine());

    Console.WriteLine("digite o codigo da peça");
    string cdg = Convert.ToString(Console.ReadLine());

    Console.WriteLine("ola, senhor(a) (" + n + ") digite quantas peças foram vendidas");
    int q = Convert.ToInt32(Console.ReadLine());

    int vt = p * q;
    Console.WriteLine("(" + n + ") vendeu [" + q + "] peças e isso rendeu em reais: [" + vt + "] ");

    int prctg = (vt * 5 / 100);

    Console.WriteLine("a comissão de [" + n + "] equivale a [" + prctg + "]");
    Console.WriteLine("o codigo da peça é--->" + cdg);
    Console.ReadKey();
    Menu();
}//comissão//

void Exercicio4()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo de Litros e Horas gastas em viagem de carro)------");
    Console.WriteLine("Digite as horas gastas na viagem. ");
    int tgv = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a velocidade média (km) durante a viagem");
    int vm = Convert.ToInt32(Console.ReadLine());
    int d;
    int lu;
    d = tgv * vm;

    lu = d / 12;

    Console.WriteLine("quantidade de litros utilizada -->" + lu);
    Console.WriteLine("tempo gasto de viagem -->" + tgv);
    Console.WriteLine("velocidade media -->" + vm);
    Console.ReadKey();
    Menu();
}//litros gastos//

void Exercicio5()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo conversor de graus Celsius para Fahrenheit)------");
    Console.WriteLine("seja bem vindo ao conversor de celsius em fahrenheit");
    Console.WriteLine("digite o grau em celsius para a conversao");
    decimal c = Convert.ToInt32(Console.ReadLine());
    decimal f;
    f = (9 * c + 160) / 5;

    Console.WriteLine("o valor em celsius convertido em fahrenheit ficara-->" + f);
    Console.ReadKey();
    Menu();

}//celsius pra fahrenheit//

void Exercicio6()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo conversor de graus Fahrenheit para Celsius  )------");
    Console.WriteLine("seja bem vindo ao conversor de fahrenheit em celsius");
    Console.WriteLine("digite o grau em fahrenheit para a conversao");
    decimal f = Convert.ToInt32(Console.ReadLine());
    decimal c;
    c = (f - 32) * 5 / 9;
    Console.WriteLine("o valor em fahrenheit convertido em celsius ficara-->" + c);
    Console.ReadKey();
    Menu();
}//fahrenheit pra celsius//

void Exercicio7()
{
    Console.Clear();
    Console.WriteLine("------(Algoritmo conversor de graus Fahrenheit para Celsius e vice versa )------");
    Console.WriteLine("seja bem vindo ao nosso conversor.");
    Console.WriteLine("digite 1 para converter celsius em fahrenheit");
    Console.WriteLine("digite 2 para converter fahrenheit em celsius");
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        //converter celsius em fahrenheit
        case 1:
            Console.WriteLine("seja bem vindo ao conversor de celsius em fahrenheit");
            Console.WriteLine("digite o grau em celsius para a conversao");
            decimal c = Convert.ToInt32(Console.ReadLine());
            decimal f;
            f = (9 * c + 160) / 5;

            Console.WriteLine("o valor em celsius convertido em fahrenheit ficara-->" + f);
            break;
        // converter fahrenheit em celsius abaixo
        case 2:
            Console.WriteLine("seja bem vindo ao conversor de fahrenheit em celsius");
            Console.WriteLine("digite o grau em fahrenheit para a conversao");
            decimal fa = Convert.ToInt32(Console.ReadLine());
            decimal ce;
            ce = (fa - 32) * 5 / 9;

            Console.WriteLine("o valor em fahrenheit convertido em celsius ficara-->" + ce);
            break;
        default:
            Console.WriteLine("invalido");
            break;
    }
    Console.ReadKey();
    Menu();
}//graus de temperatura f pra c e c pra f//

void Exercicio8()
{
    Console.Clear();
    Console.WriteLine("------(Converter Idade em Dias )------");
    Console.WriteLine("digite sua idade para converte-la em dias");
    int idd = Convert.ToInt32(Console.ReadLine());


    int r = (idd * 365);

    Console.WriteLine("Sua idade convertida em dias é--->" + r);
    Console.ReadKey();
    Menu();
}//idade em dias//

void Exercicio9()
{
    Console.Clear();
    bool isTrue; // Declaração da variável booleana

    // Solicitando ao usuário que insira um valor booleano
    Console.WriteLine("Digite 'true' se algo for verdadeiro ou 'false' se for falso:");

    // Lendo a entrada do usuário e tentando converter para booleano
    bool inputParsed = bool.TryParse(Console.ReadLine(), out isTrue);

    // Verificando se a entrada foi válida
    if (inputParsed)
    {
        // Exibindo o valor da variável booleana fornecida pelo usuário
        Console.WriteLine("O valor da variável fornecida é: " + isTrue);

        // Utilizando a variável booleana em uma estrutura condicional
        if (isTrue)
        {
            Console.WriteLine("Você digitou 'true'.");
        }
        else
        {
            Console.WriteLine("Você digitou 'false'.");
        }
    }
    else
    {
        // Se a entrada não pôde ser convertida para booleano
        Console.WriteLine("Entrada inválida. Por favor, digite 'true' ou 'false'.");
    }
    Console.ReadKey();
    Menu();
}//relações de números//

void Exercicio10()
{
    Console.Clear();
    Console.WriteLine("------(inverter valores)------");
    Console.Write("digte o valor 1--->");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("digte o valor 2--->");
    int b = Convert.ToInt32(Console.ReadLine());
    int temp = a;

    a = b;
    b = temp;
    // é necessaria a variavel temp, pra que a troca ocorra. funciona como um intermediario

    Console.WriteLine("a=" + a);
    Console.WriteLine("b=" + b);
    Console.ReadKey();
    Menu();
}//inverter valores//

void Exercicio11()
{
    Console.Clear();
    Console.WriteLine("------(exibir valores em ordem decrescente)------");
    Console.WriteLine("algoritmo para imprimir 3 valores digitados em ordem decrescente");
    Console.WriteLine("digte o n1-->");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte o n2-->");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte o n3-->");
    int n3 = Convert.ToInt32(Console.ReadLine());

    if (n1 > n2 && n2 > n3)
    {
        Console.WriteLine("confira abaixo");
        Console.WriteLine("" + n1);
        Console.WriteLine("" + n2);
        Console.WriteLine("" + n3);
    }
    else
    {
        Console.WriteLine("confira abaixo");
        Console.WriteLine("" + n3);
        Console.WriteLine("" + n2);
        Console.WriteLine("" + n1);
    }

    Console.ReadKey();
    Menu();

}//exibir valor em ordem decrescente//

void Exercicio12()
{
    Console.Clear();
    Console.WriteLine("------(Exibe diferença entre dois números digitados)------");
    Console.WriteLine("digte o n1-->");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte o n2-->");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int res;

    if (n1 > n2)
    {
        res = n1 - n2;
        Console.WriteLine("a diferenca entre (" + n1 + ") e (" + n2 + ") e--> " + res);
    }
    else
    {
        res = n2 - n1;
        Console.WriteLine("a diferenca entre (" + n2 + ") e (" + n1 + ") e-->" + res);
    }
    Console.ReadKey();
    Menu();
}//exibir diferença entre dois valores//

void Exercicio13()//média de notas de alunos//
{
    Console.Clear();
    Console.WriteLine("------(Calcular média de notas de um aluno)------");
    Console.WriteLine("calculadora de média do aluno");
    Console.WriteLine("digte a nota do primeiro trimestre-->");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte a nota do segundo trimestre-->");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte a nota do terceiro trimestre");
    int n3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte a nota do quarto trimestre");
    int n4 = Convert.ToInt32(Console.ReadLine());

    int m;
    m = (n1 + n2 + n3 + n4) / 2;

    if (m >= 7)
    {
        Console.WriteLine("o aluno foi aprovado com a media de[" + m + "]");
    }
    if (m < 7)
    {
        Console.WriteLine("insira a nota de recuperação");
        int nr = Convert.ToInt32(Console.ReadLine());
        double novaMedia = (m + nr) / 2;
        if (novaMedia >= 7)
        {
            Console.WriteLine("aprovado com a nova media de-->" + novaMedia);
        }
        else
        {
            Console.WriteLine("mesmo somando a media de nota[" + m + "]com a nota de recuperação, o aluno nao foi aprovado");
        }

    }
    Console.ReadKey();
    Menu();
}//média de notas de alunos por 4 trimestre//

void Exercicio14()
{
    Console.Clear();
    Console.WriteLine("(------------Algoritmo para saber qual de dois numeros é o maior ou se são iguais--------)");
    Console.WriteLine("o primeiro valor");
    int v1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("o segundo valor");
    int v2 = Convert.ToInt32(Console.ReadLine());

    if (v1 > v2)
    {
        Console.WriteLine("o número (" + v1 + ") é maior que o (" + v2 + ")");
    }
    else if (v2 > v1)
    {
        Console.WriteLine("o número (" + v2 + ") é maior que o (" + v1 + ")");
    }
    else
    {
        Console.WriteLine("Os dois números digtados são iguais");
    }
    Console.ReadKey();
    Menu();
}//algoritmo pra saber se dois numeros são iguais o se um é maior que outro//

void Exercicio15()
{
    Console.Clear();
    Console.WriteLine("-----------(Algoritmo pra saber se o numero digitado está entre 0 e 9)------------");
    Console.WriteLine("digite o numero");
    int v1 = Convert.ToInt32(Console.ReadLine());

    if (v1 > 0 && v1 < 9)
    {
        Console.WriteLine("valor valido");
    }
    else
    {
        Console.WriteLine("valor invalido");
    }
    Console.ReadKey();
    Menu();
}//Pra saber per se um nº está entre 0 e 9//

void Exercicio16()//
{
    Console.Clear();
    Console.WriteLine("-----------(Algoritmo para realizar as quatro operações aritiméticas)------------");
    Console.WriteLine("digite 1 para adição");
    Console.WriteLine("digite 2 para subtraçao");
    Console.WriteLine("digite 3 pra multiplicacao");
    Console.WriteLine("digite 4 pra divisao");

    int s = Convert.ToInt32(Console.ReadLine());

    switch (s)
    {
        case 1:
            Console.WriteLine("voce escolheu o algoritmo de soma");

            Console.WriteLine("digite o primeiro valor");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            int b = Convert.ToInt32(Console.ReadLine());

            int r = a + b;
            Console.WriteLine("o resultado da soma de[" + a + "]+[" + b + "] e igual a ==> " + r);
            break;

        case 2:
            Console.WriteLine("voce escolheu o algoritmo de subtração");
            Console.WriteLine("digite o primeiro valor");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int r2 = a2 - b2;
            Console.WriteLine("o resultado da subtracao de[" + a2 + "]-[" + b2 + "] e igual a ==> " + r2);
            break;
        case 3:
            Console.WriteLine("voce escolheu o algoritmo de multiplicação");
            Console.WriteLine("digite o primeiro valor");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            int b3 = Convert.ToInt32(Console.ReadLine());
            int r3 = a3 * b3;
            Console.WriteLine("o resultado da multiplicacao de[" + a3 + "]x[" + b3 + "] e igual a ==> " + r3);
            break;
        case 4:
            Console.WriteLine("voce escolheu o algoritmo de divisao");
            Console.WriteLine("digite o primeiro valor");
            decimal a4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo valor");
            decimal b4 = Convert.ToInt32(Console.ReadLine());
            decimal r4 = a4 / b4;
            Console.WriteLine("o resultado da divisao de[" + a4 + "]/[" + b4 + "] e igual a ==> " + r4);

            break;
        default:
            Console.WriteLine("invalido");
            break;
    }
    Console.ReadKey();
    Menu();
}//Algoritmo para realizar as quatro operações aritiméticas

void Exercicio17()
{
    Console.Clear();
    Console.WriteLine("-----------(Algoritmo para exibir mútiplo, pares e calcular média)------------");
    Console.WriteLine("digite 1 para algoritimo exibidor de multiplo ");
    Console.WriteLine("digite 2 para algoritimo exibidor numeros pares ");
    Console.WriteLine("digite 3 para algoritimo que calcula a média de dois numeros e diz se é maior que 7");
    Console.WriteLine("digite 4 para encerrar o programa");
    int sw = Convert.ToInt32(Console.ReadLine());
    switch (sw)
    {
        case 1:
            Console.WriteLine("digite o primeiro valor");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo valor");
            int b = Convert.ToInt32(Console.ReadLine());
            int rst = a % b;
            if (rst == 0)
            {
                Console.Write("o numero [" + a + "] e mutiplo de [" + b + "]");
            }
            else
            {
                Console.Write("o numero[" + a + "]nao e mutiplo de[" + b + "]");
            }
            break;
        case 2:
            Console.WriteLine("voce vai digitar dois numeros, e sera dito se sao pares");
            Console.WriteLine("digite o primeiro valor");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0 && y % 2 == 0)
            {
                Console.WriteLine("os numeros [" + x + "]e [" + y + "] sao pares");
            }

            else if (x % 2 != 0 && y % 2 == 0)
            {
                Console.WriteLine("o numero [" + x + "]nao e par, ja o  [" + y + "] e par");

            }
            else if (x % 2 == 0 && y % 2 != 0)
            {
                Console.WriteLine("o numero [" + x + "]e par, ja o  [" + y + "] nao e par");
            }
            else
            {
                Console.WriteLine("o numero [" + x + "]e impar, e o  [" + y + "] tambem");
            }

            break;//
        case 3:

            Console.WriteLine("digite o valor um");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o valor dois");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int m = (n1 + n2) / 2;

            if (m > 7)
            {
                Console.Write("a media e maior que 7");
            }
            else if (m == 7)
            {
                Console.WriteLine("a media e igual a 7");
            }
            else
            {
                Console.WriteLine("a media e menor que 7");
            }
            break;
        case 4:
            Console.WriteLine("encerrando");
            return;

        default:
            Console.WriteLine("Inválido");
            break;
    }// aqui fecha o a chave aberta no switch
    Console.ReadKey();
    Menu();
}//Algoritmo para exibir mútiplo, pares e calcular média

void Exercicio18()
{
    Console.Clear();
    Console.WriteLine("-----------(contador decrescente)------------");
    //contador decrescente//
    for (int n = 100; n >= 1; n--)
    {
        Console.WriteLine("" + n);
    }
    Console.ReadKey();
    Menu();
}//contador decrescente

void Exercicio19()
{
    Console.Clear();
    Console.WriteLine("-----------(Calcular fatorial de 10 numeros)------------");
    // o algoritmo é repetido 10 vezes//
    for (int cnt = 1; cnt <= 10; cnt++)
    {//for

        int n;
        int c;
        int fat;

        Console.WriteLine("Digite o número que você deseja saber a fatorial");
        n = Convert.ToInt32(Console.ReadLine());

        fat = n;
        for (c = n - 1; c >= 1; c--)// o número que é digitado vai pra a variavel "n" e depois, o que ta  na "n" é subtraido por 1(isso é necessário para a fatorial) vai pra variável "c"//
        {
            fat = fat * c;

        }
        Console.WriteLine("a fatorial do número que você digitou é ---> " + fat);
    }//for
    Console.ReadKey();
    Menu();
}//Calcular fatorial de 10 numeros

void Exercicio20()
{
    Console.Clear();
    Console.WriteLine("-----------(tabuada)------------");
    int r, n, c;

    Console.WriteLine("digite o numero que voce deseja saber a tabuada");

    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("digte até que número você deseja a tabuada");
   int limite = Convert.ToInt32(Console.ReadLine());


    for (c = 1; c <= limite ; c++)
    {
        r = n * c;
        Console.WriteLine(+n + "x" + c + "=" + r);

    }
    Console.ReadKey();
    Menu();
}//tabuada

void Exercicio21()
{
    Console.Clear();

    Console.WriteLine("-----------(Maior e Menor Altura de 15 valores)------------");
    float[] ArmazenaAlturas = new float[15];
    Console.WriteLine("Digite a altura da pessoa");
    for (int Contador = 0; Contador <= 14; Contador++)

    {
        Console.WriteLine($"Digite a {Contador + 1}ª altura");
        ArmazenaAlturas[Contador] = Convert.ToSingle(Console.ReadLine());
    }
  float MaiorAltura =ArmazenaAlturas.Max();
  float MenorAltura =ArmazenaAlturas.Min();

    Console.WriteLine("Maior altura é "+MaiorAltura);
    Console.WriteLine("Menor altura é "+MenorAltura);

    Console.ReadKey();
    Menu();

}//Altura de Homens e Mulheres

void Exercicio22()
{
    Console.Clear();
    Console.WriteLine("-----------(Digitar 10 números que serão somados entre si)------------");
    int c;
    int s = 0;

    for (c = 1; c <= 10;) // aqui é dito de  onde o contador começa e até onde ele pode ir//
    {



        Console.WriteLine("digite o " + c + "º numero");
        int vd = Convert.ToInt32(Console.ReadLine());
        c++;// aqui é dito que o contador vai acrescentar 1 numero por vez//

        s += vd;//isso faz com que o que for digitado seja automaticamente somado. Depois o valor da soma é transferido para a variavel "s" e , por fim, é exibido

    }

    Console.Write("a soma de tudo e--->" + s);
    Console.ReadKey();
    Menu();
}//Digitar 10 números que serão somados entre si

void Exercicio23()
{
    Console.Clear();
    Console.WriteLine("-----------(Média de altura de um time de 6 pessoas)------------");
    double m = 0;
    double r = 0;


    for (int c = 1; c <= 6; c++)
    {
        Console.WriteLine("digite a altura dos(as) 6 jogadores(as)" + c);
        double a = Convert.ToDouble(Console.ReadLine());

        m += a;

        r = m / 6;


    }
    Console.Write("Altura média do time==>" + r);

    Console.ReadKey();
    Menu();
}//Média de altura de um time de 6 pessoas

void Exercicio24()
{
    Console.Clear();
    Console.WriteLine("-----------(Algoritimo do Detran)------------");
    Console.WriteLine("Digite a quantidade de motoristas");
    int qntm = Convert.ToInt32(Console.ReadLine());
    int smt = 0;
    string motoristaMaiorMulta = ""; // Variável para armazenar o número do motorista com a maior multa
    int maiorMulta = 0; // Variável para armazenar o valor da maior multa

    for (int c = qntm; c > 0; c--) //A quantidade de vezes que o algoritmo será repetido será determinado pelo número que o user digitar//
    {
        //n;numero de motorista//
        //  nm;numero de multas//
        // vm;valor de cada multa//
        // res; resultado do numero de multas multiplicados pelo valor de multas//
        Console.WriteLine("(" + c + ")-digite o seu número da carteira de motorista");
        string n = Convert.ToString(Console.ReadLine());
        Console.WriteLine("digite o número de multas");
        int nm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("digite o valor de cada multa");
        int vm = Convert.ToInt32(Console.ReadLine());

        int res = nm * vm;//multiplicação entre o nº de multas e o valor das multas. Depois o valor é atribuído á variável "res"//
        smt += res;
        Console.WriteLine("O motorista de número ===> [" + n + "] deve R$:" + res);
        Console.WriteLine("}*************************************{");

        if (res > maiorMulta)
        {
            maiorMulta = res;
            motoristaMaiorMulta = n;
        }



    }

    Console.WriteLine("O motorista de número " + motoristaMaiorMulta + " teve a maior multa de R$:" + maiorMulta);

    Console.WriteLine("O valor total arrecadado com todas as multas foi [" + smt + "]");


    Console.ReadKey();
    Menu();
}//Algoritimo do Detran

// --BLOCOS DE COMANDOS DE CADA EXERCÍCIOS DENTRO DE UM DETERMINADO VOID ACIMA--/


//****************************************************************************************************//

void Menu()
{
    Console.ForegroundColor = ConsoleColor.Blue; // Define a cor do texto como azul
    Console.WriteLine(@"   
    :::     :::         ::::::::   ::::::::  :::::::::  ::::::::::: ::::::::::: ::::    ::::   ::::::::   ::::::::  
  :+: :+:   :+:        :+:    :+: :+:    :+: :+:    :+:     :+:         :+:     +:+:+: :+:+:+ :+:    :+: :+:    :+: 
 +:+   +:+  +:+        +:+        +:+    +:+ +:+    +:+     +:+         +:+     +:+ +:+:+ +:+ +:+    +:+ +:+        
+#++:++#++: +#+        :#:        +#+    +:+ +#++:++#:      +#+         +#+     +#+  +:+  +#+ +#+    +:+ +#++:++#++ 
+#+     +#+ +#+        +#+   +#+# +#+    +#+ +#+    +#+     +#+         +#+     +#+       +#+ +#+    +#+        +#+ 
#+#     #+# #+#        #+#    #+# #+#    #+# #+#    #+#     #+#         #+#     #+#       #+# #+#    #+# #+#    #+# 
###     ### ##########  ########   ########  ###    ### ###########     ###     ###       ###  ########   ########  ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
Após utilizar um dos algoritmos, aperte enter para retornar a este Menu");
                                                             
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("DIGITE O  NÚMERO CORRESPONDENTE AO ALGORITMO QUE VOCÊ DESEJA UTILIZAR  E APERTE 'ENTER' -BY Arthur ");
    Console.ResetColor();
    Console.WriteLine(@"
                  
(1) Algoritmo de Estoque                                      (13) Calcular a Média de Notas de um Aluno
(2) Algoritmo de Cotação do Dólar                             (14) Saber Qual de Dois Números é Maior ou se São Iguais
(3) Algoritmo de Comissão                                     (15) Verificar se um Número Está entre 0 e 9
(4) Litros e Horas Gastas em Viagem de Carro                  (16) Realizar as Quatro Operações Aritméticas
(5) Conversor de Graus Celsius para Fahrenheit                (17) Exibir Múltiplo, Números Pares e Calcular Média
(6) Conversor de Graus Fahrenheit para Celsius                (18) Contador Decrescente
(7) Conversor de Graus Fahrenheit para Celsius e Vice-Versa   (19) Calcular o Fatorial de Números
(8) Converter Idade em Dias                                   (20) Tabuada de um Número
(9) Relações de Números                                       (21) Maior e Menor Altura Entre 15 Pessoas
(10) Inverter Valores                                         (22) Digitar 10 Números para Soma
(11) Exibir Valores em Ordem Decrescente                      (23) Média de Altura de um Time de 6 Pessoas
(12) Exibir a Diferença entre Dois Números Digitados          (24) Algoritmo do Detran
                    
");

    //****************************************************************************************************//







    int numeroCaso = Convert.ToInt32(Console.ReadLine());
    // o Switch case que engloba todos os exercícios do 1 Ao 24 esta abaixo//
    switch (numeroCaso)
    {
        case 1:
            {
                Exercicio1();
                break;
            }

        case 2:
            {
                Exercicio2();
                break;
            }

        case 3:
            {
                Exercicio3();
                break;
            }

        case 4:
            {
                Exercicio4();
                break;
            }

        case 5:
            {
                Exercicio5();
                break;
            }

        case 6:
            {
                Exercicio6();
                break;
            }

        case 7:
            {
                Exercicio7();
                break;
            }

        case 8:
            {
                Exercicio8();
                break;
            }

        case 9:
            {
                Exercicio9();
                break;
            }

        case 10:
            {
                Exercicio10();
                break;
            }

        case 11:
            {
                Exercicio11();
                break;
            }

        case 12:
            {
                Exercicio12();
                break;
            }

        case 13:
            {
                Exercicio13();
                break;
            }

        case 14:
            {
                Exercicio14();
                break;
            }

        case 15:
            {
                Exercicio15();
                break;
            }

        case 16:
            {
                Exercicio16();
                break;
            }

        case 17:
            {
                Exercicio17();
                break;
            }

        case 18:
            {
                Exercicio18();
                break;
            }

        case 19:
            {
                Exercicio19();
                break;
            }

        case 20:
            {
                Exercicio20();
                break;
            }

        case 21:
            {
                Exercicio21();
                break;
            }

        case 22:
            {
                Exercicio22();
                break;
            }

        case 23:
            {
                Exercicio23();
                break;
            }

        case 24:
            {
                Exercicio24();
                break;
            }












        // DEFAULT ABAIXO: CASO NÃO SEJA DIGITADO NENHUM NUMERO QUE REPRESENTE ALGUM DOS EXERCÍCIOS (QUAL QUE NÚMERO QUE NÃO ESTEJA ENTRE O 1 E O 24)//
        default:
            {
                Console.WriteLine("incorreto, não existe essa opção");
                Thread.Sleep(500);
                Menu();
                break;
            }
    }
}
// o Switch case que engloba todos os exercícios do 1 Ao 24 esta acima//







