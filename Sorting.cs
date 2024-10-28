namespace sort_algorithms;

public class Sorting
{
    public void MergeSort(int[] lista, int inicio = 0, int fim = -1)
    {
        if (fim == -1)
            fim = lista.Length;
        
        if ((fim - inicio) > 1)
        {
            int meio = (fim + inicio) / 2;
            MergeSort(lista, inicio, meio);
            MergeSort(lista, meio, fim);
            Merge(lista, inicio, meio, fim);
        }
    }

    private void Merge(int[] lista, int inicio, int meio, int fim)
    {
        int[] left = new int[meio - inicio];
        int[] right = new int[fim - meio];

        for(int i = 0; i < left.Length; i++)
            left[i] = lista[inicio + i];
        for (int i = 0; i < right.Length; i++)
            right[i] = lista[meio + i];

        int topLeft = 0, topRight = 0;

        for (int k = inicio; k < fim; k++)
        {
            if (topLeft >= left.Length)
            {
                lista[k] = right[topRight];
                topRight++;
            }
            else if(topRight >= right.Length)
            {
                lista[k] = left[topLeft];
                topLeft++;
            }
            else if (left[topLeft] > right[topRight])
            {
                lista[k] = right[topRight];
                topRight++;
            }
            else
            {
                lista[k] = left[topLeft];
                topLeft++;
            }
        }
    }

    public void QuickSort(int[] lista, int inicio = 0, int fim = -1)
    {
        if (fim == -1)
            fim = lista.Length - 1; // Tira a última posição, pq a última posição é o pivô.

        if (fim > inicio)
        {
            int pivot = Partition(lista, inicio, fim);
            QuickSort(lista, inicio, pivot - 1);
            QuickSort(lista, pivot + 1, fim);
        }
    }

    private int Partition(int[] lista, int inicio, int fim)
    {
        int pivot = lista[fim];
        int i = inicio;

        for (int j = inicio; j < fim; j++)
        {
            if (lista[j] <= pivot)
            {
                (lista[i], lista[j]) = (lista[j], lista[i]);
                i++;
            }
        }
        
        (lista[i], lista[fim]) = (lista[fim], lista[i]);
        return i;
    }
}