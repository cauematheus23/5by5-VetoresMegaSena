
int indice = 0, size = 6, aux = 0;
int[] jogo = new int[size];
int[] jogo_ordenado = new int[size];

while (indice < size)
{
    int numero = new Random().Next(1, 61); 
    bool repetido = false;

    for (int i = 0; i < indice; i++)
    {
        if (jogo[i] == numero)
        {
            repetido = true;
            break;
        }
    }
    if (!repetido)
    {
        jogo[indice] = numero;
        indice++;
    }
}
for (int i = 0; i < size; i++)
{
    jogo_ordenado[i] = jogo[i];
}
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        if (jogo_ordenado[i] > jogo_ordenado[j])
        {
            aux = jogo_ordenado[i];
            jogo_ordenado[i] = jogo_ordenado[j];
            jogo_ordenado[j] = aux;

        }
    }
}
Console.WriteLine("Jogo gerado");
for (int i = 0; i < size; i++)
{
    Console.Write(jogo[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Jogo gerado ordenado");
for (int i = 0; i < size; i++)
{
    Console.Write(jogo_ordenado[i] + " ");
}