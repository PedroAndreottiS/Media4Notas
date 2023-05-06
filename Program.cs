Console.WriteLine("Media 4 notas!!!!!!!");

double nota1, nota2, nota3, nota4, media;
media = 0;
string resultado;

bool ehValido = false;

do
{
    Console.WriteLine("Qual foi a sua nota do 1° bimestre?");

    nota1 = Convert.ToDouble(Console.ReadLine());




    Console.WriteLine("Qual foi a sua nota do 2° bimestre?");

    nota2 = Convert.ToDouble(Console.ReadLine());




    Console.WriteLine("Qual foi a sua nota do 3° bimestre?");

    nota3 = Convert.ToDouble(Console.ReadLine());




    Console.WriteLine("...e a do 4° bimestre?");

    nota4 = Convert.ToDouble(Console.ReadLine());




    if (nota1 < 0.0 || nota1 > 10.0 ||

       nota2 < 0.0 || nota2 > 10.0 ||

      nota3 < 0.0 || nota3 > 10.0 ||

      nota4 < 0.0 || nota4 > 10.0)

    {
        Console.WriteLine("Digite somente notas entre 0 e 10!");
        ehValido = false;
    }
    else
    {
        media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine($"Voce ficou com uma média de {media:N1}");
        ehValido = true;
       if (media < 5)

        {

            resultado = "REPROVADO";
            Console.WriteLine($"PARABÉNS! VOCE FOI {resultado}");
            Console.WriteLine();
            Console.WriteLine("Isso é tudo pe- pe- pe- pessoal");

        }


        else if (media <= 6)

        {

            resultado = "EM RECUPERAÇÃO";
            Console.WriteLine($"PARABÉNS! VOCE ESTÁ {resultado}");
            Console.WriteLine();
            Console.WriteLine("Isso é tudo pe- pe- pe- pessoal");

        }

        if (media > 6)
        {
            resultado = "APROVADO";
            Console.WriteLine($"PARABÉNS! VOCE FOI {resultado}");
            Console.WriteLine();
            Console.WriteLine("Isso é tudo pe- pe- pe- pessoal");

        }
    }

} while (!ehValido);