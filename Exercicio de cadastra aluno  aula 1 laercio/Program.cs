using System.Collections.Generic;

List<string> nomes = new List<string>();
List<int> idades = new List<int>();
List<string> cursos = new List<string>();
List<string> reslt = new List<string>();

bool loop = true;

static void menu(string nome, string curso, int idade, string resultado, double media)
{
Console.WriteLine("\nAluno cadastrado:");
Console.WriteLine($"Aluno: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Curso: {curso}");
Console.WriteLine($"Media: {media}");
Console.WriteLine($"Aluno foi aprovado?: {resultado}\n");
}

while (loop)
{
string nome = "";
bool nome_valido = false;


while (!nome_valido)
{
    Console.WriteLine("Qual é o nome do aluno?: ");
    nome = Console.ReadLine()!;

    if (!string.IsNullOrWhiteSpace(nome))
        nome_valido = true;
    else
        Console.WriteLine("Nome inválido! Digite novamente.");
}

int idade = 0;
bool idade_valida = false;

while (!idade_valida)
{
    Console.WriteLine("Qual é a idade do aluno?: ");

    if (int.TryParse(Console.ReadLine(), out idade))
        idade_valida = true;
    else
        Console.WriteLine("Digite apenas números!");
}

string curso = "";
bool curso_valido = false;

while (!curso_valido)
{
    Console.WriteLine("Qual é o curso do aluno?: ");
    curso = Console.ReadLine()!;

    if (!string.IsNullOrWhiteSpace(curso))
        curso_valido = true;
    else
        Console.WriteLine("Curso inválido! Digite novamente.");
}

int n1;
Console.WriteLine("Qual é a nota 1?");
while (!int.TryParse(Console.ReadLine(), out n1))
    Console.WriteLine("Digite um número válido:");

int n2;
Console.WriteLine("Qual é a nota 2?");
while (!int.TryParse(Console.ReadLine(), out n2))
    Console.WriteLine("Digite um número válido:");

int n3;
Console.WriteLine("Qual é a nota 3?");
while (!int.TryParse(Console.ReadLine(), out n3))
    Console.WriteLine("Digite um número válido:");

double media = (n1 + n2 + n3) / 3.0;

string resultado;

if (media >= 6)
    resultado = "true";
else
    resultado = "false";

nomes.Add(nome);
idades.Add(idade);
cursos.Add(curso);
reslt.Add(resultado);

menu(nome, curso, idade, resultado, media);

while (true)
{
    Console.WriteLine("Quer cadastrar outros alunos? (sim / nao / 1 para ver lista): ");
    string pergunta = Console.ReadLine()!;

    if (string.IsNullOrWhiteSpace(pergunta))
    {
        Console.WriteLine("Digite uma opção válida!");
        continue;
    }

    pergunta = pergunta.ToLower();

    if (pergunta == "sim" || pergunta == "s")
    {
        loop = true;
        break;
    }

    if (pergunta == "nao" || pergunta == "n")
    {
        loop = false;
        break;
    }

    if (pergunta == "1")
    {
        Console.WriteLine("\nLista de alunos:\n");

        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"Aluno: {nomes[i]} | Idade: {idades[i]} | Curso: {cursos[i]} | Resultado: {reslt[i]}\n");
        }

        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}


}
