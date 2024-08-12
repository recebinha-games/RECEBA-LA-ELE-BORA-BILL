Console.WriteLine("Digite a nota1: ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2: ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3: ");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota4: ");
int nota4 = int.Parse(Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
Console.WriteLine("média da disciplina: " + media);

if(media >=60){
    Console.WriteLine("aprovado");
    return;
}
else if (media < 20){
    Console.WriteLine("reprovado");
    return;
}
else{
    Console.WriteLine("recuperação");
    float previsao = 120 - media;
    Console.WriteLine($"precisa de {previsao} para passar de ano");
}

Console.WriteLine("Digite o valor da prova final: ");
int provafinal = int.Parse(Console.ReadLine());

float mediafinal = (media + provafinal) / 2f;
Console.WriteLine("media final: " + mediafinal);

if(mediafinal >= 60){
    Console.WriteLine("aprovado");
}
else{
    Console.WriteLine("reprovado");
}