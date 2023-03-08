string inserir, frase;

Console.WriteLine("Insira sua string aqui: ");
frase = Console.ReadLine();
Console.WriteLine("Qual caractere deseja inserir: ");
inserir = Console.ReadLine();
inserir = InsereLetra(frase, inserir);
Console.WriteLine(inserir);

string InsereLetra(string normal, string insere)
{
    char[] aux = new char[normal.Length * 2];
    for (int i = 0, j = 0; i < normal.Length; i++, j++)
    {  
        if ((normal[i] != 'a' && normal[i] != 'e' && normal[i] != 'i' && normal[i] != 'o' && normal[i] != 'u' &&
           normal[i] != 'A' && normal[i] != 'A' && normal[i] != 'I' && normal[i] != 'O' && normal[i] != 'U') &&
           ((normal[i] >= 'a' && normal[i] <= 'z') || (normal[i] >= 'A' && normal[i] <= 'Z')))
        {
            aux[j + 1] = normal[i];
            aux[j] = insere[0];
            j++;
        }
        else
        {
            aux[j] = normal[i];
        }
    }

    string insereletra = new (aux);
    return insereletra;
}
