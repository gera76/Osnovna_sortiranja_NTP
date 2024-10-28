Console.Write("unesi duzinu niza : ");
int n = int.Parse(Console.ReadLine());
int[] niz = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Unesi element {i + 1}: ");
    niz[i] = int.Parse(Console.ReadLine());
}


// buble sort

for (int i = n; i > 0; i--)
{
    for (int j = 0; j < i - 1; j++)
    {

        if (niz[j] > niz[j + 1])
        {
            int a = niz[j];
            niz[j] = niz[j + 1];
            niz[j + 1] = a;
        }
    }
}
// insertion sort
for (int i = 1; i < n; i++)
{
    int el = niz[i];
    int j;
    for (j = i; j > 0 && niz[j - 1] > el; j--)
    {

        int tmp = niz[j];
        niz[j] = niz[j - 1];
        niz[j - 1] = tmp;

    }
    niz[j] = el;
}




// selection sort
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < n; j++)
    {
        if (niz[j] < niz[minIndex])
        {
            minIndex = j;
        }
    }


    if (minIndex != i)
    {
        int temp = niz[i];
        niz[i] = niz[minIndex];
        niz[minIndex] = temp;
    }
}




Console.Write("sortirani niz : ");

foreach (int element in niz)
{
    Console.Write(element + " ");
}

