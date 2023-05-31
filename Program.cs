Console.WriteLine("Hello, World!");
/*2) O preço de um automóvel é calculado pela soma do preço de fábrica com o preço pago de impostos (
45% do preço de fábrica ) e a porcentagem paga de comissão aos revendedores ( 28% do preço de
fábrica ). Faça um algoritmo que leia o nome e o preço de fábrica do automóvel e imprima o seu nome e
o preço final.*/

//string nome;
//decimal preco, precoFinal;
////Pega os Dados
//Console.WriteLine("Digite o nome do veículo");
//nome = Console.ReadLine();
//Console.WriteLine("Digite o preço de fábrica do automóvel:");
//preco = Convert.ToDecimal(Console.ReadLine());
////Faz o cálculo do Valor
//precoFinal = preco + (45*preco/100);//180
//precoFinal = (precoFinal + (28*preco/100));//273
//
//Console.WriteLine($"Autóvel:{nome}\r\n Preço final:R${precoFinal.ToString("F2")}");



/*3) Faça um algoritmo que leia dois números inteiros e jogue-os nas variáveis A e B. O algoritmo deverá
então trocar o conteúdo destas variáveis. Deverão ser impressos os conteúdos das variáveis A e B antes
e depois de efetuada a troca.*/

//Console.WriteLine("Digite um número");
//int numA = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite outro:");
//int numB = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine($"Os valores das váriaveis originais são:A-{numA} B-{numB}");
//int varC = numA;//Foi criado uma outra variavel para armazenar o valor de A, para fazer a troca.
//numA = numB;
//numB = varC;
//Console.WriteLine($"Os valores trocados são:A-{numA} B-{numB}");



/*4) Suponha que uma pessoa tenha comprado 3 artigos em uma loja, tendo, para cada artigo, seu nome,
preço e percentual de desconto. Faça um algoritmo em Portugol que imprima o nome, preço e preço com
desconto de cada artigo comprado, além do total da conta a pagar.*/

//string nameA, nameB, nameC;
//decimal precoA, precoB,precoC,
//        descA, descB, descC;
////Pegando os Valores
//Console.Write("Digite o nome do primeiro Artigo:");
//nameA = Console.ReadLine();
//Console.Write("Preço:R$");
//precoA = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Digite o desconto:");
//descA = Convert.ToDecimal(Console.ReadLine());
//
//Console.Write("Digite o nome do segundo artigo:");
//nameB = Console.ReadLine();
//Console.Write("Preço:R$");
//precoB = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Digite o desconto:");
//descB = Convert.ToDecimal(Console.ReadLine());
//
//Console.Write("Digite o nome do terceiro artigo:");
//nameC = Console.ReadLine();
//Console.Write("Preço:R$");
//precoC = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Digite o desconto:");
//descC = Convert.ToDecimal(Console.ReadLine());
//////////////////////////////////////////////////
//
//Console.WriteLine($"Artigo1\r\nNome:{nameA}\r\nPreço{precoA}\r\nPreço com desconto{precoA-descA*precoA/100}\r\n///////////////////////////////////////////////////////////////////////");
//Console.WriteLine($"Artigo2\r\nNome:{nameB}\r\nPreço{precoB}\r\nPreço com desconto{precoB-descB*precoB/100}\r\n///////////////////////////////////////////////////////////////////////");
//Console.WriteLine($"Artigo3\r\nNome:{nameC}\r\nPreço{precoC}\r\nPreço com desconto{precoC-descC*precoC/100}\r\n///////////////////////////////////////////////////////////////////////");



/*5) Faça um algoritmo em Portugol que leia a base e a altura de um triângulo e calcule a sua área
conforme a fórmula A = ( B * H ) / 2 . Deverão ser impressos a base, altura e a área do triângulo.*/

//Console.WriteLine("Digite a Base do triângulo");
//decimal b = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine("Digite a altura");
//decimal h = Convert.ToDecimal(Console.ReadLine());
//
//Console.WriteLine($"A área do triângulo é:{(b*h/2).ToString("F2")}");



/*6) Suponha que você foi ao supermercado e comprou 2 produtos. Faça um algoritmo em Portugol que
leia e nome e o preço dos produtos comprados e calcule o preço total da compra sabendo que você
obteve um desconto de 20%. Deverão ser impressos os nomes dos 2 produtos comprados, seus preços
unitários e o valor total da compra com e sem o desconto obtido.*/

//Console.WriteLine("Digite o nome do produto");
//string nomeA = Console.ReadLine();
//Console.WriteLine("Digite o preço:R$");
//decimal precoA = Convert.ToDecimal(Console.ReadLine());
//
//Console.WriteLine("Digite o nome do produto:");
//string nomeB = Console.ReadLine();
//Console.WriteLine("Digite o preço:R$");
//decimal precoB = Convert.ToDecimal(Console.ReadLine());
//
//Console.WriteLine($"produto:{nomeA}\r\n Preço:R${precoA.ToString("C")}\r\n Preço com desconto:R${(precoA-(20*precoA/100)).ToString("C")} ");
//Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
//Console.WriteLine($"produto:{nomeB}\r\n Preço:R${precoB.ToString("C")}\r\n Preço com desconto:R${(precoB-(20*precoB/100)).ToString("C")} ");



/*7) Considere que uma empresa queira dar uma aumento salarial a um funcionário. Deste funcionário, a
empresa possui as seguintes informações: seu nome, idade e salário base. O procedimento adotado
para o cálculo de aumento do salário é o seguinte: 1) Reajustar o salário base do funcionário em 30%; 2)
Conceder uma gratificação de 20% sobre o salário já reajustado; 3) Efetuar descontos de 15% sobre o
salário já reajustado e sem a concessão da gratificação. Deverão ser impressos o nome e o novo salário
do funcionário na sua forma bruta ( aumento + gratificação ) e líquida ( aumento + gratificação -
descontos ).*/

//Console.WriteLine("Digite o nome");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite a sua idade");
//int idade = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Digite o salário base:");
//decimal salario = decimal.Parse(Console.ReadLine());
//salario = salario + 30*salario/100;//1690
//
//Console.WriteLine($"Salário bruto:R${(salario + (20*salario)/100).ToString("C")}");//2028
//Console.WriteLine($"Salario Liquido:R${((salario + 20*salario/100)-(15*salario/100)).ToString("C") }");



/*8) Faça um algoritmo em Portugol que calcule o valor da mensalidade que um aluno deverá pagar. O
algoritmo deve ler o nome do aluno, número de créditos que o mesmo está cursando e o valor unitário do
crédito. Deverão ser impressos o nome do aluno e o valor da mensalidade devida pelo mesmo.*/

//Console.WriteLine("Digite o nome do Aluno");
//string name = Console.ReadLine();
//Console.WriteLine("Valor da mensalidade");
//decimal mensalidade = Decimal.Parse(Console.ReadLine());
//
//Console.WriteLine("Digite a quantidade de crédito:");
//int quantiCredito = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o valor unitário do crédito:R$");
//decimal valorCredito = decimal.Parse(Console.ReadLine());
//decimal credito = valorCredito*quantiCredito;
//Console.WriteLine($"Aluno:{name}\r\n Valor da Mensalidade{mensalidade}\r\nValor da Mensalidade com desconto{mensalidade - (mensalidade*credito/100)}");



/*9) Considere que você possua o nome e os preços de uma mercadoria em 01/FEV e 01/MAR. Faça um
algoritmo em Portugol que leia estes dados e calcule a variação percentual ocorrida no preço da
mercadoria naquele período. Deverão ser impressos o nome da mercadoria, seus preços em 01/FEV e
01/MAR e a variação percentual ocorrida no preço da mesma naquele período.*/

//string nome ;
//decimal precoFev, precoMar;
//Console.Write("Digite o nome da mercadoria:");
//nome = Console.ReadLine();
//Console.Write("Digite o preço da mercadoria de Fevereiro:R$");
//precoFev = Decimal.Parse(Console.ReadLine());
//Console.Write("Digite o preço da mercadoria de Março:R$");
//precoMar = Decimal.Parse(Console.ReadLine());
//Console.WriteLine($"A variação porcentual do produto:{nome} é de {(((precoMar-precoFev)/precoFev)*100).ToString("C")}");
//decimal variacao = ((precoMar-precoFev)/precoFev)*100;
//if (variacao > 0)
//{
//    Console.WriteLine("Houve um aumento na variação");
//
//}
//else
//{
//    Console.WriteLine("Não houve um aumento na variação");
//}



/*10) Faça um algoritmo em Portugol que verifique se um aluno foi aprovado ou não. O algoritmo deve ler
o nome do aluno, suas 3 notas, juntamente com seus 3 pesos e calcular a média ponderada do aluno de
acordo com a fórmula abaixo:
média =p1*nota1 + p2*nota2 + p3*nota3/p1+p2+p3

Após o cálculo da média, o algoritmo deverá verificar o conceito final do aluno e indicar sua aprovação
ou não, conforme a tabela abaixo:
Média Conceito Resultado
9.00 - 10.00 A Aprovado
7.50 - 8.99 B Aprovado
6.00 - 7.49 C Aprovado
5.00 - 5.99 D Reprovado
0.00 - 4.99 E Reprovado
O algoritmo deverá imprimir o nome do aluno, seu conceito e o resultado final.*/

//Console.Write("Digite o nome do Aluno:");
//string name = Console.ReadLine();
//Console.WriteLine("Digite as notas");
//Console.Write("Nota 1:");
//double nota1 = double.Parse(Console.ReadLine());
//Console.Write("Pese 1:");
//double p1 = double.Parse(Console.ReadLine());
//
//Console.Write("Nota 2:");
//double nota2 = double.Parse(Console.ReadLine());
//Console.Write("Peso 2:");
//double p2 = double.Parse(Console.ReadLine());
//
//Console.Write("Nota 3:");
//double nota3 = double.Parse(Console.ReadLine());
//Console.Write("Peso 3:");
//double p3 = double.Parse(Console.ReadLine());
//double media = (((p1*nota1)+ (p2*nota2)+(p3*nota3))/(p1+p2+p3));
//Console.WriteLine($"MÉDIA:{media}");
//
//switch (media)
//{
//    case >=0 and < 5 : Console.WriteLine("Conceito: E");
//    break;
//
//    case >= 5 and < 6 : Console.WriteLine("Conceito: D");
//    break;
//    
//    case >= 6 and < 7.49 : Console.WriteLine("Conceito: C");
//    break;
//
//    case >= 7.50 and < 9 : Console.WriteLine("Conceito: B");
//    break;
//
//    case >= 9 and <= 10 : Console.WriteLine("Conceito: A");
//    break;
//}
//if(media <= 5)
//{
//    Console.WriteLine("REPROVADO!!!!!");
//
//}
//else
//{
//    Console.WriteLine("APROVADO!!!");
//}



/*11) Faça um algoritmo em Portugol que leia três números e jogue-os nas variáveis num1, num2, num3.
Após isto, o algoritmo deverá movimentar os valores das variáveis da seguinte forma: jogar o valor
original da variável num1 na variável num3; o valor original de da variável num3 na variável num2 e o
valor original da variável num2 na variável num1. Deverão ser impressos os valores das três variáveis
antes e após a movimentação dos valores.*/

//Console.WriteLine("Escreva um número");
//int num1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Escreva outro número");
//int num2 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Escreva outro número");
//int num3 = Int32.Parse(Console.ReadLine());
//
//Console.WriteLine($"Valor Original A:{num1}");
//Console.WriteLine($"VAlor Original B:{num2}");
//Console.WriteLine($"Valor Original C:{num3}");
//
//int num4 = num1;
//    num1 = num2;
//    num2 = num3;
//    num3 = num4;
//Console.WriteLine($"Valor trocado A:{num1}");
//Console.WriteLine($"Valor trocado B:{num2}");
//Console.WriteLine($"Valor trocado C:{num3}");



/*12) Faça um algoritmo em Portugol que leia dois números inteiros e identifique se os mesmos são iguais
ou diferentes. Caso eles sejam iguais imprima uma mensagem dizendo que eles são iguais. Caso
contrário, diga qual dos dois números é o maior.*/

//Console.WriteLine("Digite um valor");
//int numA = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Digite outro valor");
//int numB = Int32.Parse(Console.ReadLine());
//
//if(numA == numB)
//{
//    Console.WriteLine("Os valores são iguais");
//
//}
//    else if(numA > numB)
//    {
//        Console.WriteLine($"O valor {numA} é maior que {numB}");
//    }
//else
//{
//    Console.WriteLine($"O valor {numB} é maior que {numA}");
//}



/*13) Faça um algoritmo em Portugol que leia 4 números e jogue-os nas variáveis opção, num1, num2 e
num3. O algoritmo deverá então imprimir o valor de num1 se a opção for igual a 2; o valor de num2 se a
opção for igual a 3 e o valor de num3 se a opção for igual a 4. Os únicos valores possíveis para a
variável opção são 2, 3 e 4.*/

//Console.WriteLine("APENAS VALORES: 2, 3 e 4!!!!");
//Console.Write("Digite um valor:");
//int num1 = Int32.Parse(Console.ReadLine());
//Console.Write("Digite outro valor:");
//int num2 = Int32.Parse(Console.ReadLine());
//Console.Write("Digite outro valor");
//int num3 = Int32.Parse(Console.ReadLine());
//
//if(num1 == 2)
//{
//    Console.WriteLine(num1);
//}
//if(num2 == 3)
//{
//    Console.WriteLine(num2);
//}
//if(num3 == 4)
//{
//    Console.WriteLine(num3);
//}
//else if (num1 != 2 && num2 != 3 && num3 != 4)
//{
//    Console.WriteLine("Todos os númeors não correspondem aos valores desejáveis ");
//}



/*14) Faça um algoritmo que leia três número diferentes e imprima o maior número dentre os três.*/
//int num =0;
//int numero = 0;
//for (int i = 0; i < 3; i++)
//{
//    Console.Write("Digite um valor");
//     num = Int32.Parse(Console.ReadLine());
//    if (num > numero)
//    {
//        numero = num;
//    }
//}
//Console.WriteLine($"Maior número é:{numero}");



/*15) Suponha que a Universidade possua a seguinte tabela de valores de créditos por curso;
Curso Valor do Crédito
PD 12,00
ADM 10,00
CONTAB 15,00
CIÊNCIAS 8,00
Faça um algoritmo em Portugol que leia o nome de um aluno, curso que o mesmo está matriculado e o
número de créditos que o ele está cursando e calcule a mensalidade a ser paga pelo aluno. Deverão ser
impressos o nome do aluno, seu curso e o valor da mensalidade a pagar.*/

//decimal mensalidade;
//Console.WriteLine("Digite o nome do Aluno:");
//string name =Console.ReadLine();
//Console.WriteLine("Digite o curso:");
//string curso = Console.ReadLine();
//Console.WriteLine("Digite o numero de c´reditos:");
//decimal credito = decimal.Parse(Console.ReadLine());
//
//Console.WriteLine($"Nome do aluno:{name}");
//switch (curso)
//{
//    case "PD": 
//        mensalidade = credito * 12;
//        Console.WriteLine($"O valor da mensalidade é {mensalidade.ToString("C")}");
//    break;
//
//    case "ADM":
//        mensalidade = credito * 10;
//        Console.WriteLine($"O valor da mensalidade é {mensalidade.ToString("C")}");
//    break;
//
//    case "CONTAB":
//        mensalidade = credito * 15;
//        Console.WriteLine($"O valor da mensalidade é {mensalidade.ToString("C")}");
//    break;
//
//    case "CIENCIAS":
//        mensalidade = credito * 8;
//        Console.WriteLine($"O valor da mensalidade é {mensalidade.ToString("C")}");
//    break;
//}



/*16) Faça um algoritmo em Portugol que leia o nome, o sexo, a altura e a idade de uma pessoa e calcule
e imprima o seu peso ideal de acordo com as seguintes características da pessoa:*/

//Console.Write("Digite o seu nome:");
//string name = Console.ReadLine();
//Console.Write("Digite seu sexo:(F)feminino/ (M)masculino");
//string sexo = Console.ReadLine();
//Console.Write("Digite sua altura");
//float altura = float.Parse(Console.ReadLine());
//Console.Write("Digite sua idade");
//float idade = float.Parse(Console.ReadLine());
//
//if (sexo == "M")
//{
//    if (altura > 1.70)
//    {
//        switch (idade)
//        {
//            case <= 20: 
//                Console.WriteLine($"Peso ideal:{((72.7 * altura) - 58).ToString("F2")}");
//            break;
//
//            case > 20:
//                Console.WriteLine($"Peso Ideal:{((72.7 * altura)-45).ToString("F2")}");
//            break;
//
//        }
//    }
//    else if (altura <= 1.70)
//    {
//        switch(idade)
//        {
//            case <= 40:
//                Console.WriteLine($"Peso ideal:{((72.7 * altura) - 50).ToString("F2")}");
//            break;
//
//            case > 40:
//                Console.WriteLine($"Peso ideal:{((72.7 * altura) - 58).ToString("F2")}");
//            break;
//        }
//    }
//    
//
//}
//else if (sexo == "F")
//{
//    if (altura > 1.50)
//    {
//        Console.WriteLine($"Peso ideal:{((62.1 * altura)-44).ToString("F2")}");
//    }
//    else if(altura <= 1.50)
//    {
//        switch(idade)
//        {
//            case >= 35:
//                Console.WriteLine($"Peso ideal:{((62.1 * altura)-45).ToString("F2")}");
//            break;
//
//            case < 35:
//                Console.WriteLine($"Peso ideal:{((62.1 * altura)-49).ToString("F2")}");
//            break;
//
//        }
//    }
//}



/*17) Faça um algoritmo em Portugol que leia o código do departamento em que um funcionário trabalha (
1-secretaria, 2-tesouraria, 3-depto pessoal, 4-almoxarifado), seu nome, salário base e o tempo de
serviço. O algoritmo deverá então calcular e imprimir o novo salário base do funcionário conforme as
condições abaixo:
Departamento │ Tempo de Serviço │ % de Aumento
             │                  │
Secretaria ou│   < 4 anos       │ 50%
Tesouraria   │   > 4 anos       │ 60%
             │                  │
Depto Pessoal│ independente     │ 30%
             │                  │
Almoxarifado │  > 2 anos        │ 30%
             │>=2 anos e <=4anos│ 40%
             │> 4 anos          │ 50%
Deverão ser impressos o nome do funcionário, seu salário antigo e o novo salário.*/
//
//Console.WriteLine("Digite o departamento \r\n 1-secretaria\r\n 2-tesouraria\r\n 3-depto pessoal\r\n 4-almoxarifado");
//decimal departamento = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Digite seu nome:");
//string name = Console.ReadLine();
//Console.WriteLine("Digite o salário base");
//decimal salarioBase = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite o tempo de serviço(anos):");
//decimal tempo = decimal.Parse(Console.ReadLine());
//decimal salarioNovo = 0;
//
//    if(departamento == 1 || departamento == 2)
//    {
//        switch(tempo)
//        {
//            case < 4:
//                salarioNovo = salarioBase +(salarioBase * 50/100);
//            break;
//
//            case > 4:
//                salarioNovo = salarioBase +(salarioBase * 60/100);
//            break;
//
//        }
//    }
//    else if(departamento == 3)
//    {
//        salarioNovo = salarioBase +(salarioBase*30/100);
//    }
//    else if(departamento ==4)
//    {
//        switch(tempo)
//        {
//            case <=2:
//                salarioNovo = salarioBase +(salarioBase*30/100);
//            break;
//            
//            case >= 2 and <=4:
//                salarioNovo = salarioBase +(salarioBase*40/100);
//            break;
//
//            case > 4:
//                salarioNovo = salarioBase +(salarioBase*50/100);
//            break;
//        }
//    }
//    Console.WriteLine($"Nome:{name}\r\nDepartamento:{departamento}\r\nSalario:{salarioBase}\r\nSalario com aumento:{salarioNovo}");



/*18) Faça o teste de mesa do algoritmo abaixo diga qual o conteúdo das variáveis A, B e AUX após o
término da sua execução:
Inicio
a = 10
b = 20
aux = 10
a = b
b = a
soma = a + b
Se soma >= a + aux Então
Se a = b Então
aux = a + b
a = 10
b = 20
Fim Se
Senão
aux = b - a
a = aux - 10
b = aux + 10
Fim Se
Fim*/

//int a = 10, b=20, aux =10, soma;
//a = b;
//b = a;
//soma = a + b;
//if(a == b)
//{
//    aux = a+b;
//    a = 10;
//    b = 20;
//}
//else
//{
//    aux = b - a;
//    a = aux - 10;
//    b = aux + 10;
//}
//Console.WriteLine($"a={a}\r\nb={b}\r\naux={aux}");



/*19) Faça o teste de mesa do algoritmo abaixo diga qual o conteúdo das variáveis A, B e AUX após o
término da sua execução:
Inicio
a = 10
b = 20
aux = 10
a = b + aux
b = a + aux
aux = a + b
total = aux - ( aux - a - b )
se aux = total então
se b > a então
a = b - a
b = aux - b - a
aux = total - 2*b - 2*a
fimse
senão
a = a - b
b = aux - b
aux = total - a
fimse
Fim*/

//int a = 10, b = 20, aux = 10;
//a = b + aux;
//b = a + aux;
//aux = a + b;
//int total = aux - (aux - a - b);
//if( aux == total)
//{
//    a = b - a;
//    b = aux - b - a;
//    aux = total - 2*b - 2*a;
//}
//else
//{
//    a = a - b;
//    b = aux - b;
//    aux = total - a;
//}
//Console.WriteLine($"a={a}\r\nb={b}\r\naux={aux}");



/*20) Suponha que uma empresa deseja fazer uma seleção ente os funcionários para o aumento salarial.
Só participará deste aumento o funcionário que possuir mais de 4 anos de serviço, mais de 3
dependentes e salário atual abaixo de R$ 500,00. Faça um algoritmo em Portugol que leia estes dados
de um funcionário e imprima uma mensagem dizendo se ele tem direito ao aumento ou não. Caso ele
tenha este direito, calcule o novo salário deste funcionário em função de uma taxa de aumento de 48%.
Deverão ser impressos o nome do funcionário, seu salário antigo e o novo salário.*/

//Console.WriteLine("Digite o nome");
//string name = Console.ReadLine();
//Console.WriteLine("Digite o tempo de serviço(ano)");
//decimal ano = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Digite o numero de dependentes");
//decimal dependente = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Digite o salário");
//decimal salario = decimal.Parse(Console.ReadLine());
//
//if (ano > 4 && dependente > 3 && salario < 500)
//{
//    decimal novoSalario = salario + (salario * 48/100);
//    Console.WriteLine($"Nome:{name}\r\nSituação:APROVADO!!!!\r\nSalario atual:{salario}\r\nNovo salário:{novoSalario}");
//}
//else
//{
//    Console.WriteLine($"Nome:{name}\r\nSituação:REPROVADO!!!!");
//}

Console.WriteLine("digite um valor")      ;
 int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i ==   0   ) {
                count++;
            }
        }
            if (count <  3    ) {
                Console.WriteLine(false);
            }
            else if(count >= 3){
         Console.WriteLine(true );
            }








