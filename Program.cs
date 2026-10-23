int inicio = 0;
int fim = 1000;
int x = inicio;
int somatorio = 0;

while(x <= fim)
{
    somatorio = somatorio + x;
    x = x + 1;
    // Console.WriteLine($"A soma dos inteiros entre {inicio} e {x} é {somatorio}.");
}

// conferencia
int somatorioesperado = ((inicio + fim) * 1001)/2;

Console.WriteLine($"A soma dos inteiros entre {inicio} e {fim} é {somatorio} (e esperado era {somatorioesperado}).");

