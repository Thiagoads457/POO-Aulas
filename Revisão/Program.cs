/*Console.WriteLine("Olá Fera");
Console.Write("Digite seu ano de nascimento: ");
int anoNascimento = Convert.ToInt32(Console.ReadLine());
int idade = 2024 - anoNascimento;
Console.WriteLine("Idade: " + idade);
// Estrutura de descisão
if (idade >= 18)
    Console.WriteLine("Maior de Idade");
else 
    Console.WriteLine("Menor de Idade");

int estacao = 1;
switch (estacao)
{
    case 1: Console.WriteLine("Verão");
            break;
    case 2: Console.WriteLine("Outono");
            break;
    default: Console.WriteLine("Estação Inválida");
            break;
}

// Estrutura de Repetição - for

for (int t = 1; t <= 10; t++)
    Console.WriteLine("5 x " + t + " = " + (5 * t));



//Estrutura de repetição - While

int t = 1;
while (t <= 10)
{
    Console.WriteLine("5 x " + t + " = " + (5 * t));
    t++;
}

//Estrutura de repetição - do While
int t = 1;
do
{
    Console.WriteLine("5 x " + t + " = " + (5 * t));
    t++;
} while (t <= 10);

//array - Vetor
int[] vet = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(" Digite um número: ");
    vet[i] = Convert.ToInt32(Console.ReadLine());
}
// Estrutura de repetição - foreach
foreach (int v in vet)
    Console.WriteLine(v);
for (int i = 0; i < vet.Length; i++)
    System.Console.WriteLine(vet[i]);


//Função sem parametro e sem retorno
void Somar()
{
    int a = 10;
    int b = 2;
    int r = a + b;
    Console.WriteLine(" O resultado é: " + r);
}
//chamar a função
Somar();

//Função com parametro e sem retorno
void Somar(int a, int b)
{
    Console.WriteLine("O resultado é " + (a + b));
    
}
int x = 22;
int y = 51;
Somar(x,y);

//Função sem parametro e com retorno
int Somar()
{
    int a = 41;
    int b = 10;
    return a + b;
}
Console.WriteLine("O resultado é " + Somar());
// ou
int result = Somar();
Console.WriteLine("O Resultado é " + result);
//if (result > 0)
*/
//Função com parametro e com retorno

int Somar(int a, int b)
{
    return a + b;
}
Console.WriteLine("O Resultado é " + Somar(10,25));
//ou
//int r = Somar(10,25)