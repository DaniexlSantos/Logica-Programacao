using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            //Snippets prop
            
            //Primeiro exercicio estrutura sequêncial

            ////int codigo, quantidade, quantidade2, codigo2;
            ////float valor, valor2, preco;
            ////Console.WriteLine("Primeiro dados");
            ////codigo = int.Parse(Console.ReadLine());
            ////quantidade = int.Parse(Console.ReadLine());
            ////valor = float.Parse(Console.ReadLine());

            ////Console.WriteLine("Segundo dados");
            ////codigo2 = int.Parse(Console.ReadLine());
            ////quantidade2 = int.Parse(Console.ReadLine());
            ////valor2 = float.Parse(Console.ReadLine());

            //string[] n = Console.ReadLine().Split(' ');
            //string codigo = n[0];
            //int quantidade = int.Parse(n[1]);
            //Double valor = Double.Parse(n[2]);
            //string codigo2 = n[3];
            //int quantidade2 = int.Parse(n[4]);
            //Double valor2 = Double.Parse(n[5]);
            //double preco;

            //preco = ((double)quantidade * valor) + ((double)quantidade2 * valor2);

            //////preco = quantidade * valor + quantidade2 * valor2;

            //Console.WriteLine("Saldo a pagar: " + Math.Round(preco, 4).ToString(CultureInfo.InvariantCulture));

            //Segundo exercicio

            //float area,raio, pi=3.14159f;

            //Console.WriteLine("Insira o valor do raio");
            //raio = float.Parse(Console.ReadLine());
            //area = pi * (raio * raio);

            //Console.WriteLine("Saída: " + Math.Round(area, 4).ToString()); // Math Round limita a quantidade de casa decimais. (necessário formatar como string).



            //Terceiro Exercicio //Estrutura condicional

            //int codigo, quantidade;
            //float preco,contaapagar;

            //codigo = int.Parse(Console.ReadLine());
            //quantidade = int.Parse(Console.ReadLine());

            //if (codigo == 1)
            //{
            //    preco = 4.00f;
            //    contaapagar = preco * quantidade;
            //    Console.WriteLine(contaapagar);
            //}
            //if (codigo == 2)
            //{
            //    preco = 4.50f;
            //    contaapagar = preco * quantidade;
            //    Console.WriteLine(contaapagar);
            //}
            //if (codigo == 3)
            //{
            //    preco = 5.00f;
            //    contaapagar = preco * quantidade;
            //    Console.WriteLine(contaapagar);
            //}
            //if (codigo == 4)
            //{
            //    preco = 2.00f;
            //    contaapagar = preco * quantidade;
            //    Console.WriteLine(contaapagar);
            //}
            //if (codigo == 5)
            //{
            //    preco = 1.50f;
            //    contaapagar = preco * quantidade;
            //    Console.WriteLine(contaapagar);
            //}

            //Estruturas Repetitivas

            //int senha;

            //senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha inválida");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso permitido");

            //Laço de repitição usando FOR. 

            //int n, x, in2 = 0, out2=0;
                cw

            //Console.WriteLine("Insira a quantidade que os valores inteiros X serão lidos:");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Insira um valor inteiro");
            //    x = int.Parse(Console.ReadLine());

            //    if ((x >= 10) && (x <= 20))
            //    {
            //        in2 += 1;
            //    }
            //    else
            //    {
            //        out2 += 1;
            //    }

            //}
            //Console.WriteLine("\nIn: "  + in2 + "\nOut: " + out2 );


            //1ª Exercicio de fixação (Saida de dados em c#)

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escrtiório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //    double preco1 = 2100.00;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo o preço é ${ preco1}");
            //Console.WriteLine($"{produto2}, cujo o preço é ${ preco2}");

            //Console.WriteLine("Medida com ouitos casas decimais: " + medida.ToString("F8"));
            //Console.WriteLine("Arredodando para (três casas decimais): " + medida.ToString("F3"));
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            //2ª Exercicio de fixação (Entradas em C#)

            //string nome, ultimonome;
            //int quantidadequartos, idade;
            //double produto, altura;
            //string[] vet;

            //Console.WriteLine("Entre com seu nome completo");
            //nome = Console.ReadLine();

            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //quantidadequartos = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com  o preço de um produto");
            //produto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // Aceitando double separado com "."

            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            //vet = Console.ReadLine().Split(' ');
            //ultimonome = vet[0];
            //idade = int.Parse(vet[1]);
            //altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(quantidadequartos);
            //Console.WriteLine(produto.ToString("f2",CultureInfo.InvariantCulture));
            //Console.WriteLine(ultimonome + ' ' + idade + ' ' + altura.ToString("f2",CultureInfo.InvariantCulture));

            /*Exercicio sobre estrutura sequêncial*/

            //Exercicio 1

            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.

            //int valor1;
            //int valor2;
            //int soma;

            //Console.WriteLine("Insira o primeiro valor: ");
            //valor1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Insira o segundo valor: ");
            //valor2 = int.Parse(Console.ReadLine());

            //soma = valor1 + valor2;

            //Console.WriteLine("soma é: "+ soma);

            //Exercicio 2
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. 


            //double area, π=3.14159,raio;

            //Console.WriteLine("Informe o valor do raio");
            //raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //area = Math.Pow(raio, 2.0) * π;

            //Console.WriteLine("Área do Circulo é: " + area.ToString("f4", CultureInfo.InvariantCulture));

            //Exercicio 3
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            //int A, B, C, D, diferenca;
            //Console.WriteLine("Insira os valores: ");
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //diferenca = (A * B) - (C * D);

            //Console.WriteLine("Diferença = " + diferenca);

            //Exercicio 4 
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais. 

            //int numfuncionario, numerohorastrabalhada;
            //double salario,valorquerecebe;

            //Console.WriteLine("Informe o número do funcionário");
            //numfuncionario = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe quantas horas trabalhada");
            //numerohorastrabalhada = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor que recebe por hora");
            //valorquerecebe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = valorquerecebe * numerohorastrabalhada;

            //Console.WriteLine("Number= " + numfuncionario);
            //Console.WriteLine("Salary= " +"U$ " + salario.ToString("f2",CultureInfo.InvariantCulture));

            //Exercicio 5
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. 

            ////int codigo, quantidade, quantidade2, codigo2;
            ////float valor, valor2, preco;

            //string[] n = Console.ReadLine().Split(' ');
            //string codigo = n[0];
            //int quantidade = int.Parse(n[1]);
            //Double valor = Double.Parse(n[2]);
            //string codigo2 = n[3];
            //int quantidade2 = int.Parse(n[4]);
            //Double valor2 = Double.Parse(n[5]);
            //double preco;

            //preco = ((double)quantidade * valor) + ((double)quantidade2 * valor2);

            //////preco = quantidade * valor + quantidade2 * valor2;

            //Console.WriteLine("Saldo a pagar: " + Math.Round(preco, 4).ToString(CultureInfo.InvariantCulture));

            //Execicio 6 
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
            //a) a área do triângulo retângulo que tem A por base e C por altura.  b) a área do círculo de raio C. (pi = 3.14159)  c) a área do trapézio que tem A e B por bases e C por altura.d) a área do quadrado que tem lado B.  e) a área do retângulo que tem lados A e B. 

            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi=3.14159f;

            //Console.WriteLine("Insira os valores: ");
            //String[] vet = Console.ReadLine().Split(' ');
            //A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //triangulo = (A * C) / 2;
            //circulo = (C * C) * pi;
            //trapezio = (A + B) * (C / 2);
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine("Triangulo: " + triangulo.ToString("f3",CultureInfo.InvariantCulture));
            //Console.WriteLine("Circulo: " + circulo.ToString("f3",CultureInfo.InvariantCulture));
            //Console.WriteLine("Trapezio: " + trapezio.ToString("f3",CultureInfo.InvariantCulture));
            //Console.WriteLine("Quadrado: " + quadrado.ToString("f3",CultureInfo.InvariantCulture));
            //Console.WriteLine("Retangulo: " + retangulo.ToString("f3",CultureInfo.InvariantCulture));

            /*Exercicio sobre estrutura condicional (if-else)*/


            //           Exercício 01


            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.


            //           Console.WriteLine("Digite um número");
            //           int numero = int.Parse(Console.ReadLine());

            //           if (numero < 0)
            //           {
            //               Console.WriteLine("NEGATIVO");
            //           }
            //           else
            //           {
            //               Console.WriteLine("POSITIVO");
            //           }

            // Exercício 02

            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 

            //System.Console.WriteLine("DIGITE UM NÚMERO");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}

            //            Exercício 03
            //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

            //Console.WriteLine("Insira os valores: ");
            //string[] vs = Console.ReadLine().Split();
            //int numero1 = int.Parse(vs[0]);
            //int numero2 = int.Parse(vs[1]);

            //if ((numero1 % numero2 == 0) || (numero1 % numero2 == 0))
            //{
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Não são Multiplos");
            //}

            // Exercício 04 
            //Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            //Console.WriteLine("Insira as horas");
            //string[] vs = Console.ReadLine().Split();
            //int horainicial = int.Parse(vs[0]);
            //int horafinal = int.Parse(vs[1]);
            //int totalhoras = 0;

            //if (horainicial > horafinal)
            //{

            //    totalhoras = (24 - horainicial) + horafinal;
            //    Console.WriteLine("O JOGO DUROU " + totalhoras + "HORA(S)");
            //}
            //else
            //{
            //    totalhoras = horafinal - horainicial;
            //    Console.WriteLine("O JOGO DUROU " + totalhoras + " HORA(S)");
            //}

            // Exercício 05
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A seguir, calcule e mostre o valor da conta a pagar.
            //Console.WriteLine("Insira o codigo do item e quantidade");
            //string[] vs = Console.ReadLine().Split();
            //int codigo = int.Parse(vs[0]);
            //int quantidade = int.Parse(vs[1]);
            //double preco = 0.00;

            //if (codigo == 1)
            //{
            //    preco = quantidade * 4.00;
            //    Console.WriteLine("Total " + preco.ToString("C", CultureInfo.CurrentCulture));
            //}
            //else if (codigo == 2)
            //{
            //    preco = quantidade * 4.50;
            //    Console.WriteLine("Total " + preco.ToString("C", CultureInfo.CurrentCulture));
            //}
            //else if (codigo == 3)
            //{
            //    preco = quantidade * 5.00;
            //    Console.WriteLine("Total " + preco.ToString("C", CultureInfo.CurrentCulture));
            //}
            //else if (codigo == 4)
            //{
            //    preco = quantidade * 2.00;
            //    Console.WriteLine("Total " + preco.ToString("C", CultureInfo.CurrentCulture));
            //}
            //else if (codigo == 5)
            //{
            //    preco = quantidade * 1.50;
            //    Console.WriteLine("Total " + "R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            //}

            // Exercício 06 
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            //Console.WriteLine("Insira o valor");
            //double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //if ((valor < 0.0 ) || (valor > 100.00))
            //{
            //    Console.WriteLine("Fora do intervalo");
            //}else if (valor <= 25.0)
            //{
            //    Console.WriteLine("Intervalo (0, 25]");
            //}
            //else if (valor <= 50.0)
            //{
            //    Console.WriteLine("Intervalo (25, 50]");
            //}
            //else if (valor <= 75.0)
            //{
            //    Console.WriteLine("Intervalo (50, 75]");
            //}
            //else if (valor <= 100.0)
            //{
            //    Console.WriteLine("Intervalo (75, 100]");
            //}

            //           Exercício 07
            //               Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0). 
            //Se o ponto estiver na origem, escreva a mensagem “Origem”. 
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação

            //System.Console.WriteLine("Insira o X e Y");
            //string[] vs = Console.ReadLine().Split();
            //double x = double.Parse(vs[0],CultureInfo.InvariantCulture);
            //double y = double.Parse(vs[1], CultureInfo.InvariantCulture);

            //if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}else if (x > 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q4");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else
            //{
            //    Console.WriteLine("Origem");
            //}

            //           Exercício 08
            //               Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$. 
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo

            //Console.WriteLine("Insira o salario");
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double imposto = 0.0;
            //if (salario <= 2000.00)
            //{
            //    Console.WriteLine("Isento");
            //} else if (salario <= 3000.00) {

            //    imposto = (salario - 2000.00) * 0.08;

            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else if (salario <= 4500.00) {

            //    imposto = ((salario - 3000.00) * 0.18 + 1000.00 * 0.08);

            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //else if (salario  > 4500.00) {

            //    imposto = ((salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08);

            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //

            //Estrutura de repetição (While)

            //Exercicio 1              
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            //int senha;
            //Console.WriteLine("Insira a senha: ");
            //senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha inválida");
            //    Console.WriteLine("Insira novamente a senha: ");
            //    senha = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Acesso permitido");

            //Exercicio 2 
            //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)
            //Console.WriteLine("Insira o primeiro valor do X e em seguida o do Y");
            //double x, y;
            //string[] vs = Console.ReadLine().Split();
            //x = double.Parse(vs[0]);
            //y = double.Parse(vs[1]);

            //while (x != null || y!= null)
            //{
            //    if (x > 0.0 && y > 0.0)
            //    {
            //        Console.WriteLine("Primeiro Quadrante");

            //    }
            //    else if (x > 0.0 && y < 0.0)
            //      {
            //          Console.WriteLine("Quarto Quadrante");
            //      }
            //      else if (x < 0.0 && y < 0.0)
            //      {
            //          Console.WriteLine("Terceiro Quadrante");
            //      }
            //      else if (x < 0.0 && y > 0.0)
            //      {
            //          Console.WriteLine("Segundo Quadrante");
            //      }

            //    string[] ab = Console.ReadLine().Split();
            //    x = double.Parse(ab[0]);
            //    y = double.Parse(ab[1]);
            //}
            //Console.WriteLine("Tem valor nulo");

            //Exercicio 03
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo

            //Console.WriteLine("Insira o tipo de combustivel");
            //int tipoCombustivel = int.Parse(Console.ReadLine());
            //int countalcool = 0;
            //int countgasolina = 0;
            //int countdiesel = 0;

            //while (tipoCombustivel != 4)
            //{

            //    if (tipoCombustivel == 1)
            //    {
            //        countalcool += 1 ;
            //    }
            //    else if (tipoCombustivel == 2)
            //    {
            //        countgasolina += 1;
            //    }
            //    else if (tipoCombustivel == 3)
            //    {
            //        countdiesel += 1;
            //    }
            //    Console.WriteLine("Novo valor: ");
            //    tipoCombustivel = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Muito Obrigado");
            //Console.WriteLine("Alcool: " + countalcool);
            //Console.WriteLine("Gasolina: " + countgasolina);
            //Console.WriteLine("Diesel: " + countdiesel);

            //Estrutura de repetição (For)
            //Exercicio 1
            //Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. 

            //int x;
            //x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x && x <=1000; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercicio 2
            //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            //int x, n, inp=0, outp=0;

            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    x = int.Parse(Console.ReadLine());
            //    if ( x >= 10 && x <=20 )
            //    {
            //        inp += 1;
            //    }
            //    else
            //    {
            //        outp += 1;
            //     }

            //}
            //Console.WriteLine(inp + " in");
            //Console.WriteLine(outp +  "out");

        }

    }
}
